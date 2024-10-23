namespace IDPSFamiliesExcelReporter
{
	partial class SearchFormGaza
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
			this.Copy = new System.Windows.Forms.DataGridViewButtonColumn();
			this.label1 = new System.Windows.Forms.Label();
			this.txtIdentity = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtFname = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtSname = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtFamiliyName = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtTName = new System.Windows.Forms.TextBox();
			this.btnFirst = new System.Windows.Forms.Button();
			this.btnLast = new System.Windows.Forms.Button();
			this.btnNext = new System.Windows.Forms.Button();
			this.btnPrevious = new System.Windows.Forms.Button();
			this.txtPageNumber = new System.Windows.Forms.TextBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
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
			this.gvSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gvSearch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Copy});
			this.gvSearch.Location = new System.Drawing.Point(12, 93);
			this.gvSearch.MultiSelect = false;
			this.gvSearch.Name = "gvSearch";
			this.gvSearch.ReadOnly = true;
			this.gvSearch.RowHeadersVisible = false;
			this.gvSearch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.gvSearch.Size = new System.Drawing.Size(617, 513);
			this.gvSearch.TabIndex = 0;
			this.gvSearch.VirtualMode = true;
			this.gvSearch.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvSearch_CellClick);
			this.gvSearch.CellValueNeeded += new System.Windows.Forms.DataGridViewCellValueEventHandler(this.gvSearch_CellValueNeeded);
			this.gvSearch.Scroll += new System.Windows.Forms.ScrollEventHandler(this.gvSearch_Scroll);
			this.gvSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gvSearch_KeyUp);
			// 
			// Copy
			// 
			this.Copy.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			this.Copy.Frozen = true;
			this.Copy.HeaderText = "نسخ المعلومات";
			this.Copy.Name = "Copy";
			this.Copy.ReadOnly = true;
			this.Copy.Text = "نسخ المعلومات";
			this.Copy.UseColumnTextForButtonValue = true;
			this.Copy.Visible = false;
			this.Copy.Width = 150;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("AdvertisingBold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label1.Location = new System.Drawing.Point(11, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(101, 29);
			this.label1.TabIndex = 4;
			this.label1.Text = "رقم الهوية";
			// 
			// txtIdentity
			// 
			this.txtIdentity.BackColor = System.Drawing.SystemColors.Info;
			this.txtIdentity.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtIdentity.Location = new System.Drawing.Point(120, 12);
			this.txtIdentity.Name = "txtIdentity";
			this.txtIdentity.Size = new System.Drawing.Size(136, 30);
			this.txtIdentity.TabIndex = 1;
			this.txtIdentity.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtIdentity_KeyDown);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("AdvertisingBold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label2.Location = new System.Drawing.Point(286, 13);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(101, 29);
			this.label2.TabIndex = 48;
			this.label2.Text = "الاسم الأول";
			// 
			// txtFname
			// 
			this.txtFname.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtFname.Location = new System.Drawing.Point(393, 12);
			this.txtFname.Name = "txtFname";
			this.txtFname.Size = new System.Drawing.Size(136, 30);
			this.txtFname.TabIndex = 2;
			this.txtFname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFname_KeyDown);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("AdvertisingBold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label3.Location = new System.Drawing.Point(561, 13);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(87, 29);
			this.label3.TabIndex = 51;
			this.label3.Text = "اسم الأب";
			// 
			// txtSname
			// 
			this.txtSname.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSname.Location = new System.Drawing.Point(654, 12);
			this.txtSname.Name = "txtSname";
			this.txtSname.Size = new System.Drawing.Size(136, 30);
			this.txtSname.TabIndex = 3;
			this.txtSname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSname_KeyDown);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("AdvertisingBold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label5.Location = new System.Drawing.Point(318, 49);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(69, 29);
			this.label5.TabIndex = 53;
			this.label5.Text = "العائلة";
			// 
			// txtFamiliyName
			// 
			this.txtFamiliyName.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtFamiliyName.Location = new System.Drawing.Point(393, 48);
			this.txtFamiliyName.Name = "txtFamiliyName";
			this.txtFamiliyName.Size = new System.Drawing.Size(136, 30);
			this.txtFamiliyName.TabIndex = 5;
			this.txtFamiliyName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFamiliyName_KeyDown);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("AdvertisingBold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label4.Location = new System.Drawing.Point(27, 49);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(87, 29);
			this.label4.TabIndex = 55;
			this.label4.Text = "اسم الجد";
			// 
			// txtTName
			// 
			this.txtTName.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTName.Location = new System.Drawing.Point(120, 48);
			this.txtTName.Name = "txtTName";
			this.txtTName.Size = new System.Drawing.Size(136, 30);
			this.txtTName.TabIndex = 4;
			this.txtTName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTName_KeyDown);
			// 
			// btnFirst
			// 
			this.btnFirst.Location = new System.Drawing.Point(821, 40);
			this.btnFirst.Name = "btnFirst";
			this.btnFirst.Size = new System.Drawing.Size(44, 38);
			this.btnFirst.TabIndex = 56;
			this.btnFirst.Text = "<";
			this.btnFirst.UseVisualStyleBackColor = true;
			// 
			// btnLast
			// 
			this.btnLast.Location = new System.Drawing.Point(1029, 40);
			this.btnLast.Name = "btnLast";
			this.btnLast.Size = new System.Drawing.Size(44, 38);
			this.btnLast.TabIndex = 57;
			this.btnLast.Text = ">";
			this.btnLast.UseVisualStyleBackColor = true;
			// 
			// btnNext
			// 
			this.btnNext.Location = new System.Drawing.Point(871, 40);
			this.btnNext.Name = "btnNext";
			this.btnNext.Size = new System.Drawing.Size(44, 38);
			this.btnNext.TabIndex = 58;
			this.btnNext.Text = "<<";
			this.btnNext.UseVisualStyleBackColor = true;
			this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
			// 
			// btnPrevious
			// 
			this.btnPrevious.Location = new System.Drawing.Point(979, 40);
			this.btnPrevious.Name = "btnPrevious";
			this.btnPrevious.Size = new System.Drawing.Size(44, 38);
			this.btnPrevious.TabIndex = 59;
			this.btnPrevious.Text = ">>";
			this.btnPrevious.UseVisualStyleBackColor = true;
			this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
			// 
			// txtPageNumber
			// 
			this.txtPageNumber.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPageNumber.Location = new System.Drawing.Point(926, 45);
			this.txtPageNumber.Name = "txtPageNumber";
			this.txtPageNumber.Size = new System.Drawing.Size(47, 27);
			this.txtPageNumber.TabIndex = 60;
			this.txtPageNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(635, 122);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(444, 363);
			this.textBox1.TabIndex = 61;
			// 
			// SearchFormGaza
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.ClientSize = new System.Drawing.Size(1086, 618);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.txtPageNumber);
			this.Controls.Add(this.btnPrevious);
			this.Controls.Add(this.btnNext);
			this.Controls.Add(this.btnLast);
			this.Controls.Add(this.btnFirst);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtTName);
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
			this.Name = "SearchFormGaza";
			this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.RightToLeftLayout = true;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "شاشة البحث و التعديل";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SearchFormGaza_FormClosing);
			this.Load += new System.EventHandler(this.SearchFormGaza_Load);
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
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtTName;
		private System.Windows.Forms.DataGridViewButtonColumn Copy;
		private System.Windows.Forms.Button btnFirst;
		private System.Windows.Forms.Button btnLast;
		private System.Windows.Forms.Button btnNext;
		private System.Windows.Forms.Button btnPrevious;
		private System.Windows.Forms.TextBox txtPageNumber;
		private System.Windows.Forms.TextBox textBox1;
	}
}