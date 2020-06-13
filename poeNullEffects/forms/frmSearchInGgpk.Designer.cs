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
		private System.Windows.Forms.ListView lstResults;
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
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.SplitContainer splitContainer2;
		private System.Windows.Forms.ColumnHeader mnuColumnResults;
		private System.Windows.Forms.PictureBox picValue;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripMenuItem mnuSavePicture;
		
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
		    this.txtValue = new System.Windows.Forms.RichTextBox();
		    this.menuStrip1 = new System.Windows.Forms.MenuStrip();
		    this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
		    this.mnuFileExport = new System.Windows.Forms.ToolStripMenuItem();
		    this.mnuFileImport = new System.Windows.Forms.ToolStripMenuItem();
		    this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
		    this.mnuSavePicture = new System.Windows.Forms.ToolStripMenuItem();
		    this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
		    this.mnuFileClose = new System.Windows.Forms.ToolStripMenuItem();
		    this.mnuQuery = new System.Windows.Forms.ToolStripMenuItem();
		    this.mnuQueryRegExp = new System.Windows.Forms.ToolStripMenuItem();
		    this.mnuQueryExportAll = new System.Windows.Forms.ToolStripMenuItem();
		    this.exportDlg = new System.Windows.Forms.SaveFileDialog();
		    this.importDlg = new System.Windows.Forms.OpenFileDialog();
		    this.txtStatus = new System.Windows.Forms.StatusStrip();
		    this.txtStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
		    this.splitContainer1 = new System.Windows.Forms.SplitContainer();
		    this.splitContainer2 = new System.Windows.Forms.SplitContainer();
		    this.panel2 = new System.Windows.Forms.Panel();
		    this.txtQuery = new System.Windows.Forms.TextBox();
		    this.panel1 = new System.Windows.Forms.Panel();
		    this.label1 = new System.Windows.Forms.Label();
		    this.lstResults = new System.Windows.Forms.ListView();
		    this.mnuColumnResults = new System.Windows.Forms.ColumnHeader();
		    this.picValue = new System.Windows.Forms.PictureBox();
		    this.menuStrip1.SuspendLayout();
		    this.txtStatus.SuspendLayout();
		    ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
		    this.splitContainer1.Panel1.SuspendLayout();
		    this.splitContainer1.Panel2.SuspendLayout();
		    this.splitContainer1.SuspendLayout();
		    ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
		    this.splitContainer2.Panel1.SuspendLayout();
		    this.splitContainer2.Panel2.SuspendLayout();
		    this.splitContainer2.SuspendLayout();
		    this.panel2.SuspendLayout();
		    this.panel1.SuspendLayout();
		    ((System.ComponentModel.ISupportInitialize)(this.picValue)).BeginInit();
		    this.SuspendLayout();
		    // 
		    // txtValue
		    // 
		    this.txtValue.Dock = System.Windows.Forms.DockStyle.Fill;
		    this.txtValue.Font = new System.Drawing.Font("Courier New", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
		    this.txtValue.Location = new System.Drawing.Point(5, 5);
		    this.txtValue.Name = "txtValue";
		    this.txtValue.ReadOnly = true;
		    this.txtValue.Size = new System.Drawing.Size(657, 612);
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
            this.toolStripSeparator2,
            this.mnuSavePicture,
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
		    // toolStripSeparator2
		    // 
		    this.toolStripSeparator2.Name = "toolStripSeparator2";
		    this.toolStripSeparator2.Size = new System.Drawing.Size(188, 6);
		    // 
		    // mnuSavePicture
		    // 
		    this.mnuSavePicture.Name = "mnuSavePicture";
		    this.mnuSavePicture.Size = new System.Drawing.Size(191, 26);
		    this.mnuSavePicture.Text = "Save Picture";
		    this.mnuSavePicture.Click += new System.EventHandler(this.MnuSavePictureClick);
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
		    // splitContainer1
		    // 
		    this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
		    this.splitContainer1.Location = new System.Drawing.Point(0, 28);
		    this.splitContainer1.Name = "splitContainer1";
		    // 
		    // splitContainer1.Panel1
		    // 
		    this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
		    this.splitContainer1.Panel1.ImeMode = System.Windows.Forms.ImeMode.Off;
		    this.splitContainer1.Panel1MinSize = 50;
		    // 
		    // splitContainer1.Panel2
		    // 
		    this.splitContainer1.Panel2.Controls.Add(this.picValue);
		    this.splitContainer1.Panel2.Controls.Add(this.txtValue);
		    this.splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(5);
		    this.splitContainer1.Panel2MinSize = 50;
		    this.splitContainer1.Size = new System.Drawing.Size(1006, 622);
		    this.splitContainer1.SplitterDistance = 335;
		    this.splitContainer1.TabIndex = 7;
		    // 
		    // splitContainer2
		    // 
		    this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
		    this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
		    this.splitContainer2.Location = new System.Drawing.Point(0, 0);
		    this.splitContainer2.Name = "splitContainer2";
		    this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
		    // 
		    // splitContainer2.Panel1
		    // 
		    this.splitContainer2.Panel1.Controls.Add(this.panel2);
		    this.splitContainer2.Panel1.Controls.Add(this.panel1);
		    this.splitContainer2.Panel1MinSize = 75;
		    // 
		    // splitContainer2.Panel2
		    // 
		    this.splitContainer2.Panel2.Controls.Add(this.lstResults);
		    this.splitContainer2.Size = new System.Drawing.Size(335, 622);
		    this.splitContainer2.SplitterDistance = 75;
		    this.splitContainer2.TabIndex = 0;
		    // 
		    // panel2
		    // 
		    this.panel2.Controls.Add(this.txtQuery);
		    this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
		    this.panel2.Location = new System.Drawing.Point(0, 39);
		    this.panel2.Name = "panel2";
		    this.panel2.Size = new System.Drawing.Size(335, 36);
		    this.panel2.TabIndex = 1;
		    // 
		    // txtQuery
		    // 
		    this.txtQuery.Dock = System.Windows.Forms.DockStyle.Fill;
		    this.txtQuery.Location = new System.Drawing.Point(0, 0);
		    this.txtQuery.Name = "txtQuery";
		    this.txtQuery.Size = new System.Drawing.Size(335, 22);
		    this.txtQuery.TabIndex = 1;
		    this.txtQuery.Text = "...";
		    this.txtQuery.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtQueryKeyDown);
		    // 
		    // panel1
		    // 
		    this.panel1.Controls.Add(this.label1);
		    this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
		    this.panel1.Location = new System.Drawing.Point(0, 0);
		    this.panel1.Name = "panel1";
		    this.panel1.Size = new System.Drawing.Size(335, 39);
		    this.panel1.TabIndex = 0;
		    // 
		    // label1
		    // 
		    this.label1.AutoSize = true;
		    this.label1.Location = new System.Drawing.Point(3, 9);
		    this.label1.Name = "label1";
		    this.label1.Size = new System.Drawing.Size(188, 17);
		    this.label1.TabIndex = 4;
		    this.label1.Text = "Input query and press Enter:";
		    // 
		    // lstResults
		    // 
		    this.lstResults.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.mnuColumnResults});
		    this.lstResults.Dock = System.Windows.Forms.DockStyle.Fill;
		    this.lstResults.Location = new System.Drawing.Point(0, 0);
		    this.lstResults.Name = "lstResults";
		    this.lstResults.Size = new System.Drawing.Size(335, 543);
		    this.lstResults.TabIndex = 4;
		    this.lstResults.UseCompatibleStateImageBehavior = false;
		    this.lstResults.SelectedIndexChanged += new System.EventHandler(this.LstResSelectedIndexChanged);
		    this.lstResults.Resize += new System.EventHandler(this.LstResultsResize);
		    // 
		    // mnuColumnResults
		    // 
		    this.mnuColumnResults.Text = "Results:";
		    this.mnuColumnResults.Width = 0;
		    // 
		    // picValue
		    // 
		    this.picValue.Location = new System.Drawing.Point(10, 10);
		    this.picValue.Name = "picValue";
		    this.picValue.Size = new System.Drawing.Size(256, 256);
		    this.picValue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
		    this.picValue.TabIndex = 5;
		    this.picValue.TabStop = false;
		    // 
		    // frmSearchInGgpk
		    // 
		    this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		    this.ClientSize = new System.Drawing.Size(1006, 675);
		    this.Controls.Add(this.splitContainer1);
		    this.Controls.Add(this.txtStatus);
		    this.Controls.Add(this.menuStrip1);
		    this.MainMenuStrip = this.menuStrip1;
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
		    this.splitContainer1.Panel1.ResumeLayout(false);
		    this.splitContainer1.Panel2.ResumeLayout(false);
		    this.splitContainer1.Panel2.PerformLayout();
		    ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
		    this.splitContainer1.ResumeLayout(false);
		    this.splitContainer2.Panel1.ResumeLayout(false);
		    this.splitContainer2.Panel2.ResumeLayout(false);
		    ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
		    this.splitContainer2.ResumeLayout(false);
		    this.panel2.ResumeLayout(false);
		    this.panel2.PerformLayout();
		    this.panel1.ResumeLayout(false);
		    this.panel1.PerformLayout();
		    ((System.ComponentModel.ISupportInitialize)(this.picValue)).EndInit();
		    this.ResumeLayout(false);
		    this.PerformLayout();

		}
	}
}
