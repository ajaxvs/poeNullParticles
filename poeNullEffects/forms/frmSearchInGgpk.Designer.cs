/*
 * User: ajaxvs
 * Date: 02.01.2018
 * Time: 18:06
 */
namespace poeNullEffects
{
	partial class frmSearchInGgpk
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TextBox txtQuery;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ListBox lstRes;
		private System.Windows.Forms.RichTextBox txtValue;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem mnuFile;
		private System.Windows.Forms.ToolStripMenuItem mnuFileExport;
		private System.Windows.Forms.ToolStripMenuItem mnuFileImport;
		private System.Windows.Forms.SaveFileDialog exportDlg;
		private System.Windows.Forms.OpenFileDialog importDlg;
		private System.Windows.Forms.ToolStripMenuItem mnuQuery;
		private System.Windows.Forms.ToolStripMenuItem mnuQueryRegExp;
		private System.Windows.Forms.StatusStrip txtStatus;
		private System.Windows.Forms.ToolStripStatusLabel txtStatusLabel;
		private System.Windows.Forms.ToolStripMenuItem mnuQueryExportAll;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem mnuFileClose;
		
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
			this.txtQuery = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.lstRes = new System.Windows.Forms.ListBox();
			this.txtValue = new System.Windows.Forms.RichTextBox();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuFileExport = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuFileImport = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.mnuFileClose = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuQuery = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuQueryRegExp = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuQueryExportAll = new System.Windows.Forms.ToolStripMenuItem();
			this.exportDlg = new System.Windows.Forms.SaveFileDialog();
			this.importDlg = new System.Windows.Forms.OpenFileDialog();
			this.txtStatus = new System.Windows.Forms.StatusStrip();
			this.txtStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.menuStrip1.SuspendLayout();
			this.txtStatus.SuspendLayout();
			this.SuspendLayout();
			// 
			// txtQuery
			// 
			this.txtQuery.Location = new System.Drawing.Point(10, 55);
			this.txtQuery.Name = "txtQuery";
			this.txtQuery.Size = new System.Drawing.Size(323, 22);
			this.txtQuery.TabIndex = 1;
			this.txtQuery.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtQueryKeyDown);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(10, 35);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(188, 17);
			this.label1.TabIndex = 2;
			this.label1.Text = "Input query and press Enter:";
			// 
			// lstRes
			// 
			this.lstRes.FormattingEnabled = true;
			this.lstRes.HorizontalScrollbar = true;
			this.lstRes.ItemHeight = 16;
			this.lstRes.Location = new System.Drawing.Point(13, 86);
			this.lstRes.Name = "lstRes";
			this.lstRes.Size = new System.Drawing.Size(320, 564);
			this.lstRes.Sorted = true;
			this.lstRes.TabIndex = 3;
			this.lstRes.SelectedIndexChanged += new System.EventHandler(this.LstResSelectedIndexChanged);
			// 
			// txtValue
			// 
			this.txtValue.Font = new System.Drawing.Font("Courier New", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.txtValue.Location = new System.Drawing.Point(356, 55);
			this.txtValue.Name = "txtValue";
			this.txtValue.ReadOnly = true;
			this.txtValue.Size = new System.Drawing.Size(638, 595);
			this.txtValue.TabIndex = 4;
			this.txtValue.Text = "";
			this.txtValue.WordWrap = false;
			// 
			// menuStrip1
			// 
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.mnuFile,
			this.mnuQuery});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.menuStrip1.Size = new System.Drawing.Size(1006, 28);
			this.menuStrip1.TabIndex = 5;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// mnuFile
			// 
			this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.mnuFileExport,
			this.mnuFileImport,
			this.toolStripSeparator1,
			this.mnuFileClose});
			this.mnuFile.Name = "mnuFile";
			this.mnuFile.Size = new System.Drawing.Size(44, 24);
			this.mnuFile.Text = "File";
			// 
			// mnuFileExport
			// 
			this.mnuFileExport.Name = "mnuFileExport";
			this.mnuFileExport.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
			this.mnuFileExport.Size = new System.Drawing.Size(191, 26);
			this.mnuFileExport.Text = "Export...";
			this.mnuFileExport.Click += new System.EventHandler(this.MnuFileExportClick);
			// 
			// mnuFileImport
			// 
			this.mnuFileImport.Name = "mnuFileImport";
			this.mnuFileImport.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
			this.mnuFileImport.Size = new System.Drawing.Size(191, 26);
			this.mnuFileImport.Text = "Import...";
			this.mnuFileImport.Click += new System.EventHandler(this.MnuFileImportClick);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(188, 6);
			// 
			// mnuFileClose
			// 
			this.mnuFileClose.Name = "mnuFileClose";
			this.mnuFileClose.Size = new System.Drawing.Size(191, 26);
			this.mnuFileClose.Text = "Close";
			this.mnuFileClose.Click += new System.EventHandler(this.MnuFileCloseClick);
			// 
			// mnuQuery
			// 
			this.mnuQuery.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.mnuQueryRegExp,
			this.mnuQueryExportAll});
			this.mnuQuery.Name = "mnuQuery";
			this.mnuQuery.Size = new System.Drawing.Size(60, 24);
			this.mnuQuery.Text = "Query";
			// 
			// mnuQueryRegExp
			// 
			this.mnuQueryRegExp.CheckOnClick = true;
			this.mnuQueryRegExp.Name = "mnuQueryRegExp";
			this.mnuQueryRegExp.Size = new System.Drawing.Size(236, 26);
			this.mnuQueryRegExp.Text = "RegExp";
			// 
			// mnuQueryExportAll
			// 
			this.mnuQueryExportAll.Name = "mnuQueryExportAll";
			this.mnuQueryExportAll.Size = new System.Drawing.Size(236, 26);
			this.mnuQueryExportAll.Text = "Export All Found Files...";
			this.mnuQueryExportAll.Click += new System.EventHandler(this.ExportAllFoundFilesToolStripMenuItemClick);
			// 
			// importDlg
			// 
			this.importDlg.FileName = "openFileDialog1";
			// 
			// txtStatus
			// 
			this.txtStatus.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.txtStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.txtStatusLabel});
			this.txtStatus.Location = new System.Drawing.Point(0, 650);
			this.txtStatus.Name = "txtStatus";
			this.txtStatus.Size = new System.Drawing.Size(1006, 25);
			this.txtStatus.SizingGrip = false;
			this.txtStatus.TabIndex = 6;
			// 
			// txtStatusLabel
			// 
			this.txtStatusLabel.Name = "txtStatusLabel";
			this.txtStatusLabel.Size = new System.Drawing.Size(151, 20);
			this.txtStatusLabel.Text = "toolStripStatusLabel1";
			this.txtStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// frmSearchInGgpk
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1006, 675);
			this.Controls.Add(this.txtStatus);
			this.Controls.Add(this.txtValue);
			this.Controls.Add(this.lstRes);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtQuery);
			this.Controls.Add(this.menuStrip1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MainMenuStrip = this.menuStrip1;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmSearchInGgpk";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "GGPK Search";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmSearchInGgpkFormClosing);
			this.Load += new System.EventHandler(this.FrmSearchInGgpkLoad);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.txtStatus.ResumeLayout(false);
			this.txtStatus.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
