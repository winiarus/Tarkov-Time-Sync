namespace Tarkov_Time_Sync
{
	partial class Form1
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.btnReset = new System.Windows.Forms.Button();
			this.lblDisplay = new System.Windows.Forms.Label();
			this.btnPlus = new System.Windows.Forms.Button();
			this.btnMinus = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnReset
			// 
			this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnReset.Location = new System.Drawing.Point(12, 54);
			this.btnReset.Name = "btnReset";
			this.btnReset.Size = new System.Drawing.Size(151, 36);
			this.btnReset.TabIndex = 2;
			this.btnReset.Text = "Reset";
			this.btnReset.UseVisualStyleBackColor = true;
			// 
			// lblDisplay
			// 
			this.lblDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDisplay.Location = new System.Drawing.Point(54, 12);
			this.lblDisplay.Name = "lblDisplay";
			this.lblDisplay.Size = new System.Drawing.Size(67, 36);
			this.lblDisplay.TabIndex = 3;
			this.lblDisplay.Text = "label1";
			this.lblDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnPlus
			// 
			this.btnPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnPlus.Image = global::Tarkov_Time_Sync.Properties.Resources.plus;
			this.btnPlus.Location = new System.Drawing.Point(127, 12);
			this.btnPlus.Name = "btnPlus";
			this.btnPlus.Size = new System.Drawing.Size(36, 36);
			this.btnPlus.TabIndex = 1;
			this.btnPlus.UseVisualStyleBackColor = true;
			// 
			// btnMinus
			// 
			this.btnMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnMinus.Image = ((System.Drawing.Image)(resources.GetObject("btnMinus.Image")));
			this.btnMinus.Location = new System.Drawing.Point(12, 12);
			this.btnMinus.Name = "btnMinus";
			this.btnMinus.Size = new System.Drawing.Size(36, 36);
			this.btnMinus.TabIndex = 0;
			this.btnMinus.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(175, 103);
			this.Controls.Add(this.lblDisplay);
			this.Controls.Add(this.btnReset);
			this.Controls.Add(this.btnPlus);
			this.Controls.Add(this.btnMinus);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form1";
			this.Text = "Time Sync";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnMinus;
		private System.Windows.Forms.Button btnPlus;
		private System.Windows.Forms.Button btnReset;
		private System.Windows.Forms.Label lblDisplay;
	}
}

