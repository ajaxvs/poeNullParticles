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
		    this.tabParticles = new System.Windows.Forms.TabPage();
		    this.tabEffects = new System.Windows.Forms.TabPage();
		    this.butNoDeadBodies = new System.Windows.Forms.Button();
		    this.butSaveMisc = new System.Windows.Forms.Button();
		    this.tabMisc = new System.Windows.Forms.TabPage();
		    this.butLoadDir = new System.Windows.Forms.Button();
		    this.butSearchInGgpk = new System.Windows.Forms.Button();
		    this.lblWait = new System.Windows.Forms.Label();
		    this.tabActions.SuspendLayout();
		    this.tabPage2.SuspendLayout();
		    ((System.ComponentModel.ISupportInitialize)(this.makeGoodTrack)).BeginInit();
		    this.tabParticles.SuspendLayout();
		    this.tabEffects.SuspendLayout();
		    this.tabMisc.SuspendLayout();
		    this.SuspendLayout();
		    // 
		    // txtGgpkPath
		    // 
		    this.txtGgpkPath.Location = new System.Drawing.Point(10, 32);
		    this.txtGgpkPath.Name = "txtGgpkPath";
		    this.txtGgpkPath.Size = new System.Drawing.Size(700, 22);
		    this.txtGgpkPath.TabIndex = 0;
		    this.txtGgpkPath.TextChanged += new System.EventHandler(this.TxtGgpkPathTextChanged);
		    // 
		    // lbl1
		    // 
		    this.lbl1.AutoSize = true;
		    this.lbl1.Location = new System.Drawing.Point(10, 10);
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
		    this.butLocateGgpk.Location = new System.Drawing.Point(727, 32);
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
		    this.butDisableShadows.Size = new System.Drawing.Size(128, 64);
		    this.butDisableShadows.TabIndex = 6;
		    this.butDisableShadows.Text = "Disable Shadows";
		    this.butDisableShadows.UseVisualStyleBackColor = true;
		    this.butDisableShadows.Click += new System.EventHandler(this.butDisableShadowsClick);
		    // 
		    // butOpenGgpk
		    // 
		    this.butOpenGgpk.Enabled = false;
		    this.butOpenGgpk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
		    this.butOpenGgpk.Location = new System.Drawing.Point(312, 64);
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
		    this.txtLog.Location = new System.Drawing.Point(10, 450);
		    this.txtLog.Multiline = true;
		    this.txtLog.Name = "txtLog";
		    this.txtLog.ReadOnly = true;
		    this.txtLog.Size = new System.Drawing.Size(604, 100);
		    this.txtLog.TabIndex = 100;
		    this.txtLog.TabStop = false;
		    this.txtLog.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtLogKeyDown);
		    // 
		    // butSayThanks
		    // 
		    this.butSayThanks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
		    this.butSayThanks.Location = new System.Drawing.Point(663, 450);
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
		    this.tabActions.Controls.Add(this.tabParticles);
		    this.tabActions.Controls.Add(this.tabEffects);
		    this.tabActions.Controls.Add(this.tabMisc);
		    this.tabActions.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
		    this.tabActions.Location = new System.Drawing.Point(10, 134);
		    this.tabActions.Name = "tabActions";
		    this.tabActions.SelectedIndex = 0;
		    this.tabActions.Size = new System.Drawing.Size(780, 285);
		    this.tabActions.TabIndex = 0;
		    this.tabActions.Visible = false;
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
		    this.tabPage2.Size = new System.Drawing.Size(772, 256);
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
		    // tabParticles
		    // 
		    this.tabParticles.Controls.Add(this.butSavePets);
		    this.tabParticles.Controls.Add(this.butNullParticles);
		    this.tabParticles.Location = new System.Drawing.Point(4, 25);
		    this.tabParticles.Name = "tabParticles";
		    this.tabParticles.Padding = new System.Windows.Forms.Padding(3);
		    this.tabParticles.Size = new System.Drawing.Size(772, 256);
		    this.tabParticles.TabIndex = 0;
		    this.tabParticles.Text = "Particles";
		    this.tabParticles.UseVisualStyleBackColor = true;
		    // 
		    // tabEffects
		    // 
		    this.tabEffects.Controls.Add(this.butNoDeadBodies);
		    this.tabEffects.Controls.Add(this.butSaveMisc);
		    this.tabEffects.Controls.Add(this.butDisableShadows);
		    this.tabEffects.Location = new System.Drawing.Point(4, 25);
		    this.tabEffects.Name = "tabEffects";
		    this.tabEffects.Padding = new System.Windows.Forms.Padding(3);
		    this.tabEffects.Size = new System.Drawing.Size(772, 256);
		    this.tabEffects.TabIndex = 2;
		    this.tabEffects.Text = "Effects";
		    this.tabEffects.UseVisualStyleBackColor = true;
		    // 
		    // butNoDeadBodies
		    // 
		    this.butNoDeadBodies.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
		    this.butNoDeadBodies.Location = new System.Drawing.Point(592, 90);
		    this.butNoDeadBodies.Name = "butNoDeadBodies";
		    this.butNoDeadBodies.Size = new System.Drawing.Size(128, 64);
		    this.butNoDeadBodies.TabIndex = 9;
		    this.butNoDeadBodies.Text = "No Dead Bodies";
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
		    this.tabMisc.Size = new System.Drawing.Size(772, 256);
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
		    this.lblWait.Location = new System.Drawing.Point(0, 75);
		    this.lblWait.Name = "lblWait";
		    this.lblWait.Size = new System.Drawing.Size(75, 36);
		    this.lblWait.TabIndex = 102;
		    this.lblWait.Text = "Wait";
		    this.lblWait.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		    this.lblWait.Visible = false;
		    // 
		    // MainForm
		    // 
		    this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
		    this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		    this.ClientSize = new System.Drawing.Size(802, 555);
		    this.Controls.Add(this.lblWait);
		    this.Controls.Add(this.tabActions);
		    this.Controls.Add(this.butSayThanks);
		    this.Controls.Add(this.txtLog);
		    this.Controls.Add(this.butOpenGgpk);
		    this.Controls.Add(this.butLocateGgpk);
		    this.Controls.Add(this.lbl1);
		    this.Controls.Add(this.txtGgpkPath);
		    this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
		    this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
		    this.MaximizeBox = false;
		    this.Name = "MainForm";
		    this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		    this.Text = "poeNullEffects";
		    this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainFormFormClosed);
		    this.Load += new System.EventHandler(this.MainFormLoad);
		    this.tabActions.ResumeLayout(false);
		    this.tabPage2.ResumeLayout(false);
		    this.tabPage2.PerformLayout();
		    ((System.ComponentModel.ISupportInitialize)(this.makeGoodTrack)).EndInit();
		    this.tabParticles.ResumeLayout(false);
		    this.tabEffects.ResumeLayout(false);
		    this.tabMisc.ResumeLayout(false);
		    this.ResumeLayout(false);
		    this.PerformLayout();

		}
	}
}
