/*
 * User: ajaxvs
 * Date: 01.01.2018
 * Time: 17:01
 */
using System;
using System.Windows.Forms;
using poeNullEffects.app;

namespace poeNullEffects {
    public partial class frmNullEffects : Form {
        //================================================================================
        public frmNullEffects() {
            InitializeComponent();
			
            optAll.Checked = true;
            txtList.Text = "The Best Performance Method (recommended)";
			
            //emitters:
            var s = CajApp.config.read(CajConfig.keyKeepEmitters);
            if (s != "") {				
                setEmitters(int.Parse(s), false);
            }
			
            //method:
            s = CajApp.config.read(CajConfig.keyNullParticlesMethod);
            if (s == CajApp.NULL_TYPE_ALL.ToString()) {
                optAll.Checked = true;
            } else if (s == CajApp.NULL_TYPE_ALL_EXCEPT.ToString()) {
                optAllExcept.Checked = true;
            } else if (s == CajApp.NULL_TYPE_ONLY.ToString()) {
                optOnly.Checked = true;
            }
        }
        //================================================================================
        private void onMethodChange() {
            //ui:
            txtList.Enabled = !optAll.Checked;
            butSave.Enabled = false;
			
            //config:
            var s = "";
            if (optAll.Checked) {
                s = CajApp.NULL_TYPE_ALL.ToString();
            } else if (optAllExcept.Checked) {
                s = CajApp.NULL_TYPE_ALL_EXCEPT.ToString();
            } else if (optOnly.Checked) {
                s = CajApp.NULL_TYPE_ONLY.ToString();
            }
            CajApp.config.write(CajConfig.keyNullParticlesMethod, s, true);
        }
        //================================================================================
        void loadList(string filePath) {
            try {
                txtList.Text = System.IO.File.ReadAllText(filePath);
                //lblLog.Text = CajApp.getCurrentTimeFormat() + ". loaded list."; //debug.
            } catch (Exception ex) {
                lblLog.Text = CajApp.getCurrentTimeFormat() + ". Error loading list: " + ex.Message;
                txtList.Text = "";
            }
        }
        //================================================================================
        void OptAllCheckedChanged(object sender, EventArgs e) {
            if (optAll.Checked) {
                onMethodChange();
                txtList.Text = "The Best Performance Method (recommended)";
                lblLog.Text = "";
            }
        }
        //================================================================================
        void OptAllExceptCheckedChanged(object sender, EventArgs e) {
            if (optAllExcept.Checked) {
                onMethodChange();
                loadList(CajApp.getAppPath() + CajApp.effectsListFileAllExcept);
            }
        }
        //================================================================================
        void OptOnlyCheckedChanged(object sender, EventArgs e) {
            if (optOnly.Checked) {
                onMethodChange();
                loadList(CajApp.getAppPath() + CajApp.effectsListFileOnly);
            }
        }
        //================================================================================
        void ButOkClick(object sender, EventArgs e) {
            int type = 0;
            string text = "";
            if (optAll.Checked) {
                type = CajApp.NULL_TYPE_ALL;
                text = "";
            } else if (optAllExcept.Checked) {
                type = CajApp.NULL_TYPE_ALL_EXCEPT;
                text = txtList.Text;
            } else if (optOnly.Checked) {
                type = CajApp.NULL_TYPE_ONLY;
                text = txtList.Text;
            }

            int numKeepEmitters = 0;			
            String s = CajApp.config.read(CajConfig.keyKeepEmitters);
            if (s != "") {
                numKeepEmitters = int.Parse(s);
            }
			
            CajApp.nullEffects(type, text, numKeepEmitters);
			
            this.Hide();
        }
        //================================================================================
        void butSaveListClick(object sender, EventArgs e) {			
            string sRes = "";
			
            if (optAllExcept.Checked) {
                sRes = CajApp.saveNullEffectsList(CajApp.effectsListFileAllExcept, txtList.Text);
            } else if (optOnly.Checked) {
                sRes = CajApp.saveNullEffectsList(CajApp.effectsListFileOnly, txtList.Text);
            }
			
            lblLog.Text = sRes;
        }
        //================================================================================
        void TxtListKeyUp(object sender, KeyEventArgs e) {
            if (!optAll.Checked) {
                butSave.Enabled = true;
            }
        }
        //================================================================================
        void MnuKeepEmitters0Click(object sender, EventArgs e) {
            setEmitters(0, true);
        }
        //================================================================================
        void MnuKeepEmitters1Click(object sender, EventArgs e) {
            setEmitters(1, true);
        }
        //================================================================================
        private void setEmitters(int i, bool writeConfig) {
            if (i == 0) {
                mnuKeepEmitters0.Checked = true;
                mnuKeepEmitters1.Checked = false;
            } else {
                mnuKeepEmitters0.Checked = false;
                mnuKeepEmitters1.Checked = true;
            }
            if (writeConfig) {
                CajApp.config.write(CajConfig.keyKeepEmitters, i.ToString(), true);
            }
        }
        //================================================================================
        void MnuKeepEmittersClick(object sender, EventArgs e) {
            //nn.
        }
        //================================================================================
    }
}
