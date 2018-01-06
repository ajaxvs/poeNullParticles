/*
 * User: ajaxvs
 * Date: 30.12.2017
 * Time: 17:02
 */
using System;
using System.Windows.Forms;
using poeNullEffects.app;

namespace poeNullEffects {
	public partial class MainForm : Form {
		//================================================================================
		private Boolean isWorking = true;
		//================================================================================
		public MainForm() {
			InitializeComponent();
			
			CajApp.start(this);
		}
		//================================================================================
		void MainFormLoad(object sender, EventArgs e) {
			//debug:
			//tabActions.Visible = true;
		}
		//================================================================================
		delegate void addLogCallback(string s);
		//================================================================================
		public void addLog(String s) {
			if (!isWorking) return;
			
			if (this.txtLog.InvokeRequired) {
				addLogCallback d = new addLogCallback(addLog);
				this.Invoke(d, new object[] { s });
			} else {
				this.txtLog.AppendText(s);
				this.txtLog.SelectionStart = this.txtLog.Text.Length;
				this.txtLog.ScrollToCaret();
			}
		}
		//================================================================================
		void ButLocateGgpkClick(object sender, EventArgs e) {
			if (openGgpkDlg.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
				this.txtGgpkPath.Text = openGgpkDlg.FileName;
			}
		}
		//================================================================================
		void TxtGgpkPathTextChanged(object sender, EventArgs e) {
			String path = this.txtGgpkPath.Text;
			if (path != "" && System.IO.File.Exists(path)) {
				butOpenGgpk.Enabled = true;				
			} else {
				butOpenGgpk.Enabled = false;				
			}
		}
		//================================================================================
		private void onOpenedGgpk(Boolean mode) {
			if (!isWorking) return;
			
			enableActions(mode);
						
			if (!mode) {
				this.butOpenGgpk.Invoke((MethodInvoker)delegate {
	    			this.butOpenGgpk.Enabled = true;
				});
			}
		}
		//================================================================================
		public void enableActions(Boolean mode) {
			if (!isWorking) return;
			
			this.tabActions.Invoke((MethodInvoker)delegate {
				this.tabActions.Visible = mode;                  
			});
		}
		//================================================================================
		void ButOpenGgpkClick(object sender, EventArgs e) {
			butOpenGgpk.Enabled = false;
			txtLog.Focus();
			enableActions(false);
			CajApp.openGgpk(onOpenedGgpk);
		}
		//================================================================================
		void ButSavePetsClick(object sender, EventArgs e) {
			if (saveBackupDlg.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
				string savePath = saveBackupDlg.FileName;
				CajApp.saveBackup(savePath);
			}
		}
		//================================================================================
		void butLoadBackupClick(object sender, EventArgs e) {
			if (loadBackupDlg.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
				string loadPath = loadBackupDlg.FileName;
				CajApp.loadBackup(loadPath);
			}
		}
		//================================================================================
		void ButLoadDirClick(object sender, EventArgs e) {
			string title = "Load Directory";
			string text = "Input path to load all directory and subdirectory files into the GGPK:";			
			
			frmInputBox ib = new frmInputBox();
			ib.setParams(title, text, onLoadDirConfirm);
			ib.ShowDialog(this);
		}
		//================================================================================
		void onLoadDirConfirm(string s) {
			if (s != "") {
				CajApp.loadDir(s);
			}
		}
		//================================================================================
		void butNullParticlesClick(object sender, EventArgs e) {
			CajApp.showNullEffectsForm();
		}
		//================================================================================
		void butDisableShadowsClick(object sender, EventArgs e) {
			CajApp.disableShadows();
		}
		//================================================================================
		void MainFormFormClosed(object sender, FormClosedEventArgs e) {
			isWorking = false;
			CajApp.release();
		}
		//================================================================================
		void ButSayThanksClick(object sender, EventArgs e) {
			frmSayThanks frm = new frmSayThanks();
			frm.ShowDialog(this);
		}
		//================================================================================
		void ButSaveMiscClick(object sender, EventArgs e) {
			if (saveBackupDlg.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
				string savePath = saveBackupDlg.FileName;
				CajApp.saveMisc(savePath);
			}
		}
		//================================================================================
		void ButNoDeadBodiesClick(object sender, EventArgs e) {
			CajApp.noDeadBodies();
		}
		//================================================================================
		void ButSearchInGgpkClick(object sender, EventArgs e) {
			CajApp.showSearchInGgpkForm();
		}
		//================================================================================
		void ButNullEpkClick(object sender, EventArgs e) {
			CajApp.nullEpkParticles();
		}
		//================================================================================
		void ButRemoveAocParticlesClick(object sender, EventArgs e) {
			CajApp.removeAocParticles();
		}
		//================================================================================
		void ButRemoveSpellMeshesClick(object sender, EventArgs e) {
			CajApp.removeSpellMeshes();
		}
		//================================================================================
	}
}
