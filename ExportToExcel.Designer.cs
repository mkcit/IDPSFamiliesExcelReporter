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
            ((System.ComponentModel.ISupportInitialize)(this.gvExportToExcel)).BeginInit();
            this.SuspendLayout();
            // 
            // gvExportToExcel
            // 
            this.gvExportToExcel.AllowUserToAddRows = false;
            this.gvExportToExcel.AllowUserToDeleteRows = false;
            this.gvExportToExcel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvExportToExcel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvExportToExcel.Location = new System.Drawing.Point(12, 12);
            this.gvExportToExcel.Name = "gvExportToExcel";
            this.gvExportToExcel.ReadOnly = true;
            this.gvExportToExcel.Size = new System.Drawing.Size(1186, 380);
            this.gvExportToExcel.TabIndex = 0;
            // 
            // btnExportToExcel
            // 
            this.btnExportToExcel.Font = new System.Drawing.Font("AdvertisingMedium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnExportToExcel.Location = new System.Drawing.Point(12, 417);
            this.btnExportToExcel.Name = "btnExportToExcel";
            this.btnExportToExcel.Size = new System.Drawing.Size(173, 77);
            this.btnExportToExcel.TabIndex = 11;
            this.btnExportToExcel.Text = "تصدير إلى إكسل (F5)";
            this.btnExportToExcel.UseVisualStyleBackColor = true;
            this.btnExportToExcel.Click += new System.EventHandler(this.btnExportToExcel_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Font = new System.Drawing.Font("AdvertisingMedium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnClose.Location = new System.Drawing.Point(1029, 417);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(169, 77);
            this.btnClose.TabIndex = 33;
            this.btnClose.Text = "إغلاق (ESC)";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ExportToExcelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1210, 506);
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

        }

        #endregion

        private System.Windows.Forms.DataGridView gvExportToExcel;
        private System.Windows.Forms.Button btnExportToExcel;
        private System.Windows.Forms.Button btnClose;
    }
}