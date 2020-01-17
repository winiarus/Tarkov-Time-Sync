namespace Tarkov_Time_Sync
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnReset = new System.Windows.Forms.Button();
			this.lblDisplay = new System.Windows.Forms.Label();
			this.btnPlusMs = new System.Windows.Forms.Button();
			this.btnMinusMs = new System.Windows.Forms.Button();
			this.btnMinusSec = new System.Windows.Forms.Button();
			this.btnPlusSec = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnReset
			// 
			this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnReset.Location = new System.Drawing.Point(12, 72);
			this.btnReset.Name = "btnReset";
			this.btnReset.Size = new System.Drawing.Size(206, 36);
			this.btnReset.TabIndex = 2;
			this.btnReset.Text = "Reset";
			this.btnReset.UseVisualStyleBackColor = true;
			this.btnReset.Click += new System.EventHandler(this.BtnReset_Click);
			// 
			// lblDisplay
			// 
			this.lblDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDisplay.Location = new System.Drawing.Point(74, 12);
			this.lblDisplay.Name = "lblDisplay";
			this.lblDisplay.Size = new System.Drawing.Size(82, 54);
			this.lblDisplay.TabIndex = 3;
			this.lblDisplay.Text = "0 ms";
			this.lblDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnPlusMs
			// 
			this.btnPlusMs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnPlusMs.Location = new System.Drawing.Point(162, 12);
			this.btnPlusMs.Name = "btnPlusMs";
			this.btnPlusMs.Size = new System.Drawing.Size(56, 24);
			this.btnPlusMs.TabIndex = 1;
			this.btnPlusMs.Text = "+ ms";
			this.btnPlusMs.UseVisualStyleBackColor = true;
			this.btnPlusMs.Click += new System.EventHandler(this.BtnPlusMs_Click);
			// 
			// btnMinusMs
			// 
			this.btnMinusMs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnMinusMs.Location = new System.Drawing.Point(12, 12);
			this.btnMinusMs.Name = "btnMinusMs";
			this.btnMinusMs.Size = new System.Drawing.Size(56, 24);
			this.btnMinusMs.TabIndex = 0;
			this.btnMinusMs.Text = "- ms";
			this.btnMinusMs.UseVisualStyleBackColor = true;
			this.btnMinusMs.Click += new System.EventHandler(this.BtnMinusMs_Click);
			// 
			// btnMinusSec
			// 
			this.btnMinusSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnMinusSec.Location = new System.Drawing.Point(12, 42);
			this.btnMinusSec.Name = "btnMinusSec";
			this.btnMinusSec.Size = new System.Drawing.Size(56, 24);
			this.btnMinusSec.TabIndex = 4;
			this.btnMinusSec.Text = "- sec";
			this.btnMinusSec.UseVisualStyleBackColor = true;
			this.btnMinusSec.Click += new System.EventHandler(this.BtnMinusSec_Click);
			// 
			// btnPlusSec
			// 
			this.btnPlusSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnPlusSec.Location = new System.Drawing.Point(162, 42);
			this.btnPlusSec.Name = "btnPlusSec";
			this.btnPlusSec.Size = new System.Drawing.Size(56, 24);
			this.btnPlusSec.TabIndex = 5;
			this.btnPlusSec.Text = "+ sec";
			this.btnPlusSec.UseVisualStyleBackColor = true;
			this.btnPlusSec.Click += new System.EventHandler(this.BtnPlusSec_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(231, 120);
			this.Controls.Add(this.btnPlusSec);
			this.Controls.Add(this.btnMinusSec);
			this.Controls.Add(this.lblDisplay);
			this.Controls.Add(this.btnReset);
			this.Controls.Add(this.btnPlusMs);
			this.Controls.Add(this.btnMinusMs);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MainForm";
			this.Text = "Time Sync";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnMinusMs;
		private System.Windows.Forms.Button btnPlusMs;
		private System.Windows.Forms.Button btnReset;
		private System.Windows.Forms.Label lblDisplay;
		private System.Windows.Forms.Button btnMinusSec;
		private System.Windows.Forms.Button btnPlusSec;
	}
}

