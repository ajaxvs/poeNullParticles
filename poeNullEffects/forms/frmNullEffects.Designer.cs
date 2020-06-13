/*
 * User: ajaxvs
 * Date: 01.01.2018
 * Time: 17:01
 */
namespace poeNullEffects
{
	partial class frmNullEffects
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button butOk;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton optOnly;
		private System.Windows.Forms.RadioButton optAllExcept;
		private System.Windows.Forms.RadioButton optAll;
		private System.Windows.Forms.TextBox txtList;
		private System.Windows.Forms.Button butSave;
		private System.Windows.Forms.Label lblLog;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem mnuKeepEmitters;
		private System.Windows.Forms.ToolStripMenuItem mnuKeepEmitters0;
		private System.Windows.Forms.ToolStripMenuItem mnuKeepEmitters1;
		private System.Windows.Forms.Label label1;
		
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
		    this.butOk = new System.Windows.Forms.Button();
		    this.groupBox1 = new System.Windows.Forms.GroupBox();
		    this.label1 = new System.Windows.Forms.Label();
		    this.txtList = new System.Windows.Forms.TextBox();
		    this.optOnly = new System.Windows.Forms.RadioButton();
		    this.optAllExcept = new System.Windows.Forms.RadioButton();
		    this.optAll = new System.Windows.Forms.RadioButton();
		    this.butSave = new System.Windows.Forms.Button();
		    this.lblLog = new System.Windows.Forms.Label();
		    this.menuStrip1 = new System.Windows.Forms.MenuStrip();
		    this.mnuKeepEmitters = new System.Windows.Forms.ToolStripMenuItem();
		    this.mnuKeepEmitters0 = new System.Windows.Forms.ToolStripMenuItem();
		    this.mnuKeepEmitters1 = new System.Windows.Forms.ToolStripMenuItem();
		    this.groupBox1.SuspendLayout();
		    this.menuStrip1.SuspendLayout();
		    this.SuspendLayout();
		    // 
		    // butOk
		    // 
		    this.butOk.DialogResult = System.Windows.Forms.DialogResult.OK;
		    this.butOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
		    this.butOk.Location = new System.Drawing.Point(639, 422);
		    this.butOk.Name = "butOk";
		    this.butOk.Size = new System.Drawing.Size(128, 48);
		    this.butOk.TabIndex = 5;
		    this.butOk.Text = "Null";
		    this.butOk.UseVisualStyleBackColor = true;
		    this.butOk.Click += new System.EventHandler(this.ButOkClick);
		    // 
		    // groupBox1
		    // 
		    this.groupBox1.Controls.Add(this.label1);
		    this.groupBox1.Controls.Add(this.txtList);
		    this.groupBox1.Controls.Add(this.optOnly);
		    this.groupBox1.Controls.Add(this.optAllExcept);
		    this.groupBox1.Controls.Add(this.optAll);
		    this.groupBox1.Location = new System.Drawing.Point(12, 30);
		    this.groupBox1.Name = "groupBox1";
		    this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
		    this.groupBox1.Size = new System.Drawing.Size(758, 382);
		    this.groupBox1.TabIndex = 2;
		    this.groupBox1.TabStop = false;
		    // 
		    // label1
		    // 
		    this.label1.Location = new System.Drawing.Point(6, 0);
		    this.label1.Name = "label1";
		    this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
		    this.label1.Size = new System.Drawing.Size(746, 23);
		    this.label1.TabIndex = 4;
		    this.label1.Text = "select method:";
		    this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
		    // 
		    // txtList
		    // 
		    this.txtList.Enabled = false;
		    this.txtList.Location = new System.Drawing.Point(6, 50);
		    this.txtList.Multiline = true;
		    this.txtList.Name = "txtList";
		    this.txtList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
		    this.txtList.Size = new System.Drawing.Size(746, 325);
		    this.txtList.TabIndex = 3;
		    this.txtList.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtListKeyUp);
		    // 
		    // optOnly
		    // 
		    this.optOnly.AutoSize = true;
		    this.optOnly.Location = new System.Drawing.Point(575, 23);
		    this.optOnly.Name = "optOnly";
		    this.optOnly.Size = new System.Drawing.Size(135, 21);
		    this.optOnly.TabIndex = 2;
		    this.optOnly.Text = "Disable Only List";
		    this.optOnly.UseVisualStyleBackColor = true;
		    this.optOnly.CheckedChanged += new System.EventHandler(this.OptOnlyCheckedChanged);
		    // 
		    // optAllExcept
		    // 
		    this.optAllExcept.AutoSize = true;
		    this.optAllExcept.Location = new System.Drawing.Point(316, 23);
		    this.optAllExcept.Name = "optAllExcept";
		    this.optAllExcept.Size = new System.Drawing.Size(167, 21);
		    this.optAllExcept.TabIndex = 1;
		    this.optAllExcept.Text = "Disable All Except List";
		    this.optAllExcept.UseVisualStyleBackColor = true;
		    this.optAllExcept.CheckedChanged += new System.EventHandler(this.OptAllExceptCheckedChanged);
		    // 
		    // optAll
		    // 
		    this.optAll.AutoSize = true;
		    this.optAll.Checked = true;
		    this.optAll.Location = new System.Drawing.Point(7, 23);
		    this.optAll.Name = "optAll";
		    this.optAll.Size = new System.Drawing.Size(95, 21);
		    this.optAll.TabIndex = 0;
		    this.optAll.TabStop = true;
		    this.optAll.Text = "Disable All";
		    this.optAll.UseVisualStyleBackColor = true;
		    this.optAll.CheckedChanged += new System.EventHandler(this.OptAllCheckedChanged);
		    // 
		    // butSave
		    // 
		    this.butSave.Enabled = false;
		    this.butSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
		    this.butSave.Location = new System.Drawing.Point(12, 423);
		    this.butSave.Name = "butSave";
		    this.butSave.Size = new System.Drawing.Size(128, 48);
		    this.butSave.TabIndex = 4;
		    this.butSave.Text = "Save List";
		    this.butSave.UseVisualStyleBackColor = true;
		    this.butSave.Click += new System.EventHandler(this.butSaveListClick);
		    // 
		    // lblLog
		    // 
		    this.lblLog.Location = new System.Drawing.Point(159, 423);
		    this.lblLog.Name = "lblLog";
		    this.lblLog.Size = new System.Drawing.Size(449, 55);
		    this.lblLog.TabIndex = 6;
		    this.lblLog.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		    // 
		    // menuStrip1
		    // 
		    this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
		    this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuKeepEmitters});
		    this.menuStrip1.Location = new System.Drawing.Point(0, 0);
		    this.menuStrip1.Name = "menuStrip1";
		    this.menuStrip1.Size = new System.Drawing.Size(791, 28);
		    this.menuStrip1.TabIndex = 7;
		    this.menuStrip1.Text = "menuStrip1";
		    // 
		    // mnuKeepEmitters
		    // 
		    this.mnuKeepEmitters.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuKeepEmitters0,
            this.mnuKeepEmitters1});
		    this.mnuKeepEmitters.Name = "mnuKeepEmitters";
		    this.mnuKeepEmitters.Size = new System.Drawing.Size(120, 24);
		    this.mnuKeepEmitters.Text = "keep emitters...";
		    this.mnuKeepEmitters.Click += new System.EventHandler(this.MnuKeepEmittersClick);
		    // 
		    // mnuKeepEmitters0
		    // 
		    this.mnuKeepEmitters0.Checked = true;
		    this.mnuKeepEmitters0.CheckState = System.Windows.Forms.CheckState.Checked;
		    this.mnuKeepEmitters0.Name = "mnuKeepEmitters0";
		    this.mnuKeepEmitters0.Size = new System.Drawing.Size(92, 26);
		    this.mnuKeepEmitters0.Text = "0";
		    this.mnuKeepEmitters0.Click += new System.EventHandler(this.MnuKeepEmitters0Click);
		    // 
		    // mnuKeepEmitters1
		    // 
		    this.mnuKeepEmitters1.Name = "mnuKeepEmitters1";
		    this.mnuKeepEmitters1.Size = new System.Drawing.Size(92, 26);
		    this.mnuKeepEmitters1.Text = "1";
		    this.mnuKeepEmitters1.Click += new System.EventHandler(this.MnuKeepEmitters1Click);
		    // 
		    // frmNullEffects
		    // 
		    this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		    this.ClientSize = new System.Drawing.Size(791, 485);
		    this.Controls.Add(this.lblLog);
		    this.Controls.Add(this.butSave);
		    this.Controls.Add(this.groupBox1);
		    this.Controls.Add(this.butOk);
		    this.Controls.Add(this.menuStrip1);
		    this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
		    this.MainMenuStrip = this.menuStrip1;
		    this.MaximizeBox = false;
		    this.MinimizeBox = false;
		    this.Name = "frmNullEffects";
		    this.ShowIcon = false;
		    this.ShowInTaskbar = false;
		    this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		    this.Text = "Null Particles";
		    this.groupBox1.ResumeLayout(false);
		    this.groupBox1.PerformLayout();
		    this.menuStrip1.ResumeLayout(false);
		    this.menuStrip1.PerformLayout();
		    this.ResumeLayout(false);
		    this.PerformLayout();

		}
	}
}
