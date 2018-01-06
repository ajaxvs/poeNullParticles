/*
 * User: ajaxvs
 * Date: 03.01.2018
 * Time: 18:15
 */
namespace poeNullEffects
{
	partial class frmInputBox
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label lblText;
		private System.Windows.Forms.TextBox txtValue;
		private System.Windows.Forms.Button butOK;
		private System.Windows.Forms.Button butCancel;
		
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
			this.lblText = new System.Windows.Forms.Label();
			this.txtValue = new System.Windows.Forms.TextBox();
			this.butOK = new System.Windows.Forms.Button();
			this.butCancel = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblText
			// 
			this.lblText.Location = new System.Drawing.Point(12, 12);
			this.lblText.Name = "lblText";
			this.lblText.Size = new System.Drawing.Size(657, 41);
			this.lblText.TabIndex = 0;
			this.lblText.Text = "Input:\r\n";
			// 
			// txtValue
			// 
			this.txtValue.Location = new System.Drawing.Point(12, 59);
			this.txtValue.Name = "txtValue";
			this.txtValue.Size = new System.Drawing.Size(658, 22);
			this.txtValue.TabIndex = 1;
			// 
			// butOK
			// 
			this.butOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.butOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.butOK.Location = new System.Drawing.Point(541, 99);
			this.butOK.Name = "butOK";
			this.butOK.Size = new System.Drawing.Size(128, 64);
			this.butOK.TabIndex = 2;
			this.butOK.Text = "OK";
			this.butOK.UseVisualStyleBackColor = true;
			this.butOK.Click += new System.EventHandler(this.ButOKClick);
			// 
			// butCancel
			// 
			this.butCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.butCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.butCancel.Location = new System.Drawing.Point(12, 99);
			this.butCancel.Name = "butCancel";
			this.butCancel.Size = new System.Drawing.Size(128, 64);
			this.butCancel.TabIndex = 3;
			this.butCancel.Text = "Cancel";
			this.butCancel.UseVisualStyleBackColor = true;
			// 
			// frmInputBox
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(682, 175);
			this.Controls.Add(this.butCancel);
			this.Controls.Add(this.butOK);
			this.Controls.Add(this.txtValue);
			this.Controls.Add(this.lblText);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmInputBox";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Input Box";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
