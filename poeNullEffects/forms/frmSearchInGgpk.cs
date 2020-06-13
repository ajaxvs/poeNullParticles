/*
 * User: ajaxvs
 * Date: 02.01.2018
 * Time: 18:06
 */
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using ajClasses.ajBS;
using poeNullEffects.app;
using poeNullEffects.app.logic;

namespace poeNullEffects {
    public partial class frmSearchInGgpk : Form {
        //================================================================================
        private const int MAX_TEXT_LENGTH_TO_READ = 1 * 1024 * 1024;
        private const int MAX_TEXT_LENGTH_TO_SHOW = 128 * 1024;
        private const string keyPrefix = "root\\";
        private int keyPrefixLen = 0;
        //================================================================================
        private readonly string[] aTextFileExtensions = new string[] {
            ".ffx", ".txt", ".ao", ".aoc", ".pet", ".epk", ".env", ".ot", ".otc"
        };
        private readonly string[] aIgnoredExtensions = new string[] {
            ".smd", ".ogg"
        };
        private readonly string[] aPictureExtensions = new string[] {
            ".png", ".jpg", ".bmp"
        };
        //.mat can be text and binary.        
        //================================================================================
        private int foundItems = 0;
        private string lastQuery = "";
        private bool isLastQueryRegExp = false;
        private List<string> aResults = new List<string>();
        
        private Thread thSearch = null;
        private Thread thDdsConvert = null;
        
        private Bitmap lastSelectedBitmap = null;
        //================================================================================
        public frmSearchInGgpk() {
            InitializeComponent();
            
            picValue.Visible = false;            
            mnuSavePicture.Enabled = false;
            
            test0();
        }
        //================================================================================
        private void test0() {
            //.
        }
        //================================================================================
        private void FrmSearchInGgpkLoad(object sender, EventArgs e) {			
            keyPrefixLen = keyPrefix.Length;
			
            lstResults.MultiSelect = false;            
            lstResults.UseCompatibleStateImageBehavior = false;
            lstResults.View = System.Windows.Forms.View.Details;
            lstResults.VirtualMode = true;
            lstResults.RetrieveVirtualItem += new RetrieveVirtualItemEventHandler(lstResults_RetrieveVirtualItem);
            LstResultsResize(null, null);
            
            txtQuery.Text = "\\renderer\\";
            startQuery();
        }
        //================================================================================
        private void LstResultsResize(object sender, EventArgs e) {
            try {                
                mnuColumnResults.Width = lstResults.Width - 5;
                lstResults.Invalidate();
            } catch {}
        }
        //================================================================================
        public void setCurrentQuery(string recordPath) {
            Invoke(new Action(() => {
                //onQueryStart(recordPath);
                //updateUiResults();
                txtQuery.Text = recordPath;
                startQuery();                
                onNewSelectedItem(recordPath, recordPath);
            }));            
        }
        //================================================================================
        /// on each form show. 
        public void reloadCurrentNode() {
            LstResSelectedIndexChanged(null, null);			
        }
        //================================================================================
        private void TxtQueryKeyDown(object sender, KeyEventArgs e) {
            if (e.KeyData == Keys.Enter) {
                if (mnuQueryRegExp.Checked) {
                    if (!txtQuery.Text.Contains("\\\\")) {
                        if (MessageBox.Show("Common RegExp query can be slow.\r\n" +
                                "\r\nDo you really want it?",
                                "Start query?", MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question) != DialogResult.Yes) {
                            return;
                        }
                    }
                }
                startQuery();
            }
        }
        //================================================================================
        private void startQuery() {
            string s = txtQuery.Text;
            if (!mnuQueryRegExp.Checked) {
                s = s.Trim();	
                s = s.Replace("/", "\\");
                s = s.ToLower(CultureInfo.InvariantCulture);
            }
            if (s == "")
                return;
			
            txtStatusLabel.Text = "in process, please wait...";
            onQueryStart(s);
			
            stopThread(thSearch);
            thSearch = new Thread(searchThread);
            thSearch.Start();
        }
        //================================================================================
        private void onQueryStart(string query) {
            txtValue.Text = "";
            foundItems = 0;
            lstResults.Items.Clear();
            aResults.Clear();
            mnuFile.Enabled = false;
            mnuQueryExportAll.Enabled = false;
            isLastQueryRegExp = mnuQueryRegExp.Checked;
            lastQuery = query;            
        }
        //================================================================================
        private void stopThread(Thread th) {
            try {
                if (th != null && th.IsAlive) {
                    th.Abort();
                }                
            } catch (Exception ex) {
                Debug.WriteLine(ex);
            }
        }
        //================================================================================
        private void searchThread() {
            CajApp.searchInGgpk(lastQuery, isLastQueryRegExp, onQueryFoundItem);
            
            aResults.Sort();
            
            Invoke(new Action(() => {
                updateUiResults();
            }));
        }
        //================================================================================
        private void updateUiResults() {            
            lstResults.VirtualListSize = 0; //it works.
            lstResults.BeginUpdate();
            lstResults.VirtualListSize = aResults.Count;
            lstResults.EndUpdate();
            txtStatusLabel.Text = "Found: " + foundItems.ToString();
            if (foundItems > 0) {
                mnuQueryExportAll.Enabled = true;
            }
        }
        //================================================================================
        private void onQueryFoundItem(string key) {
            if (key.Length > keyPrefixLen) {
                key = key.Substring(keyPrefixLen);
            }   
            aResults.Add(key);                
            foundItems++;
        }
        //================================================================================
        private void lstResults_RetrieveVirtualItem(object sender, RetrieveVirtualItemEventArgs e) {
            if (e == null) {
                Debug.WriteLine("RetrieveVirtualItemEventArgs is null");
                e.Item = new ListViewItem("?");
                return;
            }

            if (e.ItemIndex < 0 || e.ItemIndex >= aResults.Count) {
                Debug.WriteLine("incorrect ItemIndex = " + e.ItemIndex);
                e.Item = new ListViewItem("?");
                return;
            }

            try {
                var res = aResults[e.ItemIndex];
                e.Item = new ListViewItem(res);
            } catch (Exception ex) {
                Debug.WriteLine(ex);
                e.Item = new ListViewItem("?");
                CajApp.addLog("search: " + ex.Message);                
            }
        }        
        //================================================================================
        private void LstResSelectedIndexChanged(object sender, EventArgs e) {
            int index = getSafeSelectedListIndex();
                        
            if (index < 0) {
                txtValue.Text = "";
                mnuFile.Enabled = false;
                txtStatusLabel.Text = "Found: " + foundItems.ToString();
            } else {
                string selName = aResults[index];
                string key = keyPrefix + selName;
                onNewSelectedItem(selName, key);
            }
        }
        //================================================================================
        private void onNewSelectedItem(string selName, string key) {
            txtValue.Text = "";
            picValue.Visible = false;
            mnuSavePicture.Enabled = false;
            
            if (CajApp.getNode("root\\" + selName) != null ||
                CajApp.getNode(selName) != null) 
            {
                if (isExtensionInList(selName, aPictureExtensions)) {
                    showPicture(CajApp.getByteValueOfNode(key));
                } else if (selName.EndsWith(".dds", StringComparison.InvariantCultureIgnoreCase)) {
                    showDds(CajApp.getByteValueOfNode(key));
                } else if (isExtensionInList(selName, aIgnoredExtensions)) {
                    setTxtValueText("[binary type]");
                } else {
                    bool isText = isExtensionInList(selName, aTextFileExtensions);
                    var dataLength = CajApp.getNodesDataLength(key);
                    
                    if (dataLength > MAX_TEXT_LENGTH_TO_READ ||
                        (!isText && dataLength > MAX_TEXT_LENGTH_TO_SHOW)) {
                        onTooBigFile();
                    } else {
                        //most interesting files are text files, so show them as text:
                        setTxtValueText(CajApp.getValueOfNode(key));
                    }
                }               
            }
            
            txtValue.SelectionStart = 0;
            txtValue.ScrollToCaret();
            mnuFile.Enabled = true;
            txtStatusLabel.Text = "Found: " + foundItems.ToString() +
                                  ". Selected: " + selName;
            Debug.WriteLine(selName);            
        }
        //================================================================================        
        private void showDds(byte[] aDds) {
            if (aDds == null || aDds.Length < 8) return;
            
            //is link?:
            if (CajDDS.isDdsGgpkLink(aDds)) {
                var link = Encoding.UTF8.GetString(aDds, 1, aDds.Length - 1);
                link = link.ToLower(CultureInfo.InvariantCulture);
                link = link.Replace('/', '\\');
                link = "root\\" + link;
                var node = CajApp.getNode(link);
                if (node != null) {
                    showDds(CajApp.getByteValueOfNode(link));
                } else {
                    setTxtValueText("incorrect dds link");
                }
                return;
            }
            
            //info:
            var sb = new StringBuilder();
            sb.Append("converting dds.");
            int len = aDds.Length;
            if (len > 100 * 1024) {
                sb.Append(" size: ");
                sb.Append(len);
                sb.Append(" bytes. Wait please...");
            } else {
                sb.Append("..");
            }
            setTxtValueText(sb.ToString());
            
            //cut, decode, convert, can be slow:
            stopThread(thDdsConvert);
            thDdsConvert = new Thread(() => {
                CajDDS.getBitmap(aDds, onDdsConvertFinish);
            });
            thDdsConvert.Start();            
        }
        //================================================================================
        private void onDdsConvertFinish(CajImage img) {
            if (!this.Visible) return;
            
            Invoke(new Action(() => {                                  
                if (img == null) {
                    setTxtValueText("can't show dds");
                    return;
                }
                setPicture(img.getBitmap());
            }));
        }
        //================================================================================
        private void showPicture(byte[] aPixels) {
            if (aPixels == null) return;
            
            try {
                MemoryStream ms = new MemoryStream();
                byte[] aData = aPixels;
                ms.Write(aData, 0, aData.Length);
                Bitmap bm = new Bitmap(ms, false);
                ms.Dispose();
                setPicture(bm);
            } catch {
                setTxtValueText("can't create bitmap: ");
            }
        }
        //================================================================================
        private void setPicture(Bitmap bm) {
            if (bm == null) return;
            
            try {
                setTxtValueText("");
                if (bm.Width > txtValue.Width - 10 || bm.Height > txtValue.Height - 10) {
                    picValue.SizeMode = PictureBoxSizeMode.Zoom;
                    picValue.Width = txtValue.Width - 5;
                    picValue.Height = txtValue.Height - 5;
                } else {
                    picValue.SizeMode = PictureBoxSizeMode.AutoSize;
                }
                picValue.Image = bm;
                lastSelectedBitmap = bm;
                picValue.Visible = true;
                mnuSavePicture.Enabled = true;                
            } catch {
                setTxtValueText("[unsupported image]");
            }
        }
        //================================================================================
        private bool isExtensionInList(string recordsName, IEnumerable<string> list) {
            foreach (var ext in list) {
                if (recordsName.EndsWith(ext, StringComparison.InvariantCulture)) {
                    return true;
                }
            }
            return false;
        }
        //================================================================================
        private void onTooBigFile() {
            txtValue.Text = "(file is too big. Export it using File menu " +
                            "and view in external application)";
        }
        //================================================================================
        private void FrmSearchInGgpkFormClosing(object sender, FormClosingEventArgs e) {
            hideSafe();
            e.Cancel = true;
        }
        //================================================================================
        private int getSafeSelectedListIndex() {
            var aSelected = lstResults.SelectedIndices;
            if (aSelected == null || aSelected.Count == 0) return -1;
            int index = aSelected[0];
            if (index >= aResults.Count) return -1;
            return index;            
        }
        //================================================================================
        private string getKeyFileName() {
            int index = getSafeSelectedListIndex();
            if (index > -1) {
                string sRes = aResults[index];
                int iPos = sRes.LastIndexOf("\\", StringComparison.InvariantCulture);
                if (iPos != -1) {
                    sRes = sRes.Substring(iPos + 1);
                    return sRes;
                }
            }
			
            return "";
        }
        //================================================================================
        private void setTxtValueText(string s) {
            if (s.Length > 1) {
                string sBom = s.Substring(0, 1);
                byte[] aBom = Encoding.Unicode.GetBytes(sBom);
                if (aBom.Length > 1) {
                    if (aBom[0] == 0xFF || aBom[0] == 0xFE) {
                        s = s.Substring(1);
                    }
                }
            }
			
            txtValue.Text = s;
        }
        //================================================================================
        private void MnuFileExportClick(object sender, EventArgs e) {
            int index = getSafeSelectedListIndex();
            if (index == -1) return;
			
            try {
                exportDlg.FileName = getKeyFileName();
                if (exportDlg.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
                    string key = keyPrefix + aResults[index];
                    CajApp.exportNode(key, exportDlg.FileName);
                }				
            } catch (Exception ex) {
                MessageBox.Show("Can't export: " + ex.Message);
            }
        }
        //================================================================================
        private void MnuFileImportClick(object sender, EventArgs e) {
            int index = getSafeSelectedListIndex();
            if (index == -1) return;
			
            try {
                importDlg.FileName = getKeyFileName();
                if (importDlg.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
                    string key = keyPrefix + aResults[index];
                    CajApp.importNode(key, importDlg.FileName);
                    setTxtValueText(CajApp.getValueOfNode(key));					
                    //there's no option to edit node in the richTextBox.
                    //(too much binary files. export/import is much better).
                }	
            } catch (Exception ex) {
                MessageBox.Show("Can't import: " + ex.Message);
            }
        }
        //================================================================================
        private void ExportAllFoundFilesToolStripMenuItemClick(object sender, EventArgs e) {
            if (foundItems == 0) return;
            if (lastQuery == "") return;
			
            if (foundItems > 1000) {
                string text = "Do you really want to export " + 
                    foundItems.ToString() + " files?\r\nIt can be slow.";
                const string caption = "Export All";
                if (MessageBox.Show(text, caption, MessageBoxButtons.YesNo) != DialogResult.Yes) {
                    return;
                }
            }
			
            exportDlg.FileName = "backup";
            if (exportDlg.ShowDialog() == DialogResult.OK) {
                CajApp.exportAll(lastQuery, mnuQueryRegExp.Checked, exportDlg.FileName);
                txtStatusLabel.Text = "Saved: " + foundItems.ToString();
            }
        }
        //================================================================================
        private void MnuFileCloseClick(object sender, EventArgs e) {
            hideSafe();
        }
        //================================================================================
        private void hideSafe() {
            stopThread(thSearch);
            stopThread(thDdsConvert);
            CajApp.stopExportAllThread();
            this.Hide();
        }
        //================================================================================
        private void MnuSavePictureClick(object sender, EventArgs e) {
            if (lastSelectedBitmap == null) return;
            
            exportDlg.FileName = "image.png";
            if (exportDlg.ShowDialog() == DialogResult.OK) {               
                try {
                    var pf = exportDlg.FileName;
                    if (!pf.EndsWith(".png", StringComparison.InvariantCultureIgnoreCase)) {
                        pf += ".png";
                    }
                    lastSelectedBitmap.Save(pf, ImageFormat.Png);
                    txtStatusLabel.Text = "Saved image: " + pf;
                } catch (Exception ex) {
                    txtStatusLabel.Text = "Can't save image: " + ex.Message;    
                }                
            }          
        }
        //================================================================================
    }
}
