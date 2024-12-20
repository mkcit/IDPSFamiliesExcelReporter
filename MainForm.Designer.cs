﻿namespace IDPSFamiliesExcelReporter
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
			this.btnSearch = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			this.btnExport = new System.Windows.Forms.Button();
			this.btnNewIDP = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.btnCiviliansDataSearch = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnSearch
			// 
			this.btnSearch.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSearch.Font = new System.Drawing.Font("AdvertisingMedium", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.btnSearch.Location = new System.Drawing.Point(187, 12);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(169, 77);
			this.btnSearch.TabIndex = 30;
			this.btnSearch.Text = "بحث/تعديل";
			this.btnSearch.UseVisualStyleBackColor = false;
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// btnExit
			// 
			this.btnExit.BackColor = System.Drawing.Color.Red;
			this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnExit.Font = new System.Drawing.Font("AdvertisingMedium", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.btnExit.Location = new System.Drawing.Point(712, 12);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(169, 77);
			this.btnExit.TabIndex = 29;
			this.btnExit.Text = "خروج";
			this.btnExit.UseVisualStyleBackColor = false;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// btnExport
			// 
			this.btnExport.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnExport.Font = new System.Drawing.Font("AdvertisingMedium", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.btnExport.Location = new System.Drawing.Point(362, 12);
			this.btnExport.Name = "btnExport";
			this.btnExport.Size = new System.Drawing.Size(169, 77);
			this.btnExport.TabIndex = 28;
			this.btnExport.Text = "تصدير";
			this.btnExport.UseVisualStyleBackColor = false;
			this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
			// 
			// btnNewIDP
			// 
			this.btnNewIDP.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.btnNewIDP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNewIDP.Font = new System.Drawing.Font("AdvertisingMedium", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.btnNewIDP.Location = new System.Drawing.Point(12, 12);
			this.btnNewIDP.Name = "btnNewIDP";
			this.btnNewIDP.Size = new System.Drawing.Size(169, 77);
			this.btnNewIDP.TabIndex = 27;
			this.btnNewIDP.Text = "نازح جديد";
			this.btnNewIDP.UseVisualStyleBackColor = false;
			this.btnNewIDP.Click += new System.EventHandler(this.btnNewIDP_Click);
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label1.Font = new System.Drawing.Font("ae_Ouhod", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Linen;
			this.label1.Location = new System.Drawing.Point(12, 92);
			this.label1.Name = "label1";
			this.label1.Padding = new System.Windows.Forms.Padding(10);
			this.label1.Size = new System.Drawing.Size(869, 37);
			this.label1.TabIndex = 26;
			this.label1.Text = "DEVELOPED BY MOHAMMED K. ABUSHAWISH / MOBILE NUMBER 0599066526";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnCiviliansDataSearch
			// 
			this.btnCiviliansDataSearch.BackColor = System.Drawing.SystemColors.Info;
			this.btnCiviliansDataSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCiviliansDataSearch.Font = new System.Drawing.Font("AdvertisingMedium", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.btnCiviliansDataSearch.Location = new System.Drawing.Point(537, 12);
			this.btnCiviliansDataSearch.Name = "btnCiviliansDataSearch";
			this.btnCiviliansDataSearch.Size = new System.Drawing.Size(169, 77);
			this.btnCiviliansDataSearch.TabIndex = 31;
			this.btnCiviliansDataSearch.Text = "السجل المدني";
			this.btnCiviliansDataSearch.UseVisualStyleBackColor = false;
			this.btnCiviliansDataSearch.Click += new System.EventHandler(this.btnCiviliansDataSearch_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.ClientSize = new System.Drawing.Size(889, 133);
			this.Controls.Add(this.btnCiviliansDataSearch);
			this.Controls.Add(this.btnSearch);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.btnExport);
			this.Controls.Add(this.btnNewIDP);
			this.Controls.Add(this.label1);
			this.Location = new System.Drawing.Point(360, 0);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MainForm";
			this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.RightToLeftLayout = true;
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "الشاشة الرئيسية";
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnNewIDP;
        private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnCiviliansDataSearch;
	}
}