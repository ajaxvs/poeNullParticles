/*
 * User: ajaxvs
 * Date: 31.12.2017
 * Time: 17:32
 */
using System;
using System.Windows.Forms;
using poeNullEffects.app;

namespace poeNullEffects {
    public partial class frmSayThanks : Form {
        //================================================================================
        public frmSayThanks() {
            InitializeComponent();
			
            txt.Text = CajApp.aboutVersion + txt.Text;
        }
        //================================================================================
        void Button1Click(object sender, EventArgs e) {
            this.Close();
        }
        //================================================================================
        void onLinkClick(object sender, LinkClickedEventArgs e) {
            try {
                System.Diagnostics.Process.Start(e.LinkText);
            } catch {
                //.
            }
        }
        //================================================================================
        void RichTextBox2TextChanged(object sender, EventArgs e) {
            //.
        }
        //================================================================================
    }
}
