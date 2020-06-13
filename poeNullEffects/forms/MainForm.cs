/*
 * User: ajaxvs
 * Date: 30.12.2017
 * Time: 17:02
 */
 
//#define APP_SHOW_DEBUG_MAIN_FRAME
 
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using poeNullEffects.app;
using poeNullEffects.app.data;
using poeNullEffects.app.logic;
using poeNullEffects.app.view;

namespace poeNullEffects {
    public partial class MainForm : Form {
        //================================================================================
        private Boolean isWorking = true;
        private string[] aWaitMessages;
        
        private CajVirtualListView<string[], string> vlstCheckList;
        private List<string> aParticleFilePaths = null;
        private ListViewItem defaultCheckListItem;
        
        private bool isFirstFilterRuleSearch = true;
        //================================================================================
        public MainForm() {
            InitializeComponent();
			
            aWaitMessages = new string[] {	
                "..", "...", "....", "....."
            };
			
            //app start:
            CajApp.start(this);
			
            //ggpk path:
            String s = CajApp.config.read(CajConfig.keyGGPKPath);
            if (s != "") {
                txtGgpkPath.Text = s;
            }
			
            //make good options:
            makeGoodTrack.Maximum = 6;
            makeGoodTrack.Value = CajApp.config.readInt(CajConfig.keyMakeGoodValue, 2);
			
            //wait label.
            lblWait.Visible = false;
            generateNewWaitMessage();
            
            //lstCheckList:
            setCheckListButtonsEnabled(false);
            defaultCheckListItem = new ListViewItem(new string[] {"?", "?"});
            //2 columns, 1 string key:
            vlstCheckList = new CajVirtualListView<string[], string>(lstCheckList, 
                                     "?", getItemView, CajApp.addLog);
            lstCheckList.MultiSelect = true;
            txtCheckListFilter.Text = "filter";
            
            //TODO: "don't open feature": menu
            mnuDontOpen.Enabled = false;
        }        
        //================================================================================
        private void generateNewWaitMessage() {
            lblWait.Text = "" +
            aWaitMessages[CajApp.random.Next(0, aWaitMessages.Length)] +
                "\r\n" + "Please wait.";
            Point p = new Point((this.Size.Width - lblWait.Size.Width) / 2,
                                100);
            lblWait.Location = p;
        }
        //================================================================================
        private void MainFormLoad(object sender, EventArgs e) {
#if (APP_SHOW_DEBUG_MAIN_FRAME)
            tabActions.Visible = true;				
#endif
        }
        //================================================================================
        private delegate void addLogCallback(string s);
        //================================================================================
        public void addLog(String s) {
            if (!isWorking)
                return;
			
            try {
                if (this.txtLog.InvokeRequired) {
                    addLogCallback d = new addLogCallback(addLog);
                    this.Invoke(d, new object[] { s });
                } else {
                    this.txtLog.AppendText(s);
                    this.txtLog.SelectionStart = this.txtLog.Text.Length;
                    this.txtLog.ScrollToCaret();
                }
            } catch (Exception ex) {
                Debug.WriteLine(ex);
            }
        }
        //================================================================================
        private void ButLocateGgpkClick(object sender, EventArgs e) {
            if (openGgpkDlg.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
                this.txtGgpkPath.Text = openGgpkDlg.FileName;
            }
        }
        //================================================================================
        private void TxtGgpkPathTextChanged(object sender, EventArgs e) {
            String path = this.txtGgpkPath.Text;
            if (path != "" && System.IO.File.Exists(path)) {
                butOpenGgpk.Enabled = true;				
            } else {
                butOpenGgpk.Enabled = false;				
            }
        }
        //================================================================================
        public string getGgpkPathText() {
            return txtGgpkPath.Text;
        }
        //================================================================================
        public void focusGgpkPathInputField() {
            txtGgpkPath.Focus();
        }        
        //================================================================================
        public void enableActions(Boolean mode) {
            if (!isWorking)
                return;
			
            Invoke((MethodInvoker)delegate {
                tabActions.Visible = mode;  
                if (mode) tabActions.BringToFront();

                lblWait.Visible = !mode;
                if (!mode) generateNewWaitMessage();   

                butLocateGgpk.Enabled = mode;
            });			
        }
        //================================================================================
        private void ButOpenGgpkClick(object sender, EventArgs e) {
            openGgpk(true);
        }
        //================================================================================
        private void MnuDontOpenClick(object sender, EventArgs e) {
            var fp = CajGgpkSerializer.getSavePath();
            if (File.Exists(fp)) {
                openGgpk(false);
            } else {
                MessageBox.Show("Try to use this feature later." + 
                   "\r\nFirst, open .ggpk as always. Next time this menu should start the real job.",
                   "poeNullEffects :: open first",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }
        //================================================================================
        private void openGgpk(bool isFromDisk) {
            mnuDontOpen.Enabled = false;
            
            butOpenGgpk.Enabled = false;
            txtLog.Focus();
            enableActions(false);
            CajApp.openGgpk(isFromDisk, onOpenedGgpk);
            
            CajApp.config.write(CajConfig.keyGGPKPath, txtGgpkPath.Text);
        }
        //================================================================================
        private void onOpenedGgpk(Boolean mode) {
            if (!isWorking) return;
            
            enableActions(mode);
                        
            if (!mode) {
                Invoke((MethodInvoker)delegate {
                    butOpenGgpk.Enabled = true;
                });
            }
        }        
        //================================================================================
        private void ButSavePetsClick(object sender, EventArgs e) {
            if (saveBackupDlg.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
                string savePath = saveBackupDlg.FileName;
                CajApp.saveParticlesBackupButtonAction(savePath);
            }
        }
        //================================================================================
        private void butLoadBackupClick(object sender, EventArgs e) {
            if (loadBackupDlg.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
                string loadPath = loadBackupDlg.FileName;
                CajApp.loadBackupButtonAction(loadPath);
            }
        }
        //================================================================================
        private void ButLoadDirClick(object sender, EventArgs e) {
            const string title = "Load Directory";
            const string text = "Input path to load all directory and subdirectory files into the GGPK:";
			
            frmInputBox ib = new frmInputBox();
            ib.setParams(title, text, onLoadDirConfirm);
            ib.ShowDialog(this);
        }
        //================================================================================
        private void onLoadDirConfirm(string s) {
            if (s != "") {
                CajApp.loadDirButtonAction(s);
            }
        }
        //================================================================================
        private void butNullParticlesClick(object sender, EventArgs e) {
            CajApp.showNullEffectsForm();
        }
        //================================================================================
        private void butDisableShadowsClick(object sender, EventArgs e) {
            CajApp.shadowsButtonActions(false);
        }
        //================================================================================
        private void ButEnableShadowsClick(object sender, EventArgs e) {
            CajApp.shadowsButtonActions(true);
        }
        //================================================================================
        private void MainFormFormClosing(object sender, FormClosingEventArgs e) {
            if (!confirmExit()) {
                e.Cancel = true;
            }
        }
        //================================================================================
        private void MainFormFormClosed(object sender, FormClosedEventArgs e) {
            closeForm();
        }
        //================================================================================
        private void closeForm() {
            isWorking = false;
            CajApp.onExit();
            //anyway don't abort alive writing threads to prevent .ggpk corrupting.
			//don't use tasks, check DevNotes.
            //use volatile flag to stop thread loops, it's safe.
        }
        //================================================================================
        private void ExitToolStripMenuItemClick(object sender, EventArgs e) {
            Close(); //trigger Closing -> Close events
        }
        //================================================================================
        private void ButSayThanksClick(object sender, EventArgs e) {
            frmSayThanks frm = new frmSayThanks();
            frm.ShowDialog(this);
        }
        //================================================================================
        private void ButSaveMiscClick(object sender, EventArgs e) {
            if (saveBackupDlg.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
                string savePath = saveBackupDlg.FileName;
                CajApp.saveMisc(savePath);
            }
        }
        //================================================================================
        private void ButNoDeadBodiesClick(object sender, EventArgs e) {
            CajApp.enableCorpses(false);
        }
        private void ButCorpsesEnableClick(object sender, EventArgs e) {
            CajApp.enableCorpses(true);
        }
        //================================================================================
        private void ButSearchInGgpkClick(object sender, EventArgs e) {
            CajApp.showSearchInGgpkForm();
        }
        //================================================================================
        /*
        private void ButNullEpkClick(object sender, EventArgs e) {
            CajApp.nullEpkParticles();
        }
        //================================================================================
        private void ButRemoveAocParticlesClick(object sender, EventArgs e) {
            CajApp.removeAocParticles();
        }
        */
        //================================================================================
        private void ButMakeGoodClick(object sender, EventArgs e) {
            CajApp.makeGood(makeGoodTrack.Value);
        }
        //================================================================================
        private void MakeGoodTrackValueChanged(object sender, EventArgs e) {
            CajApp.onMakeGoodValueChange(makeGoodTrack.Value);
        }
        //================================================================================
        private void TxtLogKeyDown(object sender, KeyEventArgs e) {
            if (e.Control && e.KeyCode == Keys.A) {
                txtLog.SelectAll();
            }          
        }
        //================================================================================
        private bool confirmExit() {
            if (!CajApp.isAllThreadsFinishedJobs()) {
                const string text = "Seems like you're going to corrupt your .ggpk." +
                                    "\r\nDo you really want to stop the job and close the app?";
                const string caption = "poeNullEffects :: closing";                
                if (MessageBox.Show(text, caption, 
                                     MessageBoxButtons.YesNoCancel,
                                     MessageBoxIcon.Stop,
                                     MessageBoxDefaultButton.Button3
                                    ) != DialogResult.Yes) {
                    return false;
                }
            } 
            return true;
        }
        //================================================================================
        private ListViewItem getItemView(string item) {
            if (aParticleFilePaths == null) {
                Debug.WriteLine("getItemView.aTabCheckResults == null");
                return defaultCheckListItem;
            }
            var res = new string[2];
            string sEmitters;
            var node = CajApp.getNode(item);
            if (node != null) {
                //getting cache value, it's fast:
                int iEmitters = CajApp.recordsChanger.getEmittersNumber(node);
                sEmitters = iEmitters.ToString();
            } else {
                Debug.WriteLine("getItemView.node == null: " + 
                                item + ", " + aParticleFilePaths.Count);
                sEmitters = "?";
            }
            res[0] = sEmitters;
            res[1] = item;
            return new ListViewItem(res);
        } 
        //================================================================================        
        private void TabActionsSelectedIndexChanged(object sender, EventArgs e) {
            if (tabActions.SelectedTab != tabCheckList) return;
            updateCheckList();
        }
        //================================================================================
        private void ButCheckListUpdateClick(object sender, EventArgs e) {
            updateCheckList();
        }
        //================================================================================
        private void updateCheckList() {
            aParticleFilePaths = CajApp.getParticleFilePaths();
            if (aParticleFilePaths == null) {                
                return;
            }
            
            string filter = txtCheckListFilter.Text;
            Thread thFilter = null;
            if (filter != "" && filter != "filter") {
                filter = filter.ToLower(CultureInfo.InvariantCulture);
                //check if format rule set:
                bool isSeparatorMore = false;
                bool isSeparatorEquals = false;
                bool isSeparatorLess = false;
                var separator = filter.IndexOf("e>", StringComparison.InvariantCulture);
                if (separator != -1) {
                    isSeparatorMore = true;
                } else {
                    separator = filter.IndexOf("e=", StringComparison.InvariantCulture);
                    if (separator != -1) {
                        isSeparatorEquals = true;
                    } else {
                        separator = filter.IndexOf("e<", StringComparison.InvariantCulture);
                        if (separator != -1) {
                            isSeparatorLess = true;
                        }
                    }
                }
                //check filter:
                if (separator == -1) {                    
                    //filter by path text: fast, nn thread:
                    var aFiltered = new List<string>();
                    foreach (var r in aParticleFilePaths) {
                        if (r.Contains(filter)) {
                            aFiltered.Add(r);
                        }
                    }
                    aParticleFilePaths = aFiltered;
                } else {
                    //filter by emitters+:
                    enableActions(false);                    
                    thFilter = new Thread(() => {
                        int filterEmitters = -1;
                        int.TryParse(filter.Substring(separator + 2), out filterEmitters);
                        if (filterEmitters >= 0) {                        
                            var aFiltered = new List<string>();
                            foreach (var r in aParticleFilePaths) {
                                var node = CajApp.getNode(r);
                                if (node != null) {
                                    int iEmitters = CajApp.recordsChanger.getEmittersNumber(node);                            
                                    if ((isSeparatorMore && iEmitters > filterEmitters) || 
                                        (isSeparatorEquals && iEmitters == filterEmitters) ||
                                        (isSeparatorLess && iEmitters < filterEmitters)
                                       ){
                                        aFiltered.Add(r);
                                    }
                                }
                            }
                            aParticleFilePaths = aFiltered;
                        }
                        Invoke(new Action(() => {
                            onFilterQueryEnd();
                        }));
                        enableActions(true);                                                           
                    });
                }                
            }
            
            if (thFilter != null) {
                thFilter.Start();
                if (isFirstFilterRuleSearch) {
                    isFirstFilterRuleSearch = false;
                    MessageBox.Show("This is the first filter rule search." +
                        Environment.NewLine + "It can take up to 10 seconds, please wait." +
                        Environment.NewLine + Environment.NewLine + 
                        "Next queries should be instant until you close the app.",
                        "poeNullEffects :: format query");
                }                
            } else {
                onFilterQueryEnd();    
            }                        
        }
        //================================================================================
        private void onFilterQueryEnd() {
            if (aParticleFilePaths == null) {
                Debug.WriteLine("onFilterQueryEnd.updateCheckList == null");
            } else {
                CajApp.addLog("records found: " + aParticleFilePaths.Count);
                vlstCheckList.onQueryStart();
                vlstCheckList.onQueryEnd(aParticleFilePaths);
            }            
        }
        //================================================================================
        private void LstCheckListSelectedIndexChanged(object sender, EventArgs e) {                        
            var aSelected = lstCheckList.SelectedIndices;
            bool isSelected = (aSelected != null && aSelected.Count > 0);
            setCheckListButtonsEnabled(isSelected);
        }
        //================================================================================
        private void setCheckListButtonsEnabled(bool isEnabled) {
            butCheckListDisable.Enabled = isEnabled;
            butCheckListEnable.Enabled = isEnabled;
        }
        //================================================================================
        private void LstCheckListColumnClick(object sender, ColumnClickEventArgs e) {
            //nn sorter. use filter rules.
        }
        //================================================================================
        private void TxtCheckListFilterEnter(object sender, EventArgs e) {
            if (txtCheckListFilter.Text == "filter") {
                txtCheckListFilter.Text = "";
            }
        }
        //================================================================================
        private void TxtCheckListFilterKeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                updateCheckList();
            }
        }
        //================================================================================
        private void ButCheckListSelectAllClick(object sender, EventArgs e) {
            selectAllCheckListRecords();
        }
        //================================================================================
        private void LstCheckListKeyDown(object sender, KeyEventArgs e) {
           if (e.Control && e.KeyCode == Keys.A) {
                selectAllCheckListRecords();
            }   
        }
        //================================================================================
        private void selectAllCheckListRecords() {
            try {
                /*
                //22k records == 11 seconds with default .Net methods:
                lstCheckList.BeginUpdate();
                for (int i = 0; i < lstCheckList.Items.Count; i++) {
                    lstCheckList.Items[i].Selected = true;
                    //lstCheckList.SelectedIndices.Add(i);
                }                
                lstCheckList.Focus();
                lstCheckList.EndUpdate();
                */
                //instant:
                vlstCheckList.selectAllItems();
            } catch (Exception ex) {
                Debug.WriteLine(ex);
            }
        }
        //================================================================================
        private void ButCheckListEnableClick(object sender, EventArgs e) {
            checkListEnableButton(true);            
        }
        //================================================================================
        private void ButCheckListDisableClick(object sender, EventArgs e) {
            checkListEnableButton(false);
        }
        //================================================================================
        private void checkListEnableButton(bool isEnable) {
            var a = vlstCheckList.getSelectedItems();
            CajApp.enableCheckListSelectedParticles(a, isEnable);            
        }
        //================================================================================
        public void onCheckListEnableActionFinish() {
            Invoke(new Action(() => {
                updateCheckList();
            }));
        }
        //================================================================================
        private void LstCheckListDoubleClick(object sender, EventArgs e) {
            string name;
            if (!vlstCheckList.getFirstSelectedItem(out name)) return;
            
            CajApp.showSearchInGgpkForm(name);
        }
        private void MnuStopCurrentTaskClick(object sender, EventArgs e) {
            CajApp.stopCurrentTask();
        }
        //================================================================================
        private void ButCheckListFindSkillClick(object sender, EventArgs e) {
            var frmFindSkill = new frmFindSkill();
            frmFindSkill.setOnSelectEventHandler(onFindSkillSelect);
            frmFindSkill.showMainSkills();
            frmFindSkill.ShowDialog(this);
        }
        //================================================================================
        private void onFindSkillSelect(string s) {
            if (String.IsNullOrEmpty(s)) return;

            txtCheckListFilter.Text = s;
            updateCheckList();
        }
        //================================================================================
    }
}
