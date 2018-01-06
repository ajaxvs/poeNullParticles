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
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.Button butNoDeadBodies;
		private System.Windows.Forms.Button butSaveMisc;
		private System.Windows.Forms.TabPage tabPage4;
		private System.Windows.Forms.Button butSearchInGgpk;
		private System.Windows.Forms.Button butLoadDir;
		private System.Windows.Forms.Button butRemoveSpellMeshes;
		private System.Windows.Forms.Button butRemoveAocParticles;
		private System.Windows.Forms.Button butNullEpk;
		
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
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.butNoDeadBodies = new System.Windows.Forms.Button();
			this.butSaveMisc = new System.Windows.Forms.Button();
			this.tabPage4 = new System.Windows.Forms.TabPage();
			this.butRemoveSpellMeshes = new System.Windows.Forms.Button();
			this.butRemoveAocParticles = new System.Windows.Forms.Button();
			this.butNullEpk = new System.Windows.Forms.Button();
			this.butLoadDir = new System.Windows.Forms.Button();
			this.butSearchInGgpk = new System.Windows.Forms.Button();
			this.tabActions.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage3.SuspendLayout();
			this.tabPage4.SuspendLayout();
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
			this.tabActions.Controls.Add(this.tabPage1);
			this.tabActions.Controls.Add(this.tabPage3);
			this.tabActions.Controls.Add(this.tabPage4);
			this.tabActions.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tabActions.Location = new System.Drawing.Point(10, 134);
			this.tabActions.Name = "tabActions";
			this.tabActions.SelectedIndex = 0;
			this.tabActions.Size = new System.Drawing.Size(780, 285);
			this.tabActions.TabIndex = 0;
			this.tabActions.Visible = false;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.butSavePets);
			this.tabPage1.Controls.Add(this.butNullParticles);
			this.tabPage1.Location = new System.Drawing.Point(4, 25);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(772, 256);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Particles";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// tabPage3
			// 
			this.tabPage3.Controls.Add(this.butNoDeadBodies);
			this.tabPage3.Controls.Add(this.butSaveMisc);
			this.tabPage3.Controls.Add(this.butDisableShadows);
			this.tabPage3.Location = new System.Drawing.Point(4, 25);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage3.Size = new System.Drawing.Size(772, 256);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "Effects";
			this.tabPage3.UseVisualStyleBackColor = true;
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
			// tabPage4
			// 
			this.tabPage4.Controls.Add(this.butRemoveSpellMeshes);
			this.tabPage4.Controls.Add(this.butRemoveAocParticles);
			this.tabPage4.Controls.Add(this.butNullEpk);
			this.tabPage4.Controls.Add(this.butLoadDir);
			this.tabPage4.Controls.Add(this.butSearchInGgpk);
			this.tabPage4.Controls.Add(this.butLoadPets);
			this.tabPage4.Location = new System.Drawing.Point(4, 25);
			this.tabPage4.Name = "tabPage4";
			this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage4.Size = new System.Drawing.Size(772, 256);
			this.tabPage4.TabIndex = 3;
			this.tabPage4.Text = "Misc";
			this.tabPage4.UseVisualStyleBackColor = true;
			// 
			// butRemoveSpellMeshes
			// 
			this.butRemoveSpellMeshes.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.butRemoveSpellMeshes.Location = new System.Drawing.Point(592, 149);
			this.butRemoveSpellMeshes.Name = "butRemoveSpellMeshes";
			this.butRemoveSpellMeshes.Size = new System.Drawing.Size(128, 64);
			this.butRemoveSpellMeshes.TabIndex = 9;
			this.butRemoveSpellMeshes.Text = "Remove\r\nSpell Meshes...";
			this.butRemoveSpellMeshes.UseVisualStyleBackColor = true;
			this.butRemoveSpellMeshes.Visible = false;
			this.butRemoveSpellMeshes.Click += new System.EventHandler(this.ButRemoveSpellMeshesClick);
			// 
			// butRemoveAocParticles
			// 
			this.butRemoveAocParticles.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.butRemoveAocParticles.Location = new System.Drawing.Point(322, 149);
			this.butRemoveAocParticles.Name = "butRemoveAocParticles";
			this.butRemoveAocParticles.Size = new System.Drawing.Size(128, 64);
			this.butRemoveAocParticles.TabIndex = 8;
			this.butRemoveAocParticles.Text = "Remove \r\n.aoc Particles...";
			this.butRemoveAocParticles.UseVisualStyleBackColor = true;
			this.butRemoveAocParticles.Visible = false;
			this.butRemoveAocParticles.Click += new System.EventHandler(this.ButRemoveAocParticlesClick);
			// 
			// butNullEpk
			// 
			this.butNullEpk.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.butNullEpk.Location = new System.Drawing.Point(52, 149);
			this.butNullEpk.Name = "butNullEpk";
			this.butNullEpk.Size = new System.Drawing.Size(128, 64);
			this.butNullEpk.TabIndex = 7;
			this.butNullEpk.Text = "Remove\r\n.epk Particles...";
			this.butNullEpk.UseVisualStyleBackColor = true;
			this.butNullEpk.Visible = false;
			this.butNullEpk.Click += new System.EventHandler(this.ButNullEpkClick);
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
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(802, 555);
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
			this.tabPage1.ResumeLayout(false);
			this.tabPage3.ResumeLayout(false);
			this.tabPage4.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
