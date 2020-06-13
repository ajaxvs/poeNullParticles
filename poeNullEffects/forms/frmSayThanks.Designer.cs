/*
 * User: ajaxvs
 * Date: 31.12.2017
 * Time: 17:32
 */
namespace poeNullEffects
{
	partial class frmSayThanks
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.RichTextBox txtMain;
		private System.Windows.Forms.RichTextBox txtLink;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
		    this.panel1 = new System.Windows.Forms.Panel();
		    this.txtLink = new System.Windows.Forms.RichTextBox();
		    this.button1 = new System.Windows.Forms.Button();
		    this.txtMain = new System.Windows.Forms.RichTextBox();
		    this.panel1.SuspendLayout();
		    this.SuspendLayout();
		    // 
		    // panel1
		    // 
		    this.panel1.Controls.Add(this.txtLink);
		    this.panel1.Controls.Add(this.button1);
		    this.panel1.Controls.Add(this.txtMain);
		    this.panel1.Location = new System.Drawing.Point(13, 13);
		    this.panel1.Name = "panel1";
		    this.panel1.Size = new System.Drawing.Size(557, 315);
		    this.panel1.TabIndex = 0;
		    // 
		    // txtLink
		    // 
		    this.txtLink.BorderStyle = System.Windows.Forms.BorderStyle.None;
		    this.txtLink.Location = new System.Drawing.Point(3, 286);
		    this.txtLink.Name = "txtLink";
		    this.txtLink.ReadOnly = true;
		    this.txtLink.Size = new System.Drawing.Size(392, 24);
		    this.txtLink.TabIndex = 2;
		    this.txtLink.TabStop = false;
		    this.txtLink.Text = "...";
		    this.txtLink.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.onLinkClick);
		    // 
		    // button1
		    // 
		    this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
		    this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
		    this.button1.Location = new System.Drawing.Point(413, 239);
		    this.button1.Name = "button1";
		    this.button1.Size = new System.Drawing.Size(128, 64);
		    this.button1.TabIndex = 0;
		    this.button1.Text = "OK";
		    this.button1.UseVisualStyleBackColor = true;
		    this.button1.Click += new System.EventHandler(this.Button1Click);
		    // 
		    // txtMain
		    // 
		    this.txtMain.Location = new System.Drawing.Point(15, 15);
		    this.txtMain.Name = "txtMain";
		    this.txtMain.ReadOnly = true;
		    this.txtMain.Size = new System.Drawing.Size(526, 210);
		    this.txtMain.TabIndex = 0;
		    this.txtMain.TabStop = false;
		    this.txtMain.Text = "...";
		    this.txtMain.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.onLinkClick);
		    // 
		    // frmSayThanks
		    // 
		    this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		    this.ClientSize = new System.Drawing.Size(582, 335);
		    this.Controls.Add(this.panel1);
		    this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
		    this.MaximizeBox = false;
		    this.MinimizeBox = false;
		    this.Name = "frmSayThanks";
		    this.ShowIcon = false;
		    this.ShowInTaskbar = false;
		    this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		    this.Text = "Say Thanks";
		    this.panel1.ResumeLayout(false);
		    this.ResumeLayout(false);

		}
	}
}
