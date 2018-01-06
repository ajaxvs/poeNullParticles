/*
 * User: ajaxvs
 * Date: 03.01.2018
 * Time: 18:15
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace poeNullEffects
{
	public partial class frmInputBox : Form {
		//================================================================================
		private Action<string> funOnOK;
		//================================================================================
		public frmInputBox() {
			InitializeComponent();
		}
		//================================================================================
		public void setParams(string title, string text, Action<string> onOK) {
			this.Text = title;
			lblText.Text = text;
			funOnOK = onOK;
		}
		//================================================================================
		void ButOKClick(object sender, EventArgs e) {
			if (funOnOK != null) {
				funOnOK(txtValue.Text);
			}
		}
		//================================================================================
	}
}
