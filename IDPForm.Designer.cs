namespace IDPSFamiliesExcelReporter
{
    partial class IDPForm
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
            this.txtIdentity = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFamiliyName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.gvFamliyMembersExportedToExcel = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            this.cbVul1 = new System.Windows.Forms.ComboBox();
            this.btnAddSonsDaughters = new System.Windows.Forms.Button();
            this.btnAddWife = new System.Windows.Forms.Button();
            this.cbVul2 = new System.Windows.Forms.ComboBox();
            this.cbVul3 = new System.Windows.Forms.ComboBox();
            this.gazaPeopleDataSet = new IDPSFamiliesExcelReporter.GazaPeopleDataSet();
            this.label7 = new System.Windows.Forms.Label();
            this.familiesShelterDataSet = new IDPSFamiliesExcelReporter.FamiliesShelterDataSet();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtDOB = new System.Windows.Forms.DateTimePicker();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnNewIDP = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gvFamliyMembersExportedToExcel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gazaPeopleDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.familiesShelterDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIdentity
            // 
            this.txtIdentity.BackColor = System.Drawing.SystemColors.Info;
            this.txtIdentity.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdentity.Location = new System.Drawing.Point(153, 91);
            this.txtIdentity.Name = "txtIdentity";
            this.txtIdentity.Size = new System.Drawing.Size(223, 30);
            this.txtIdentity.TabIndex = 0;
            this.txtIdentity.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtIdentity_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("AdvertisingBold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(17, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "رقم الهوية";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("AdvertisingBold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(17, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "الاسم الأول";
            // 
            // txtFname
            // 
            this.txtFname.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFname.Location = new System.Drawing.Point(153, 127);
            this.txtFname.Name = "txtFname";
            this.txtFname.Size = new System.Drawing.Size(223, 30);
            this.txtFname.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("AdvertisingBold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(31, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "اسم الأب";
            // 
            // txtSname
            // 
            this.txtSname.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSname.Location = new System.Drawing.Point(153, 163);
            this.txtSname.Name = "txtSname";
            this.txtSname.Size = new System.Drawing.Size(223, 30);
            this.txtSname.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("AdvertisingBold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(31, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 29);
            this.label4.TabIndex = 8;
            this.label4.Text = "اسم الجد";
            // 
            // txtTname
            // 
            this.txtTname.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTname.Location = new System.Drawing.Point(153, 199);
            this.txtTname.Name = "txtTname";
            this.txtTname.Size = new System.Drawing.Size(223, 30);
            this.txtTname.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("AdvertisingBold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.Location = new System.Drawing.Point(49, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 29);
            this.label5.TabIndex = 10;
            this.label5.Text = "العائلة";
            // 
            // txtFamiliyName
            // 
            this.txtFamiliyName.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFamiliyName.Location = new System.Drawing.Point(153, 235);
            this.txtFamiliyName.Name = "txtFamiliyName";
            this.txtFamiliyName.Size = new System.Drawing.Size(223, 30);
            this.txtFamiliyName.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("AdvertisingBold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label6.Location = new System.Drawing.Point(382, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 29);
            this.label6.TabIndex = 12;
            this.label6.Text = "تاريخ الميلاد";
            // 
            // cbGender
            // 
            this.cbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGender.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Items.AddRange(new object[] {
            "النوع الاجتماعي",
            "ذكر",
            "أنثي"});
            this.cbGender.Location = new System.Drawing.Point(518, 127);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(147, 31);
            this.cbGender.TabIndex = 6;
            this.cbGender.SelectedIndexChanged += new System.EventHandler(this.cbGender_SelectedIndexChanged);
            // 
            // gvFamliyMembersExportedToExcel
            // 
            this.gvFamliyMembersExportedToExcel.AllowUserToAddRows = false;
            this.gvFamliyMembersExportedToExcel.AllowUserToDeleteRows = false;
            this.gvFamliyMembersExportedToExcel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvFamliyMembersExportedToExcel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gvFamliyMembersExportedToExcel.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gvFamliyMembersExportedToExcel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvFamliyMembersExportedToExcel.Location = new System.Drawing.Point(22, 271);
            this.gvFamliyMembersExportedToExcel.Name = "gvFamliyMembersExportedToExcel";
            this.gvFamliyMembersExportedToExcel.ReadOnly = true;
            this.gvFamliyMembersExportedToExcel.RowHeadersVisible = false;
            this.gvFamliyMembersExportedToExcel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.gvFamliyMembersExportedToExcel.Size = new System.Drawing.Size(1141, 220);
            this.gvFamliyMembersExportedToExcel.TabIndex = 17;
            this.gvFamliyMembersExportedToExcel.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.gvFamliyMembersExportedToExcel_CellFormatting);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("AdvertisingMedium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnSave.Location = new System.Drawing.Point(22, 497);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(169, 77);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "حفظ (F5)";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cbVul1
            // 
            this.cbVul1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbVul1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVul1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbVul1.FormattingEnabled = true;
            this.cbVul1.Items.AddRange(new object[] {
            "الهشاشة",
            "Pregnant woman النساء الحوامل",
            "Serious medical/health condition الحالات الطبية / الصحية الحرجة",
            "Person with disability - physical disabiliy ذوي الاعاقات الحركية",
            "Person with disability - visual impairment ذوي الاعاقات البصرية",
            "Person with disability - hearing impairment ذوي الاعاقات السمعية",
            "Person with disability - intellectual disability ذوي الاعاقات الذهنية",
            "Female Head of Household ارباب الاسر من النساء",
            "Unaccompanied child head of household رب اسرة طفل غير مصحوب بأحد",
            "Seperated child طفل منفصل",
            "Older person (60+) كبار السن",
            "Child headed household الاسرة التي يقوده طفل"});
            this.cbVul1.Location = new System.Drawing.Point(387, 163);
            this.cbVul1.Name = "cbVul1";
            this.cbVul1.Size = new System.Drawing.Size(776, 31);
            this.cbVul1.TabIndex = 7;
            // 
            // btnAddSonsDaughters
            // 
            this.btnAddSonsDaughters.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAddSonsDaughters.Font = new System.Drawing.Font("AdvertisingMedium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnAddSonsDaughters.Location = new System.Drawing.Point(363, 497);
            this.btnAddSonsDaughters.Name = "btnAddSonsDaughters";
            this.btnAddSonsDaughters.Size = new System.Drawing.Size(169, 77);
            this.btnAddSonsDaughters.TabIndex = 12;
            this.btnAddSonsDaughters.Text = "أضف أبناء";
            this.btnAddSonsDaughters.UseVisualStyleBackColor = false;
            this.btnAddSonsDaughters.Click += new System.EventHandler(this.btnAddSonsDaughters_Click);
            // 
            // btnAddWife
            // 
            this.btnAddWife.BackColor = System.Drawing.Color.HotPink;
            this.btnAddWife.Font = new System.Drawing.Font("AdvertisingMedium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnAddWife.Location = new System.Drawing.Point(192, 497);
            this.btnAddWife.Name = "btnAddWife";
            this.btnAddWife.Size = new System.Drawing.Size(169, 77);
            this.btnAddWife.TabIndex = 11;
            this.btnAddWife.Text = "أضف زوجة";
            this.btnAddWife.UseVisualStyleBackColor = false;
            this.btnAddWife.Click += new System.EventHandler(this.btnAddWife_Click);
            // 
            // cbVul2
            // 
            this.cbVul2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbVul2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVul2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbVul2.FormattingEnabled = true;
            this.cbVul2.Items.AddRange(new object[] {
            "الهشاشة",
            "Pregnant woman النساء الحوامل",
            "Serious medical/health condition الحالات الطبية / الصحية الحرجة",
            "Person with disability - physical disabiliy ذوي الاعاقات الحركية",
            "Person with disability - visual impairment ذوي الاعاقات البصرية",
            "Person with disability - hearing impairment ذوي الاعاقات السمعية",
            "Person with disability - intellectual disability ذوي الاعاقات الذهنية",
            "Female Head of Household ارباب الاسر من النساء",
            "Unaccompanied child head of household رب اسرة طفل غير مصحوب بأحد",
            "Seperated child طفل منفصل",
            "Older person (60+) كبار السن",
            "Child headed household الاسرة التي يقوده طفل"});
            this.cbVul2.Location = new System.Drawing.Point(387, 199);
            this.cbVul2.Name = "cbVul2";
            this.cbVul2.Size = new System.Drawing.Size(776, 31);
            this.cbVul2.TabIndex = 8;
            // 
            // cbVul3
            // 
            this.cbVul3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbVul3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVul3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbVul3.FormattingEnabled = true;
            this.cbVul3.Items.AddRange(new object[] {
            "الهشاشة",
            "Pregnant woman النساء الحوامل",
            "Serious medical/health condition الحالات الطبية / الصحية الحرجة",
            "Person with disability - physical disabiliy ذوي الاعاقات الحركية",
            "Person with disability - visual impairment ذوي الاعاقات البصرية",
            "Person with disability - hearing impairment ذوي الاعاقات السمعية",
            "Person with disability - intellectual disability ذوي الاعاقات الذهنية",
            "Female Head of Household ارباب الاسر من النساء",
            "Unaccompanied child head of household رب اسرة طفل غير مصحوب بأحد",
            "Seperated child طفل منفصل",
            "Older person (60+) كبار السن",
            "Child headed household الاسرة التي يقوده طفل"});
            this.cbVul3.Location = new System.Drawing.Point(387, 235);
            this.cbVul3.Name = "cbVul3";
            this.cbVul3.Size = new System.Drawing.Size(776, 31);
            this.cbVul3.TabIndex = 9;
            // 
            // gazaPeopleDataSet
            // 
            this.gazaPeopleDataSet.DataSetName = "GazaPeopleDataSet";
            this.gazaPeopleDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("AdvertisingMedium", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label7.Location = new System.Drawing.Point(12, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(350, 60);
            this.label7.TabIndex = 23;
            this.label7.Text = "بيانات رب الأسرة HOF";
            // 
            // familiesShelterDataSet
            // 
            this.familiesShelterDataSet.DataSetName = "FamiliesShelterDataSet";
            this.familiesShelterDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("AdvertisingBold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(124, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 29);
            this.label8.TabIndex = 24;
            this.label8.Text = "*";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("AdvertisingBold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(124, 129);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 29);
            this.label9.TabIndex = 25;
            this.label9.Text = "*";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("AdvertisingBold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(124, 199);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(23, 29);
            this.label10.TabIndex = 27;
            this.label10.Text = "*";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("AdvertisingBold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(124, 164);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(23, 29);
            this.label11.TabIndex = 26;
            this.label11.Text = "*";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("AdvertisingBold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(124, 234);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(23, 29);
            this.label12.TabIndex = 28;
            this.label12.Text = "*";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("AdvertisingBold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(489, 92);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(23, 29);
            this.label13.TabIndex = 29;
            this.label13.Text = "*";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("AdvertisingBold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(489, 128);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(23, 29);
            this.label14.TabIndex = 31;
            this.label14.Text = "*";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("AdvertisingBold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label15.Location = new System.Drawing.Point(425, 128);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(58, 29);
            this.label15.TabIndex = 30;
            this.label15.Text = "الجندر";
            // 
            // txtDOB
            // 
            this.txtDOB.CustomFormat = "";
            this.txtDOB.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.txtDOB.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.txtDOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDOB.Location = new System.Drawing.Point(518, 91);
            this.txtDOB.Name = "txtDOB";
            this.txtDOB.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtDOB.Size = new System.Drawing.Size(147, 30);
            this.txtDOB.TabIndex = 5;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Font = new System.Drawing.Font("AdvertisingMedium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnClose.Location = new System.Drawing.Point(993, 497);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(169, 77);
            this.btnClose.TabIndex = 32;
            this.btnClose.Text = "إغلاق (ESC)";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnNewIDP
            // 
            this.btnNewIDP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNewIDP.Font = new System.Drawing.Font("AdvertisingMedium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnNewIDP.Location = new System.Drawing.Point(818, 497);
            this.btnNewIDP.Name = "btnNewIDP";
            this.btnNewIDP.Size = new System.Drawing.Size(169, 77);
            this.btnNewIDP.TabIndex = 33;
            this.btnNewIDP.Text = "جديد (F4)";
            this.btnNewIDP.UseVisualStyleBackColor = true;
            this.btnNewIDP.Click += new System.EventHandler(this.btnNewIDP_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(671, 138);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(103, 13);
            this.label16.TabIndex = 70;
            this.label16.Text = "F1 Male - F2 Female";
            // 
            // IDPForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 604);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.btnNewIDP);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtDOB);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbVul3);
            this.Controls.Add(this.cbVul2);
            this.Controls.Add(this.btnAddWife);
            this.Controls.Add(this.btnAddSonsDaughters);
            this.Controls.Add(this.cbVul1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.gvFamliyMembersExportedToExcel);
            this.Controls.Add(this.cbGender);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtFamiliyName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIdentity);
            this.HelpButton = true;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "IDPForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "نموذج رب الأسرة";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.IDPForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.gvFamliyMembersExportedToExcel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gazaPeopleDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.familiesShelterDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtIdentity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFamiliyName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbGender;
        private System.Windows.Forms.DataGridView gvFamliyMembersExportedToExcel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cbVul1;
        private System.Windows.Forms.Button btnAddSonsDaughters;
        private System.Windows.Forms.Button btnAddWife;
        private System.Windows.Forms.ComboBox cbVul2;
        private System.Windows.Forms.ComboBox cbVul3;
        private GazaPeopleDataSet gazaPeopleDataSet;
        private System.Windows.Forms.Label label7;
        private FamiliesShelterDataSet familiesShelterDataSet;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker txtDOB;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnNewIDP;
        private System.Windows.Forms.Label label16;
        //private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        //private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        //private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        //private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        //private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        //private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        //private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        //private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
    }
}

