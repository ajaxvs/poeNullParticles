/*
 * User: ajaxvs
 * Date: 02.01.2018
 * Time: 18:06
 */
using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using poeNullEffects.app;

namespace poeNullEffects
{
	public partial class frmSearchInGgpk : Form {
		//================================================================================
		private const int maxResItems = 10000;
		private const string keyPrefix = "root\\";
		private int keyPrefixLen = 0;
		//================================================================================
		private int foundItems = 0;
		private string lastQuery = "";
		//================================================================================
		public frmSearchInGgpk() {
			InitializeComponent();
		}
		//================================================================================
		void FrmSearchInGgpkLoad(object sender, EventArgs e) {			
			keyPrefixLen = keyPrefix.Length;
			
			txtQuery.Text = "\\renderer\\";
			startQuery();
		}
		//================================================================================
		/**
		 * calling on each form show. 
		 */
		public void reloadCurrentNode() {
			LstResSelectedIndexChanged(null, null);			
		}
		//================================================================================
		void TxtQueryKeyDown(object sender, KeyEventArgs e) {
			if (e.KeyData == Keys.Enter) {
				if (mnuQueryRegExp.Checked) {
					if (!txtQuery.Text.Contains("\\\\")) {
						if (MessageBox.Show("Common RegExp query can be slow.\n" +
						                    "\nDo you really want it?",
						                    "Start query?", MessageBoxButtons.YesNo,
						                    MessageBoxIcon.Question) != DialogResult.Yes)
						{
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
				s = s.ToLower();			
			}
			if (s == "") return;
			
			txtValue.Text = "";
			foundItems = 0;
			txtStatusLabel.Text = "in process, please wait...";
			lstRes.Items.Clear();
			mnuFile.Enabled = false;
			mnuQueryExportAll.Enabled = false;
			lastQuery = s;
			
			lstRes.BeginUpdate();
			CajApp.searchInGgpk(s, mnuQueryRegExp.Checked, onQueryFoundItem);
			lstRes.EndUpdate();
			
			txtStatusLabel.Text = "Found: " + foundItems.ToString();
			if (foundItems > 0) {
				mnuQueryExportAll.Enabled = true;
			}
		}
		//================================================================================
		private void onQueryFoundItem(string key) {
			if (lstRes.Items.Count < maxResItems) {
				lstRes.Items.Add(key.Substring(keyPrefixLen));	
			}
			foundItems++;
		}
		//================================================================================
		void LstResSelectedIndexChanged(object sender, EventArgs e) {
			if (lstRes.SelectedIndex == -1) {
				txtValue.Text = "";
				mnuFile.Enabled = false;
			} else {
				string key = keyPrefix + lstRes.SelectedItem.ToString();
				setTxtValueText(CajApp.getValueOfNode(key));
				txtValue.SelectionStart = 0;
				txtValue.ScrollToCaret();
				mnuFile.Enabled = true;
			}
		}
		//================================================================================
		void FrmSearchInGgpkFormClosing(object sender, FormClosingEventArgs e) {
			this.Hide();
			e.Cancel = true;
		}
		//================================================================================
		private string getKeyFileName() {
			if (lstRes.SelectedIndex != -1) {
				string sRes = lstRes.SelectedItem.ToString();
				int iPos = sRes.LastIndexOf("\\");
				if (iPos != -1) {
					sRes = sRes.Substring(iPos + 1);
					return sRes;
				}
			}
			
			return "";
		}
		//================================================================================
		private void setTxtValueText(string s) {
			//s = unicode, two bytes per symbol.
			char[] aSymbols = s.ToCharArray();
			if (aSymbols.Length > 1) {
				int i0 = aSymbols[0];
				if (i0 == 0xFEFF || i0 == 0xFFFE) { //don't ask.
					s = s.Substring(1);
				}
			}
			
			txtValue.Text = s;
		}
		//================================================================================
		void MnuFileExportClick(object sender, EventArgs e) {
			if (lstRes.SelectedIndex == -1) return;
			
			try {
				exportDlg.FileName = getKeyFileName();
				if (exportDlg.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
					string key = keyPrefix + lstRes.SelectedItem.ToString();
					CajApp.exportNode(key, exportDlg.FileName);
				}				
			} catch (Exception ex) {
				MessageBox.Show("Can't export: " + ex.Message);
			}
		}
		//================================================================================
		void MnuFileImportClick(object sender, EventArgs e) {
			if (lstRes.SelectedIndex == -1) return;
			
			try {
				importDlg.FileName = getKeyFileName();
				if (importDlg.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
					string key = keyPrefix + lstRes.SelectedItem.ToString();
					CajApp.importNode(key, importDlg.FileName);
					setTxtValueText(CajApp.getValueOfNode(key));					
					//there's no option to edit node in the richTextBox.
					//(there're a lot of binary files so export/import is much better).
				}	
			} catch (Exception ex) {
				MessageBox.Show("Can't import: " + ex.Message);
			}
		}
		//================================================================================
		void ExportAllFoundFilesToolStripMenuItemClick(object sender, EventArgs e) {
			if (foundItems == 0) return;
			if (lastQuery == "") return;
			
			if (foundItems > 1000) {
				string text = "Do you really want to export " + foundItems.ToString() + " files?\nIt can be slow.";
				string caption = "Export All";
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
		void MnuFileCloseClick(object sender, EventArgs e) {
			this.Hide();
		}
		//================================================================================
	}
}
