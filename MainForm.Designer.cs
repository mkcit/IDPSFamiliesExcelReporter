namespace IDPSFamiliesExcelReporter
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
			this.SuspendLayout();
			// 
			// btnSearch
			// 
			this.btnSearch.Font = new System.Drawing.Font("AdvertisingMedium", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.btnSearch.Location = new System.Drawing.Point(306, 12);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(169, 77);
			this.btnSearch.TabIndex = 30;
			this.btnSearch.Text = "بحث/تعديل";
			this.btnSearch.UseVisualStyleBackColor = true;
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// btnExit
			// 
			this.btnExit.Font = new System.Drawing.Font("AdvertisingMedium", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.btnExit.Location = new System.Drawing.Point(656, 12);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(169, 77);
			this.btnExit.TabIndex = 29;
			this.btnExit.Text = "خروج";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// btnExport
			// 
			this.btnExport.Font = new System.Drawing.Font("AdvertisingMedium", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.btnExport.Location = new System.Drawing.Point(481, 12);
			this.btnExport.Name = "btnExport";
			this.btnExport.Size = new System.Drawing.Size(169, 77);
			this.btnExport.TabIndex = 28;
			this.btnExport.Text = "تصدير";
			this.btnExport.UseVisualStyleBackColor = true;
			this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
			// 
			// btnNewIDP
			// 
			this.btnNewIDP.Font = new System.Drawing.Font("AdvertisingMedium", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.btnNewIDP.Location = new System.Drawing.Point(131, 12);
			this.btnNewIDP.Name = "btnNewIDP";
			this.btnNewIDP.Size = new System.Drawing.Size(169, 77);
			this.btnNewIDP.TabIndex = 27;
			this.btnNewIDP.Text = "نازح جديد";
			this.btnNewIDP.UseVisualStyleBackColor = true;
			this.btnNewIDP.Click += new System.EventHandler(this.btnNewIDP_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.label1.Font = new System.Drawing.Font("ae_Ouhod", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label1.Location = new System.Drawing.Point(149, 106);
			this.label1.Name = "label1";
			this.label1.Padding = new System.Windows.Forms.Padding(3);
			this.label1.Size = new System.Drawing.Size(664, 26);
			this.label1.TabIndex = 26;
			this.label1.Text = "PROGRAMMED BY: MR MOHAMMED K. ABUSHAWISH 2024 / Mobile: 0599066526";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(969, 162);
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
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnNewIDP;
        private System.Windows.Forms.Label label1;
    }
}