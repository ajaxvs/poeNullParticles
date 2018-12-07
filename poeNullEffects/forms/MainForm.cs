/*
 * User: ajaxvs
 * Date: 30.12.2017
 * Time: 17:02
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using poeNullEffects.app;

namespace poeNullEffects {
    public partial class MainForm : Form {
        //================================================================================
        private Boolean isWorking = true;
        private string[] aWaitMessages;
        //================================================================================
        public MainForm() {
            InitializeComponent();
			
            aWaitMessages = new string[] {	
                "Finding the mirror recipe.",
                "Searching 50% of buffs.",
                "Solving P vs NP TY GL HF problem.",
                "Studying Alkaizers playlist.",
                "Making the new Diablo-like game.",
                "Sustaining T16 maps.",
                "Porting PoE to HTML5."
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
			
            //wait label. must have:
            lblWait.Visible = false;
            generateNewWaitMessage();
        }
        //================================================================================
        private void generateNewWaitMessage() {
            lblWait.Text = "" +
            aWaitMessages[CajApp.random.Next(0, aWaitMessages.Length)] +
                "\n" + "Please wait.";
            Point p = new Point((this.Size.Width - lblWait.Size.Width) / 2,
                                (this.Size.Height - lblWait.Size.Height) / 2);
            lblWait.Location = p;

            //TODO: threads.
            Application.DoEvents();
        }
        //================================================================================
        void MainFormLoad(object sender, EventArgs e) {
            //debug:
            if (CajApp.debugShowMainFrame) {
                tabActions.Visible = true;				
            }
        }
        //================================================================================
        delegate void addLogCallback(string s);
        //================================================================================
        public void addLog(String s) {
            if (!isWorking)
                return;
			
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
            if (!isWorking)
                return;
			
            enableActions(mode);
						
            if (!mode) {
                this.butOpenGgpk.Invoke((MethodInvoker)delegate {
                    this.butOpenGgpk.Enabled = true;
                });
            }
        }
        //================================================================================
        public void enableActions(Boolean mode) {
            if (!isWorking)
                return;
			
            this.tabActions.Invoke((MethodInvoker)delegate {
                this.tabActions.Visible = mode;  
                if (mode)
                    this.tabActions.BringToFront();
            });

            this.lblWait.Invoke((MethodInvoker)delegate {
                lblWait.Visible = !mode;
                if (!mode) {
                    generateNewWaitMessage();
                }
            });			
        }
        //================================================================================
        void ButOpenGgpkClick(object sender, EventArgs e) {
            butOpenGgpk.Enabled = false;
            txtLog.Focus();
            enableActions(false);
            CajApp.openGgpk(onOpenedGgpk);
			
            CajApp.config.write(CajConfig.keyGGPKPath, txtGgpkPath.Text);
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
            const string title = "Load Directory";
            const string text = "Input path to load all directory and subdirectory files into the GGPK:";
			
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
            const string text = "This 'disable shadows' method " +
                                "imports 'shadows.ffx' file from app\\data\\ folder." +
                                "\nGGG could change its format during major patches " +
                                "so make sure you have backup for import if something will go wrong." +
                                "\n\nDo you really want to do it?";
            const string caption = "Disable Shadows - import";
            if (MessageBox.Show(text, caption, MessageBoxButtons.YesNo) != DialogResult.Yes) {
                return;
            }
			
            CajApp.disableShadows_v32();
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
        void ButMakeGoodClick(object sender, EventArgs e) {
            CajApp.makeGood(makeGoodTrack.Value);
        }
        //================================================================================
        void MakeGoodTrackValueChanged(object sender, EventArgs e) {
            CajApp.onMakeGoodValueChange(makeGoodTrack.Value);
        }
        //================================================================================
        void TxtLogKeyDown(object sender, KeyEventArgs e) {
            if (e.Control && e.KeyCode == Keys.A) {
                txtLog.SelectAll();
            }          
        }
        //================================================================================
    }
}
