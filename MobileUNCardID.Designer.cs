namespace IDPSFamiliesExcelReporter
{
	partial class MobileUNCardID
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
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtMobile = new System.Windows.Forms.TextBox();
			this.txtUNCard = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(124, 138);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(119, 47);
			this.button1.TabIndex = 3;
			this.button1.Text = "موافق";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.Location = new System.Drawing.Point(249, 138);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(119, 47);
			this.button2.TabIndex = 4;
			this.button2.Text = "الغاء";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(32, 27);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(103, 25);
			this.label1.TabIndex = 2;
			this.label1.Text = "رقم الجوال";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(32, 81);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(102, 25);
			this.label2.TabIndex = 3;
			this.label2.Text = "كرت المؤن";
			// 
			// txtMobile
			// 
			this.txtMobile.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtMobile.Location = new System.Drawing.Point(141, 24);
			this.txtMobile.Name = "txtMobile";
			this.txtMobile.Size = new System.Drawing.Size(252, 33);
			this.txtMobile.TabIndex = 1;
			// 
			// txtUNCard
			// 
			this.txtUNCard.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtUNCard.Location = new System.Drawing.Point(140, 78);
			this.txtUNCard.Name = "txtUNCard";
			this.txtUNCard.Size = new System.Drawing.Size(252, 33);
			this.txtUNCard.TabIndex = 2;
			// 
			// MobileUNCardID
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(456, 216);
			this.Controls.Add(this.txtUNCard);
			this.Controls.Add(this.txtMobile);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MobileUNCardID";
			this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.RightToLeftLayout = true;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "رقم الجوال - كرت المؤن";
			this.Load += new System.EventHandler(this.MobileUNCardID_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtMobile;
		private System.Windows.Forms.TextBox txtUNCard;
	}
}