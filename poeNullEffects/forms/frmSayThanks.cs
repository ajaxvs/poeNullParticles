/*
 * User: ajaxvs
 * Date: 31.12.2017
 * Time: 17:32
 */
using System;
using System.Diagnostics;
using System.Windows.Forms;
using poeNullEffects.app;

namespace poeNullEffects {
    public partial class frmSayThanks : Form {
        //================================================================================
        public frmSayThanks() {
            InitializeComponent();
			
            string s;
            
            s = "\r\nIf you like this app - feel free to say \"Thanks\" with:" +
                Environment.NewLine + Environment.NewLine + "# Webmoney:" +
                Environment.NewLine + "Z354236776531" +
                Environment.NewLine + "R600482511370" +
                Environment.NewLine + Environment.NewLine + "# BTC:" +
                Environment.NewLine +"1KQC1BTfZ2KNa4fN8s8sB7jMahACdymoQX";            
            txtMain.Text = CajApp.aboutVersion + s;
            
            s = "(c) https://github.com/ajaxvs";
            txtLink.Text = s;
        }
        //================================================================================
        private void Button1Click(object sender, EventArgs e) {
            this.Close();
        }
        //================================================================================
        private void onLinkClick(object sender, LinkClickedEventArgs e) {
            try {
                System.Diagnostics.Process.Start(e.LinkText);
            } catch (Exception ex) {
                Debug.WriteLine(ex);
            }
        }
        //================================================================================
    }
}
