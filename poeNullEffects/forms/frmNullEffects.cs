/*
 * User: ajaxvs
 * Date: 01.01.2018
 * Time: 17:01
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using poeNullEffects.app;

namespace poeNullEffects
{
	public partial class frmNullEffects : Form
	{
		//================================================================================
		public frmNullEffects()
		{
			InitializeComponent();
			
			optAll.Checked = true;
			txtList.Text = "The Best Performance Method (recommended)";
		}
		//================================================================================
		private void correctUI() {
			bool notAll = !optAll.Checked;
			txtList.Enabled = notAll;	
			
			butSave.Enabled = false;
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
				correctUI();
				txtList.Text = "The Best Performance Method (recommended)";
				lblLog.Text = "";
			}
		}
		//================================================================================
		void OptAllExceptCheckedChanged(object sender, EventArgs e) {
			if (optAllExcept.Checked) {
				correctUI();
				loadList(CajApp.getAppPath() + CajApp.effectsListFileAllExcept);
			}
		}
		//================================================================================
		void OptOnlyCheckedChanged(object sender, EventArgs e) {
			if (optOnly.Checked) {
				correctUI();
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

			CajApp.nullEffects(type, text);
			
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
		
	}
}
