namespace IDPSFamiliesExcelReporter
{
    partial class ExportToExcelForm
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
			this.gvExportToExcel = new System.Windows.Forms.DataGridView();
			this.btnExportToExcel = new System.Windows.Forms.Button();
			this.btnClose = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.gvExportToExcel)).BeginInit();
			this.SuspendLayout();
			// 
			// gvExportToExcel
			// 
			this.gvExportToExcel.AllowUserToAddRows = false;
			this.gvExportToExcel.AllowUserToDeleteRows = false;
			this.gvExportToExcel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.gvExportToExcel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.gvExportToExcel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gvExportToExcel.Location = new System.Drawing.Point(12, 100);
			this.gvExportToExcel.Name = "gvExportToExcel";
			this.gvExportToExcel.ReadOnly = true;
			this.gvExportToExcel.Size = new System.Drawing.Size(944, 388);
			this.gvExportToExcel.TabIndex = 0;
			// 
			// btnExportToExcel
			// 
			this.btnExportToExcel.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.btnExportToExcel.Font = new System.Drawing.Font("AdvertisingMedium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.btnExportToExcel.Location = new System.Drawing.Point(12, 494);
			this.btnExportToExcel.Name = "btnExportToExcel";
			this.btnExportToExcel.Size = new System.Drawing.Size(173, 60);
			this.btnExportToExcel.TabIndex = 11;
			this.btnExportToExcel.Text = "تصدير إلى إكسل (F5)";
			this.btnExportToExcel.UseVisualStyleBackColor = false;
			this.btnExportToExcel.Click += new System.EventHandler(this.btnExportToExcel_Click);
			// 
			// btnClose
			// 
			this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnClose.BackColor = System.Drawing.Color.Red;
			this.btnClose.Font = new System.Drawing.Font("AdvertisingMedium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.btnClose.Location = new System.Drawing.Point(787, 494);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(169, 60);
			this.btnClose.TabIndex = 33;
			this.btnClose.Text = "إغلاق (ESC)";
			this.btnClose.UseVisualStyleBackColor = false;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label6.Font = new System.Drawing.Font("MCS Taybah S_U normal.", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.label6.Location = new System.Drawing.Point(230, 9);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(489, 77);
			this.label6.TabIndex = 58;
			this.label6.Text = "تصدير البيانات إلى إكسل";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// ExportToExcelForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = Options.Theme;
			this.ClientSize = new System.Drawing.Size(968, 564);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.btnExportToExcel);
			this.Controls.Add(this.gvExportToExcel);
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "ExportToExcelForm";
			this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.RightToLeftLayout = true;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "تصدير المعلومات إلى ملف إكسل";
			this.Load += new System.EventHandler(this.ExportToExcel_Load);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ExportToExcelForm_KeyDown);
			((System.ComponentModel.ISupportInitialize)(this.gvExportToExcel)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvExportToExcel;
        private System.Windows.Forms.Button btnExportToExcel;
        private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.Label label6;
	}
}