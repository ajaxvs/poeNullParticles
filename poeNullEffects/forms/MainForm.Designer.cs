/*
 * User: ajaxvs
 * Date: 30.12.2017
 * Time: 17:02
 */
namespace poeNullEffects
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TextBox txtLog;
		private System.Windows.Forms.TextBox txtGgpkPath;
		private System.Windows.Forms.Label lbl1;
		private System.Windows.Forms.Button butNullParticles;
		private System.Windows.Forms.OpenFileDialog openGgpkDlg;
		private System.Windows.Forms.Button butLocateGgpk;
		private System.Windows.Forms.Button butDisableShadows;
		private System.Windows.Forms.Button butOpenGgpk;
		private System.Windows.Forms.Button butSavePets;
		private System.Windows.Forms.SaveFileDialog saveBackupDlg;
		private System.Windows.Forms.Button butLoadPets;
		private System.Windows.Forms.OpenFileDialog loadBackupDlg;
		private System.Windows.Forms.Button butSayThanks;
		private System.Windows.Forms.TabControl tabActions;
		private System.Windows.Forms.TabPage tabParticles;
		private System.Windows.Forms.TabPage tabEffects;
		private System.Windows.Forms.Button butNoDeadBodies;
		private System.Windows.Forms.Button butSaveMisc;
		private System.Windows.Forms.TabPage tabMisc;
		private System.Windows.Forms.Button butSearchInGgpk;
		private System.Windows.Forms.Button butLoadDir;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.Button butMakeGood;
		private System.Windows.Forms.TrackBar makeGoodTrack;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblWait;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button butEnableShadows;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.SplitContainer splitContainer2;
		private System.Windows.Forms.SplitContainer splitContainer3;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TabPage tabCheckList;
		private System.Windows.Forms.SplitContainer splitContainerCheckList;
		private System.Windows.Forms.Button butCheckListDisable;
		private System.Windows.Forms.Button butCheckListEnable;
		private System.Windows.Forms.Button butCheckListSelectAll;
		private System.Windows.Forms.Button butCheckListUpdate;
		private System.Windows.Forms.ListView lstCheckList;
		private System.Windows.Forms.ColumnHeader colEmitters;
		private System.Windows.Forms.ColumnHeader colFile;
		private System.Windows.Forms.TextBox txtCheckListFilter;
		private System.Windows.Forms.ToolStripMenuItem mnuDontOpen;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.Button butCorpsesEnable;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ToolStripMenuItem mnuStopCurrentTask;
		private System.Windows.Forms.Button butCheckListFindSkill;
		
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
		    System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
		    this.txtGgpkPath = new System.Windows.Forms.TextBox();
		    this.lbl1 = new System.Windows.Forms.Label();
		    this.butNullParticles = new System.Windows.Forms.Button();
		    this.openGgpkDlg = new System.Windows.Forms.OpenFileDialog();
		    this.butLocateGgpk = new System.Windows.Forms.Button();
		    this.butDisableShadows = new System.Windows.Forms.Button();
		    this.butOpenGgpk = new System.Windows.Forms.Button();
		    this.butSavePets = new System.Windows.Forms.Button();
		    this.saveBackupDlg = new System.Windows.Forms.SaveFileDialog();
		    this.butLoadPets = new System.Windows.Forms.Button();
		    this.loadBackupDlg = new System.Windows.Forms.OpenFileDialog();
		    this.txtLog = new System.Windows.Forms.TextBox();
		    this.butSayThanks = new System.Windows.Forms.Button();
		    this.tabActions = new System.Windows.Forms.TabControl();
		    this.tabPage2 = new System.Windows.Forms.TabPage();
		    this.label2 = new System.Windows.Forms.Label();
		    this.label1 = new System.Windows.Forms.Label();
		    this.makeGoodTrack = new System.Windows.Forms.TrackBar();
		    this.butMakeGood = new System.Windows.Forms.Button();
		    this.tabCheckList = new System.Windows.Forms.TabPage();
		    this.splitContainerCheckList = new System.Windows.Forms.SplitContainer();
		    this.lstCheckList = new System.Windows.Forms.ListView();
		    this.colEmitters = new System.Windows.Forms.ColumnHeader();
		    this.colFile = new System.Windows.Forms.ColumnHeader();
		    this.butCheckListFindSkill = new System.Windows.Forms.Button();
		    this.txtCheckListFilter = new System.Windows.Forms.TextBox();
		    this.butCheckListDisable = new System.Windows.Forms.Button();
		    this.butCheckListEnable = new System.Windows.Forms.Button();
		    this.butCheckListSelectAll = new System.Windows.Forms.Button();
		    this.butCheckListUpdate = new System.Windows.Forms.Button();
		    this.tabParticles = new System.Windows.Forms.TabPage();
		    this.tabEffects = new System.Windows.Forms.TabPage();
		    this.butCorpsesEnable = new System.Windows.Forms.Button();
		    this.label4 = new System.Windows.Forms.Label();
		    this.label3 = new System.Windows.Forms.Label();
		    this.butEnableShadows = new System.Windows.Forms.Button();
		    this.butNoDeadBodies = new System.Windows.Forms.Button();
		    this.butSaveMisc = new System.Windows.Forms.Button();
		    this.tabMisc = new System.Windows.Forms.TabPage();
		    this.butLoadDir = new System.Windows.Forms.Button();
		    this.butSearchInGgpk = new System.Windows.Forms.Button();
		    this.lblWait = new System.Windows.Forms.Label();
		    this.splitContainer1 = new System.Windows.Forms.SplitContainer();
		    this.splitContainer2 = new System.Windows.Forms.SplitContainer();
		    this.splitContainer3 = new System.Windows.Forms.SplitContainer();
		    this.panel1 = new System.Windows.Forms.Panel();
		    this.menuStrip1 = new System.Windows.Forms.MenuStrip();
		    this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		    this.mnuStopCurrentTask = new System.Windows.Forms.ToolStripMenuItem();
		    this.mnuDontOpen = new System.Windows.Forms.ToolStripMenuItem();
		    this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
		    this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		    this.tabActions.SuspendLayout();
		    this.tabPage2.SuspendLayout();
		    ((System.ComponentModel.ISupportInitialize)(this.makeGoodTrack)).BeginInit();
		    this.tabCheckList.SuspendLayout();
		    ((System.ComponentModel.ISupportInitialize)(this.splitContainerCheckList)).BeginInit();
		    this.splitContainerCheckList.Panel1.SuspendLayout();
		    this.splitContainerCheckList.Panel2.SuspendLayout();
		    this.splitContainerCheckList.SuspendLayout();
		    this.tabParticles.SuspendLayout();
		    this.tabEffects.SuspendLayout();
		    this.tabMisc.SuspendLayout();
		    ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
		    this.splitContainer1.Panel1.SuspendLayout();
		    this.splitContainer1.Panel2.SuspendLayout();
		    this.splitContainer1.SuspendLayout();
		    ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
		    this.splitContainer2.Panel1.SuspendLayout();
		    this.splitContainer2.Panel2.SuspendLayout();
		    this.splitContainer2.SuspendLayout();
		    ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
		    this.splitContainer3.Panel1.SuspendLayout();
		    this.splitContainer3.Panel2.SuspendLayout();
		    this.splitContainer3.SuspendLayout();
		    this.panel1.SuspendLayout();
		    this.menuStrip1.SuspendLayout();
		    this.SuspendLayout();
		    // 
		    // txtGgpkPath
		    // 
		    this.txtGgpkPath.Location = new System.Drawing.Point(16, 37);
		    this.txtGgpkPath.Name = "txtGgpkPath";
		    this.txtGgpkPath.Size = new System.Drawing.Size(700, 22);
		    this.txtGgpkPath.TabIndex = 0;
		    this.txtGgpkPath.TextChanged += new System.EventHandler(this.TxtGgpkPathTextChanged);
		    // 
		    // lbl1
		    // 
		    this.lbl1.AutoSize = true;
		    this.lbl1.Location = new System.Drawing.Point(16, 15);
		    this.lbl1.Name = "lbl1";
		    this.lbl1.Size = new System.Drawing.Size(145, 17);
		    this.lbl1.TabIndex = 2;
		    this.lbl1.Text = "Path to Content.ggpk:";
		    // 
		    // butNullParticles
		    // 
		    this.butNullParticles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
		    this.butNullParticles.Location = new System.Drawing.Point(472, 90);
		    this.butNullParticles.Name = "butNullParticles";
		    this.butNullParticles.Size = new System.Drawing.Size(128, 64);
		    this.butNullParticles.TabIndex = 5;
		    this.butNullParticles.Text = "Null\r\nParticles...";
		    this.butNullParticles.UseVisualStyleBackColor = true;
		    this.butNullParticles.Click += new System.EventHandler(this.butNullParticlesClick);
		    // 
		    // openGgpkDlg
		    // 
		    this.openGgpkDlg.FileName = "Content.ggpk";
		    this.openGgpkDlg.Filter = "ggpk|*.ggpk|All files|*.*";
		    // 
		    // butLocateGgpk
		    // 
		    this.butLocateGgpk.Location = new System.Drawing.Point(733, 37);
		    this.butLocateGgpk.Name = "butLocateGgpk";
		    this.butLocateGgpk.Size = new System.Drawing.Size(64, 22);
		    this.butLocateGgpk.TabIndex = 1;
		    this.butLocateGgpk.Text = "...";
		    this.butLocateGgpk.UseVisualStyleBackColor = true;
		    this.butLocateGgpk.Click += new System.EventHandler(this.ButLocateGgpkClick);
		    // 
		    // butDisableShadows
		    // 
		    this.butDisableShadows.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
		    this.butDisableShadows.Location = new System.Drawing.Point(322, 90);
		    this.butDisableShadows.Name = "butDisableShadows";
		    this.butDisableShadows.Size = new System.Drawing.Size(128, 32);
		    this.butDisableShadows.TabIndex = 6;
		    this.butDisableShadows.Text = "Disable";
		    this.butDisableShadows.UseVisualStyleBackColor = true;
		    this.butDisableShadows.Click += new System.EventHandler(this.butDisableShadowsClick);
		    // 
		    // butOpenGgpk
		    // 
		    this.butOpenGgpk.Enabled = false;
		    this.butOpenGgpk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
		    this.butOpenGgpk.Location = new System.Drawing.Point(318, 69);
		    this.butOpenGgpk.Name = "butOpenGgpk";
		    this.butOpenGgpk.Size = new System.Drawing.Size(196, 64);
		    this.butOpenGgpk.TabIndex = 2;
		    this.butOpenGgpk.Text = "Open";
		    this.butOpenGgpk.UseVisualStyleBackColor = true;
		    this.butOpenGgpk.Click += new System.EventHandler(this.ButOpenGgpkClick);
		    // 
		    // butSavePets
		    // 
		    this.butSavePets.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
		    this.butSavePets.Location = new System.Drawing.Point(172, 90);
		    this.butSavePets.Name = "butSavePets";
		    this.butSavePets.Size = new System.Drawing.Size(128, 64);
		    this.butSavePets.TabIndex = 3;
		    this.butSavePets.Text = "Save Backup...";
		    this.butSavePets.UseVisualStyleBackColor = true;
		    this.butSavePets.Click += new System.EventHandler(this.ButSavePetsClick);
		    // 
		    // saveBackupDlg
		    // 
		    this.saveBackupDlg.FileName = "backup";
		    // 
		    // butLoadPets
		    // 
		    this.butLoadPets.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
		    this.butLoadPets.Location = new System.Drawing.Point(52, 90);
		    this.butLoadPets.Name = "butLoadPets";
		    this.butLoadPets.Size = new System.Drawing.Size(128, 64);
		    this.butLoadPets.TabIndex = 4;
		    this.butLoadPets.Text = "Load Backup...";
		    this.butLoadPets.UseVisualStyleBackColor = true;
		    this.butLoadPets.Click += new System.EventHandler(this.butLoadBackupClick);
		    // 
		    // loadBackupDlg
		    // 
		    this.loadBackupDlg.FileName = "backupInfo.dat";
		    this.loadBackupDlg.Filter = "backup dat files|*dat|All files|*.*";
		    // 
		    // txtLog
		    // 
		    this.txtLog.Dock = System.Windows.Forms.DockStyle.Fill;
		    this.txtLog.Location = new System.Drawing.Point(0, 0);
		    this.txtLog.Multiline = true;
		    this.txtLog.Name = "txtLog";
		    this.txtLog.ReadOnly = true;
		    this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
		    this.txtLog.Size = new System.Drawing.Size(671, 104);
		    this.txtLog.TabIndex = 100;
		    this.txtLog.TabStop = false;
		    this.txtLog.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtLogKeyDown);
		    // 
		    // butSayThanks
		    // 
		    this.butSayThanks.Dock = System.Windows.Forms.DockStyle.Right;
		    this.butSayThanks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
		    this.butSayThanks.Location = new System.Drawing.Point(9, 0);
		    this.butSayThanks.Name = "butSayThanks";
		    this.butSayThanks.Size = new System.Drawing.Size(128, 100);
		    this.butSayThanks.TabIndex = 101;
		    this.butSayThanks.TabStop = false;
		    this.butSayThanks.Text = "Say\r\nThanks...";
		    this.butSayThanks.UseVisualStyleBackColor = true;
		    this.butSayThanks.Click += new System.EventHandler(this.ButSayThanksClick);
		    // 
		    // tabActions
		    // 
		    this.tabActions.Controls.Add(this.tabPage2);
		    this.tabActions.Controls.Add(this.tabCheckList);
		    this.tabActions.Controls.Add(this.tabParticles);
		    this.tabActions.Controls.Add(this.tabEffects);
		    this.tabActions.Controls.Add(this.tabMisc);
		    this.tabActions.Dock = System.Windows.Forms.DockStyle.Fill;
		    this.tabActions.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
		    this.tabActions.Location = new System.Drawing.Point(0, 0);
		    this.tabActions.Name = "tabActions";
		    this.tabActions.SelectedIndex = 0;
		    this.tabActions.Size = new System.Drawing.Size(812, 310);
		    this.tabActions.TabIndex = 0;
		    this.tabActions.Visible = false;
		    this.tabActions.SelectedIndexChanged += new System.EventHandler(this.TabActionsSelectedIndexChanged);
		    // 
		    // tabPage2
		    // 
		    this.tabPage2.Controls.Add(this.label2);
		    this.tabPage2.Controls.Add(this.label1);
		    this.tabPage2.Controls.Add(this.makeGoodTrack);
		    this.tabPage2.Controls.Add(this.butMakeGood);
		    this.tabPage2.Location = new System.Drawing.Point(4, 25);
		    this.tabPage2.Name = "tabPage2";
		    this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
		    this.tabPage2.Size = new System.Drawing.Size(804, 281);
		    this.tabPage2.TabIndex = 4;
		    this.tabPage2.Text = "Casual Mode";
		    this.tabPage2.UseVisualStyleBackColor = true;
		    // 
		    // label2
		    // 
		    this.label2.AutoSize = true;
		    this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
		    this.label2.Location = new System.Drawing.Point(575, 68);
		    this.label2.Name = "label2";
		    this.label2.Size = new System.Drawing.Size(105, 72);
		    this.label2.TabIndex = 6;
		    this.label2.Text = "Max\r\nEffects\r\n";
		    this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
		    // 
		    // label1
		    // 
		    this.label1.AutoSize = true;
		    this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
		    this.label1.Location = new System.Drawing.Point(104, 68);
		    this.label1.Name = "label1";
		    this.label1.Size = new System.Drawing.Size(73, 72);
		    this.label1.TabIndex = 5;
		    this.label1.Text = "Max\r\nFPS";
		    this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
		    // 
		    // makeGoodTrack
		    // 
		    this.makeGoodTrack.BackColor = System.Drawing.SystemColors.ControlLightLight;
		    this.makeGoodTrack.LargeChange = 1;
		    this.makeGoodTrack.Location = new System.Drawing.Point(183, 81);
		    this.makeGoodTrack.Maximum = 6;
		    this.makeGoodTrack.Minimum = 1;
		    this.makeGoodTrack.Name = "makeGoodTrack";
		    this.makeGoodTrack.Size = new System.Drawing.Size(386, 56);
		    this.makeGoodTrack.TabIndex = 4;
		    this.makeGoodTrack.TickStyle = System.Windows.Forms.TickStyle.Both;
		    this.makeGoodTrack.Value = 1;
		    this.makeGoodTrack.ValueChanged += new System.EventHandler(this.MakeGoodTrackValueChanged);
		    // 
		    // butMakeGood
		    // 
		    this.butMakeGood.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
		    this.butMakeGood.Location = new System.Drawing.Point(298, 181);
		    this.butMakeGood.Name = "butMakeGood";
		    this.butMakeGood.Size = new System.Drawing.Size(196, 64);
		    this.butMakeGood.TabIndex = 3;
		    this.butMakeGood.Text = "Make Good";
		    this.butMakeGood.UseVisualStyleBackColor = true;
		    this.butMakeGood.Click += new System.EventHandler(this.ButMakeGoodClick);
		    // 
		    // tabCheckList
		    // 
		    this.tabCheckList.Controls.Add(this.splitContainerCheckList);
		    this.tabCheckList.Location = new System.Drawing.Point(4, 25);
		    this.tabCheckList.Name = "tabCheckList";
		    this.tabCheckList.Size = new System.Drawing.Size(804, 281);
		    this.tabCheckList.TabIndex = 5;
		    this.tabCheckList.Text = "Check List";
		    this.tabCheckList.UseVisualStyleBackColor = true;
		    // 
		    // splitContainerCheckList
		    // 
		    this.splitContainerCheckList.Dock = System.Windows.Forms.DockStyle.Fill;
		    this.splitContainerCheckList.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
		    this.splitContainerCheckList.Location = new System.Drawing.Point(0, 0);
		    this.splitContainerCheckList.Name = "splitContainerCheckList";
		    this.splitContainerCheckList.Orientation = System.Windows.Forms.Orientation.Horizontal;
		    // 
		    // splitContainerCheckList.Panel1
		    // 
		    this.splitContainerCheckList.Panel1.Controls.Add(this.lstCheckList);
		    // 
		    // splitContainerCheckList.Panel2
		    // 
		    this.splitContainerCheckList.Panel2.Controls.Add(this.butCheckListFindSkill);
		    this.splitContainerCheckList.Panel2.Controls.Add(this.txtCheckListFilter);
		    this.splitContainerCheckList.Panel2.Controls.Add(this.butCheckListDisable);
		    this.splitContainerCheckList.Panel2.Controls.Add(this.butCheckListEnable);
		    this.splitContainerCheckList.Panel2.Controls.Add(this.butCheckListSelectAll);
		    this.splitContainerCheckList.Panel2.Controls.Add(this.butCheckListUpdate);
		    this.splitContainerCheckList.Size = new System.Drawing.Size(804, 281);
		    this.splitContainerCheckList.SplitterDistance = 234;
		    this.splitContainerCheckList.TabIndex = 0;
		    // 
		    // lstCheckList
		    // 
		    this.lstCheckList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colEmitters,
            this.colFile});
		    this.lstCheckList.Dock = System.Windows.Forms.DockStyle.Fill;
		    this.lstCheckList.Location = new System.Drawing.Point(0, 0);
		    this.lstCheckList.Name = "lstCheckList";
		    this.lstCheckList.Size = new System.Drawing.Size(804, 234);
		    this.lstCheckList.TabIndex = 0;
		    this.lstCheckList.UseCompatibleStateImageBehavior = false;
		    this.lstCheckList.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.LstCheckListColumnClick);
		    this.lstCheckList.SelectedIndexChanged += new System.EventHandler(this.LstCheckListSelectedIndexChanged);
		    this.lstCheckList.DoubleClick += new System.EventHandler(this.LstCheckListDoubleClick);
		    this.lstCheckList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LstCheckListKeyDown);
		    // 
		    // colEmitters
		    // 
		    this.colEmitters.Text = "emitters";
		    // 
		    // colFile
		    // 
		    this.colFile.Text = "file";
		    this.colFile.Width = 700;
		    // 
		    // butCheckListFindSkill
		    // 
		    this.butCheckListFindSkill.Location = new System.Drawing.Point(729, 11);
		    this.butCheckListFindSkill.Name = "butCheckListFindSkill";
		    this.butCheckListFindSkill.Size = new System.Drawing.Size(64, 22);
		    this.butCheckListFindSkill.TabIndex = 5;
		    this.butCheckListFindSkill.TabStop = false;
		    this.butCheckListFindSkill.Text = "...";
		    this.butCheckListFindSkill.UseVisualStyleBackColor = true;
		    this.butCheckListFindSkill.Click += new System.EventHandler(this.ButCheckListFindSkillClick);
		    // 
		    // txtCheckListFilter
		    // 
		    this.txtCheckListFilter.Location = new System.Drawing.Point(521, 11);
		    this.txtCheckListFilter.Name = "txtCheckListFilter";
		    this.txtCheckListFilter.Size = new System.Drawing.Size(204, 22);
		    this.txtCheckListFilter.TabIndex = 4;
		    this.txtCheckListFilter.Enter += new System.EventHandler(this.TxtCheckListFilterEnter);
		    this.txtCheckListFilter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtCheckListFilterKeyDown);
		    // 
		    // butCheckListDisable
		    // 
		    this.butCheckListDisable.Location = new System.Drawing.Point(388, 5);
		    this.butCheckListDisable.Name = "butCheckListDisable";
		    this.butCheckListDisable.Size = new System.Drawing.Size(128, 32);
		    this.butCheckListDisable.TabIndex = 3;
		    this.butCheckListDisable.TabStop = false;
		    this.butCheckListDisable.Text = "Disable";
		    this.butCheckListDisable.UseVisualStyleBackColor = true;
		    this.butCheckListDisable.Click += new System.EventHandler(this.ButCheckListDisableClick);
		    // 
		    // butCheckListEnable
		    // 
		    this.butCheckListEnable.Location = new System.Drawing.Point(259, 5);
		    this.butCheckListEnable.Name = "butCheckListEnable";
		    this.butCheckListEnable.Size = new System.Drawing.Size(128, 32);
		    this.butCheckListEnable.TabIndex = 2;
		    this.butCheckListEnable.TabStop = false;
		    this.butCheckListEnable.Text = "Enable";
		    this.butCheckListEnable.UseVisualStyleBackColor = true;
		    this.butCheckListEnable.Click += new System.EventHandler(this.ButCheckListEnableClick);
		    // 
		    // butCheckListSelectAll
		    // 
		    this.butCheckListSelectAll.Location = new System.Drawing.Point(130, 5);
		    this.butCheckListSelectAll.Name = "butCheckListSelectAll";
		    this.butCheckListSelectAll.Size = new System.Drawing.Size(128, 32);
		    this.butCheckListSelectAll.TabIndex = 1;
		    this.butCheckListSelectAll.TabStop = false;
		    this.butCheckListSelectAll.Text = "Select All";
		    this.butCheckListSelectAll.UseVisualStyleBackColor = true;
		    this.butCheckListSelectAll.Click += new System.EventHandler(this.ButCheckListSelectAllClick);
		    // 
		    // butCheckListUpdate
		    // 
		    this.butCheckListUpdate.Location = new System.Drawing.Point(1, 5);
		    this.butCheckListUpdate.Name = "butCheckListUpdate";
		    this.butCheckListUpdate.Size = new System.Drawing.Size(128, 32);
		    this.butCheckListUpdate.TabIndex = 0;
		    this.butCheckListUpdate.TabStop = false;
		    this.butCheckListUpdate.Text = "Update";
		    this.butCheckListUpdate.UseVisualStyleBackColor = true;
		    this.butCheckListUpdate.Click += new System.EventHandler(this.ButCheckListUpdateClick);
		    // 
		    // tabParticles
		    // 
		    this.tabParticles.Controls.Add(this.butSavePets);
		    this.tabParticles.Controls.Add(this.butNullParticles);
		    this.tabParticles.Location = new System.Drawing.Point(4, 25);
		    this.tabParticles.Name = "tabParticles";
		    this.tabParticles.Padding = new System.Windows.Forms.Padding(3);
		    this.tabParticles.Size = new System.Drawing.Size(804, 281);
		    this.tabParticles.TabIndex = 0;
		    this.tabParticles.Text = "Particles";
		    this.tabParticles.UseVisualStyleBackColor = true;
		    // 
		    // tabEffects
		    // 
		    this.tabEffects.Controls.Add(this.butCorpsesEnable);
		    this.tabEffects.Controls.Add(this.label4);
		    this.tabEffects.Controls.Add(this.label3);
		    this.tabEffects.Controls.Add(this.butEnableShadows);
		    this.tabEffects.Controls.Add(this.butNoDeadBodies);
		    this.tabEffects.Controls.Add(this.butSaveMisc);
		    this.tabEffects.Controls.Add(this.butDisableShadows);
		    this.tabEffects.Location = new System.Drawing.Point(4, 25);
		    this.tabEffects.Name = "tabEffects";
		    this.tabEffects.Padding = new System.Windows.Forms.Padding(3);
		    this.tabEffects.Size = new System.Drawing.Size(804, 281);
		    this.tabEffects.TabIndex = 2;
		    this.tabEffects.Text = "Effects";
		    this.tabEffects.UseVisualStyleBackColor = true;
		    // 
		    // butCorpsesEnable
		    // 
		    this.butCorpsesEnable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
		    this.butCorpsesEnable.Location = new System.Drawing.Point(592, 122);
		    this.butCorpsesEnable.Name = "butCorpsesEnable";
		    this.butCorpsesEnable.Size = new System.Drawing.Size(128, 32);
		    this.butCorpsesEnable.TabIndex = 13;
		    this.butCorpsesEnable.Text = "Enable";
		    this.butCorpsesEnable.UseVisualStyleBackColor = true;
		    this.butCorpsesEnable.Click += new System.EventHandler(this.ButCorpsesEnableClick);
		    // 
		    // label4
		    // 
		    this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
		    this.label4.Location = new System.Drawing.Point(606, 64);
		    this.label4.Name = "label4";
		    this.label4.Size = new System.Drawing.Size(100, 23);
		    this.label4.TabIndex = 12;
		    this.label4.Text = "Corpses:";
		    // 
		    // label3
		    // 
		    this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
		    this.label3.Location = new System.Drawing.Point(337, 64);
		    this.label3.Name = "label3";
		    this.label3.Size = new System.Drawing.Size(100, 23);
		    this.label3.TabIndex = 11;
		    this.label3.Text = "Shadows:";
		    // 
		    // butEnableShadows
		    // 
		    this.butEnableShadows.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
		    this.butEnableShadows.Location = new System.Drawing.Point(322, 122);
		    this.butEnableShadows.Name = "butEnableShadows";
		    this.butEnableShadows.Size = new System.Drawing.Size(128, 32);
		    this.butEnableShadows.TabIndex = 10;
		    this.butEnableShadows.Text = "Enable";
		    this.butEnableShadows.UseVisualStyleBackColor = true;
		    this.butEnableShadows.Click += new System.EventHandler(this.ButEnableShadowsClick);
		    // 
		    // butNoDeadBodies
		    // 
		    this.butNoDeadBodies.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
		    this.butNoDeadBodies.Location = new System.Drawing.Point(592, 90);
		    this.butNoDeadBodies.Name = "butNoDeadBodies";
		    this.butNoDeadBodies.Size = new System.Drawing.Size(128, 32);
		    this.butNoDeadBodies.TabIndex = 9;
		    this.butNoDeadBodies.Text = "Disable";
		    this.butNoDeadBodies.UseVisualStyleBackColor = true;
		    this.butNoDeadBodies.Click += new System.EventHandler(this.ButNoDeadBodiesClick);
		    // 
		    // butSaveMisc
		    // 
		    this.butSaveMisc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
		    this.butSaveMisc.Location = new System.Drawing.Point(52, 90);
		    this.butSaveMisc.Name = "butSaveMisc";
		    this.butSaveMisc.Size = new System.Drawing.Size(128, 64);
		    this.butSaveMisc.TabIndex = 7;
		    this.butSaveMisc.Text = "Save Backup...";
		    this.butSaveMisc.UseVisualStyleBackColor = true;
		    this.butSaveMisc.Click += new System.EventHandler(this.ButSaveMiscClick);
		    // 
		    // tabMisc
		    // 
		    this.tabMisc.Controls.Add(this.butLoadDir);
		    this.tabMisc.Controls.Add(this.butSearchInGgpk);
		    this.tabMisc.Controls.Add(this.butLoadPets);
		    this.tabMisc.Location = new System.Drawing.Point(4, 25);
		    this.tabMisc.Name = "tabMisc";
		    this.tabMisc.Padding = new System.Windows.Forms.Padding(3);
		    this.tabMisc.Size = new System.Drawing.Size(804, 281);
		    this.tabMisc.TabIndex = 3;
		    this.tabMisc.Text = "Misc";
		    this.tabMisc.UseVisualStyleBackColor = true;
		    // 
		    // butLoadDir
		    // 
		    this.butLoadDir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
		    this.butLoadDir.Location = new System.Drawing.Point(322, 90);
		    this.butLoadDir.Name = "butLoadDir";
		    this.butLoadDir.Size = new System.Drawing.Size(128, 64);
		    this.butLoadDir.TabIndex = 5;
		    this.butLoadDir.Text = "Load Directory...";
		    this.butLoadDir.UseVisualStyleBackColor = true;
		    this.butLoadDir.Click += new System.EventHandler(this.ButLoadDirClick);
		    // 
		    // butSearchInGgpk
		    // 
		    this.butSearchInGgpk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
		    this.butSearchInGgpk.Location = new System.Drawing.Point(592, 90);
		    this.butSearchInGgpk.Name = "butSearchInGgpk";
		    this.butSearchInGgpk.Size = new System.Drawing.Size(128, 64);
		    this.butSearchInGgpk.TabIndex = 6;
		    this.butSearchInGgpk.Text = "GGPK Search...";
		    this.butSearchInGgpk.UseVisualStyleBackColor = true;
		    this.butSearchInGgpk.Click += new System.EventHandler(this.ButSearchInGgpkClick);
		    // 
		    // lblWait
		    // 
		    this.lblWait.AutoSize = true;
		    this.lblWait.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
		    this.lblWait.Location = new System.Drawing.Point(1, 1);
		    this.lblWait.Name = "lblWait";
		    this.lblWait.Size = new System.Drawing.Size(75, 36);
		    this.lblWait.TabIndex = 102;
		    this.lblWait.Text = "Wait";
		    this.lblWait.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		    this.lblWait.Visible = false;
		    // 
		    // splitContainer1
		    // 
		    this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
		    this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
		    this.splitContainer1.IsSplitterFixed = true;
		    this.splitContainer1.Location = new System.Drawing.Point(0, 28);
		    this.splitContainer1.Name = "splitContainer1";
		    this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
		    // 
		    // splitContainer1.Panel1
		    // 
		    this.splitContainer1.Panel1.Controls.Add(this.lbl1);
		    this.splitContainer1.Panel1.Controls.Add(this.txtGgpkPath);
		    this.splitContainer1.Panel1.Controls.Add(this.butLocateGgpk);
		    this.splitContainer1.Panel1.Controls.Add(this.butOpenGgpk);
		    // 
		    // splitContainer1.Panel2
		    // 
		    this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
		    this.splitContainer1.Size = new System.Drawing.Size(812, 567);
		    this.splitContainer1.SplitterDistance = 145;
		    this.splitContainer1.TabIndex = 104;
		    // 
		    // splitContainer2
		    // 
		    this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
		    this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
		    this.splitContainer2.Location = new System.Drawing.Point(0, 0);
		    this.splitContainer2.Name = "splitContainer2";
		    this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
		    // 
		    // splitContainer2.Panel1
		    // 
		    this.splitContainer2.Panel1.Controls.Add(this.tabActions);
		    this.splitContainer2.Panel1.Controls.Add(this.lblWait);
		    // 
		    // splitContainer2.Panel2
		    // 
		    this.splitContainer2.Panel2.Controls.Add(this.splitContainer3);
		    this.splitContainer2.Size = new System.Drawing.Size(812, 418);
		    this.splitContainer2.SplitterDistance = 310;
		    this.splitContainer2.TabIndex = 0;
		    // 
		    // splitContainer3
		    // 
		    this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
		    this.splitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
		    this.splitContainer3.IsSplitterFixed = true;
		    this.splitContainer3.Location = new System.Drawing.Point(0, 0);
		    this.splitContainer3.Name = "splitContainer3";
		    // 
		    // splitContainer3.Panel1
		    // 
		    this.splitContainer3.Panel1.Controls.Add(this.txtLog);
		    // 
		    // splitContainer3.Panel2
		    // 
		    this.splitContainer3.Panel2.Controls.Add(this.panel1);
		    this.splitContainer3.Size = new System.Drawing.Size(812, 104);
		    this.splitContainer3.SplitterDistance = 671;
		    this.splitContainer3.TabIndex = 0;
		    // 
		    // panel1
		    // 
		    this.panel1.Controls.Add(this.butSayThanks);
		    this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
		    this.panel1.Location = new System.Drawing.Point(0, 4);
		    this.panel1.Name = "panel1";
		    this.panel1.Size = new System.Drawing.Size(137, 100);
		    this.panel1.TabIndex = 102;
		    // 
		    // menuStrip1
		    // 
		    this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
		    this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
		    this.menuStrip1.Location = new System.Drawing.Point(0, 0);
		    this.menuStrip1.Name = "menuStrip1";
		    this.menuStrip1.Size = new System.Drawing.Size(812, 28);
		    this.menuStrip1.TabIndex = 105;
		    this.menuStrip1.Text = "menuStrip1";
		    // 
		    // menuToolStripMenuItem
		    // 
		    this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuStopCurrentTask,
            this.mnuDontOpen,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
		    this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
		    this.menuToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
		    this.menuToolStripMenuItem.Text = "Menu";
		    // 
		    // mnuStopCurrentTask
		    // 
		    this.mnuStopCurrentTask.Name = "mnuStopCurrentTask";
		    this.mnuStopCurrentTask.Size = new System.Drawing.Size(195, 26);
		    this.mnuStopCurrentTask.Text = "Stop current task";
		    this.mnuStopCurrentTask.Click += new System.EventHandler(this.MnuStopCurrentTaskClick);
		    // 
		    // mnuDontOpen
		    // 
		    this.mnuDontOpen.Name = "mnuDontOpen";
		    this.mnuDontOpen.Size = new System.Drawing.Size(195, 26);
		    this.mnuDontOpen.Text = "Don\'t Open";
		    this.mnuDontOpen.Click += new System.EventHandler(this.MnuDontOpenClick);
		    // 
		    // toolStripSeparator1
		    // 
		    this.toolStripSeparator1.Name = "toolStripSeparator1";
		    this.toolStripSeparator1.Size = new System.Drawing.Size(192, 6);
		    // 
		    // exitToolStripMenuItem
		    // 
		    this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
		    this.exitToolStripMenuItem.Size = new System.Drawing.Size(195, 26);
		    this.exitToolStripMenuItem.Text = "Exit";
		    this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItemClick);
		    // 
		    // MainForm
		    // 
		    this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		    this.ClientSize = new System.Drawing.Size(812, 595);
		    this.Controls.Add(this.splitContainer1);
		    this.Controls.Add(this.menuStrip1);
		    this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
		    this.MinimumSize = new System.Drawing.Size(780, 580);
		    this.Name = "MainForm";
		    this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		    this.Text = "poeNullEffects";
		    this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFormFormClosing);
		    this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainFormFormClosed);
		    this.Load += new System.EventHandler(this.MainFormLoad);
		    this.tabActions.ResumeLayout(false);
		    this.tabPage2.ResumeLayout(false);
		    this.tabPage2.PerformLayout();
		    ((System.ComponentModel.ISupportInitialize)(this.makeGoodTrack)).EndInit();
		    this.tabCheckList.ResumeLayout(false);
		    this.splitContainerCheckList.Panel1.ResumeLayout(false);
		    this.splitContainerCheckList.Panel2.ResumeLayout(false);
		    this.splitContainerCheckList.Panel2.PerformLayout();
		    ((System.ComponentModel.ISupportInitialize)(this.splitContainerCheckList)).EndInit();
		    this.splitContainerCheckList.ResumeLayout(false);
		    this.tabParticles.ResumeLayout(false);
		    this.tabEffects.ResumeLayout(false);
		    this.tabMisc.ResumeLayout(false);
		    this.splitContainer1.Panel1.ResumeLayout(false);
		    this.splitContainer1.Panel1.PerformLayout();
		    this.splitContainer1.Panel2.ResumeLayout(false);
		    ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
		    this.splitContainer1.ResumeLayout(false);
		    this.splitContainer2.Panel1.ResumeLayout(false);
		    this.splitContainer2.Panel1.PerformLayout();
		    this.splitContainer2.Panel2.ResumeLayout(false);
		    ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
		    this.splitContainer2.ResumeLayout(false);
		    this.splitContainer3.Panel1.ResumeLayout(false);
		    this.splitContainer3.Panel1.PerformLayout();
		    this.splitContainer3.Panel2.ResumeLayout(false);
		    ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
		    this.splitContainer3.ResumeLayout(false);
		    this.panel1.ResumeLayout(false);
		    this.menuStrip1.ResumeLayout(false);
		    this.menuStrip1.PerformLayout();
		    this.ResumeLayout(false);
		    this.PerformLayout();

		}
	}
}
