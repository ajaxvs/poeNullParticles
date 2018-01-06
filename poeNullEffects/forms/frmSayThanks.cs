/*
 * User: ajaxvs
 * Date: 31.12.2017
 * Time: 17:32
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace poeNullEffects
{
	public partial class frmSayThanks : Form {
		//================================================================================
		public frmSayThanks() {
			InitializeComponent();
		}
		//================================================================================
		void Button1Click(object sender, EventArgs e) {
			this.Close();
		}
		//================================================================================
		void onLinkClick(object sender, LinkClickedEventArgs e) {
			try {
				System.Diagnostics.Process.Start(e.LinkText);
			} catch (Exception ex) {
				//.
			}
		}
		//================================================================================
	}
}
