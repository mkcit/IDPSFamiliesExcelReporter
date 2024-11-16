namespace IDPSFamiliesExcelReporter
{
    partial class SearchForm
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
			this.gvSearch = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.txtIdentity = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtFname = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtSname = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtFamiliyName = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.btnNewSearch = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.gvSearch)).BeginInit();
			this.SuspendLayout();
			// 
			// gvSearch
			// 
			this.gvSearch.AllowUserToAddRows = false;
			this.gvSearch.AllowUserToDeleteRows = false;
			this.gvSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.gvSearch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
			this.gvSearch.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.gvSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gvSearch.Location = new System.Drawing.Point(12, 182);
			this.gvSearch.MultiSelect = false;
			this.gvSearch.Name = "gvSearch";
			this.gvSearch.ReadOnly = true;
			this.gvSearch.RowHeadersVisible = false;
			this.gvSearch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.gvSearch.Size = new System.Drawing.Size(932, 318);
			this.gvSearch.TabIndex = 0;
			this.gvSearch.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvSearch_CellContentClick);
			this.gvSearch.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvSearch_CellDoubleClick);
			this.gvSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gvSearch_KeyDown);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("AdvertisingBold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.label1.ForeColor = System.Drawing.SystemColors.Control;
			this.label1.Location = new System.Drawing.Point(12, 103);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(101, 29);
			this.label1.TabIndex = 4;
			this.label1.Text = "رقم الهوية";
			// 
			// txtIdentity
			// 
			this.txtIdentity.BackColor = System.Drawing.SystemColors.Info;
			this.txtIdentity.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtIdentity.Location = new System.Drawing.Point(121, 102);
			this.txtIdentity.Name = "txtIdentity";
			this.txtIdentity.Size = new System.Drawing.Size(136, 30);
			this.txtIdentity.TabIndex = 3;
			this.txtIdentity.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtIdentity_KeyDown);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("AdvertisingBold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.label2.ForeColor = System.Drawing.SystemColors.Control;
			this.label2.Location = new System.Drawing.Point(13, 143);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(101, 29);
			this.label2.TabIndex = 48;
			this.label2.Text = "الاسم الأول";
			// 
			// txtFname
			// 
			this.txtFname.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtFname.Location = new System.Drawing.Point(122, 142);
			this.txtFname.Name = "txtFname";
			this.txtFname.Size = new System.Drawing.Size(136, 30);
			this.txtFname.TabIndex = 47;
			this.txtFname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFname_KeyDown);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("AdvertisingBold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.label3.ForeColor = System.Drawing.SystemColors.Control;
			this.label3.Location = new System.Drawing.Point(266, 143);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(87, 29);
			this.label3.TabIndex = 51;
			this.label3.Text = "اسم الأب";
			// 
			// txtSname
			// 
			this.txtSname.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSname.Location = new System.Drawing.Point(361, 142);
			this.txtSname.Name = "txtSname";
			this.txtSname.Size = new System.Drawing.Size(136, 30);
			this.txtSname.TabIndex = 50;
			this.txtSname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSname_KeyDown);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("AdvertisingBold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.label5.ForeColor = System.Drawing.SystemColors.Control;
			this.label5.Location = new System.Drawing.Point(505, 143);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(69, 29);
			this.label5.TabIndex = 53;
			this.label5.Text = "العائلة";
			// 
			// txtFamiliyName
			// 
			this.txtFamiliyName.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtFamiliyName.Location = new System.Drawing.Point(582, 142);
			this.txtFamiliyName.Name = "txtFamiliyName";
			this.txtFamiliyName.Size = new System.Drawing.Size(136, 30);
			this.txtFamiliyName.TabIndex = 52;
			this.txtFamiliyName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFamiliyName_KeyDown);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label6.Font = new System.Drawing.Font("MCS Taybah S_U normal.", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.label6.Location = new System.Drawing.Point(238, 9);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(432, 77);
			this.label6.TabIndex = 57;
			this.label6.Text = "شاشة البحث و التعديل";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnNewSearch
			// 
			this.btnNewSearch.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.btnNewSearch.Font = new System.Drawing.Font("AdvertisingLight", 15.75F);
			this.btnNewSearch.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btnNewSearch.Location = new System.Drawing.Point(763, 122);
			this.btnNewSearch.Name = "btnNewSearch";
			this.btnNewSearch.Size = new System.Drawing.Size(181, 54);
			this.btnNewSearch.TabIndex = 58;
			this.btnNewSearch.Text = "امسح الحقول";
			this.btnNewSearch.UseVisualStyleBackColor = false;
			this.btnNewSearch.Click += new System.EventHandler(this.btnNewSearch_Click);
			// 
			// SearchForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.ClientSize = new System.Drawing.Size(956, 512);
			this.Controls.Add(this.btnNewSearch);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txtFamiliyName);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtSname);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtFname);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtIdentity);
			this.Controls.Add(this.gvSearch);
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "SearchForm";
			this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.RightToLeftLayout = true;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "شاشة البحث و التعديل";
			this.Load += new System.EventHandler(this.SearchForm_Load);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SearchForm_KeyDown);
			((System.ComponentModel.ISupportInitialize)(this.gvSearch)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdentity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFamiliyName;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button btnNewSearch;
	}
}