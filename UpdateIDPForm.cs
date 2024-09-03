using System;
using System.Collections;
using System.Reflection;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Windows.Forms;

namespace IDPSFamiliesExcelReporter
{
    public partial class UpdateIDPForm : Form
    {
        internal static string MemberID;
        internal static string Fname;
        internal static string Sname;
        internal static string Tname;
        internal static string FamilyName;
        internal static string Gender;
        internal static DateTime DOB;
        internal static string Vul1;
        internal static string Vul2;
        internal static string Vul3;
        internal static bool IsExportedToExcel;
        internal static String Action;


		public static bool Prgenant = false;
		public static bool Serious = false;
		public static bool PhysicalDis = false;
		public static bool VisualDis = false;
		public static bool HearingDis = false;
		public static bool IntellDis = false;
		public static bool Female_HOF = false;
		public static bool U_Child_HOF = false;
		public static bool SepChild = false;
		public static bool OlderPer = false;
		public static bool Child_HOF = false;

		public static string Vul4 { get; internal set; }
		public static string Vul5 { get; internal set; }
		public static string Vul6 { get; internal set; }

		public UpdateIDPForm()
        {
            InitializeComponent();
        }


        private void UpdateIDPForm_Load(object sender, EventArgs e)
        {
            cbGender.SelectedIndex = 0;
            //cbVul1.SelectedIndex = 0;
            //cbVul3.SelectedIndex = 0;   
            //cbVul2.SelectedIndex = 0;

            FillData();

			PrepareGridView();
		}

        private void PrepareGridView()
        {
            gvVul.Rows.Clear();

            DataGridViewRow row = new DataGridViewRow();
            row.CreateCells(gvVul);

            row.Cells[0].Value = AddIDP.Prgenant;
            row.Cells[1].Value = AddIDP.Serious;
            row.Cells[2].Value = AddIDP.PhysicalDis;
            row.Cells[3].Value = AddIDP.VisualDis;
            row.Cells[4].Value = AddIDP.HearingDis;
            row.Cells[5].Value = AddIDP.IntellDis;
            row.Cells[6].Value = AddIDP.Female_HOF;
            row.Cells[7].Value = AddIDP.U_Child_HOF;
            row.Cells[8].Value = AddIDP.SepChild;
            row.Cells[9].Value = AddIDP.OlderPer;
            row.Cells[10].Value = AddIDP.Child_HOF;

            gvVul.Rows.Add(row);






            //	internal static String Pregnant_woman = "Pregnant woman \nالنساء الحوامل";
            //internal static String Serious_medical = "Serious medical/health condition \nالحالات الطبية / الصحية الحرجة";
            //internal static String Physical_disability = "Person with disability – physical disability \nذوي الاعاقات الحركية";
            //internal static String Visual_impairment = "Person with disability – visual impairment \nذوي الاعاقات البصرية";
            //internal static String Hearing_impairment = "Person with disability – hearing impairment \nذوي الاعاقات السمعية";
            //internal static String Intellectual_disability = "Person with disability – intellectual disability  \nذوي الاعاقة الذهنية";
            //internal static String Female_Head_of_Household = "Female Head of Household \nارباب الاسر من النساء ";
            //internal static String Unaccompanied_child = "Unaccompanied child head of household  \nرب اسرة طفل غير مصحوب بأحد ";
            //internal static String Separated_child = "Separated child \nطفل منفصل ";
            //internal static String Older_person = "Older person (60+)  \nكبار السن  ";
            //internal static String Child_headed_household = "Child headed household\n الاسرة التي يقودها طفل  ";

            GetVulnerableType(Vul1, row);
            GetVulnerableType(Vul2, row);
            GetVulnerableType(Vul3, row);
            GetVulnerableType(Vul4, row);
            GetVulnerableType(Vul5, row);
            GetVulnerableType(Vul6, row);
        }

        private void FillData()
        {
            txtDOB.Text = DOB.ToString();
            txtFamiliyName.Text = FamilyName;
            txtFname.Text = Fname;
            txtSname.Text = Sname;
            txtTname.Text = Tname;
            txtIdentity.Text = MemberID;

            if (Gender == "ذكر")
                cbGender.SelectedIndex = 1;
            else if (Gender == "انثي")

                cbGender.SelectedIndex = 2;
            else
                cbGender.SelectedIndex = 0;

        }

		private void GetVulnerableType(string vul, DataGridViewRow row)
		{
            if (vul == Options.Pregnant_woman) row.Cells[0].Value = !AddIDP.Prgenant;
			if (vul == Options.Serious_medical) row.Cells[1].Value = !AddIDP.Serious;
			if (vul == Options.Physical_disability) row.Cells[2].Value = !AddIDP.PhysicalDis;
			if (vul == Options.Visual_impairment) row.Cells[3].Value = !AddIDP.VisualDis;
			if (vul == Options.Hearing_impairment) row.Cells[4].Value = !AddIDP.HearingDis;
			if (vul == Options.Intellectual_disability) row.Cells[5].Value = !AddIDP.IntellDis;
			if (vul == Options.Female_Head_of_Household) row.Cells[6].Value = !AddIDP.Female_HOF;
			if (vul == Options.Unaccompanied_child) row.Cells[7].Value = !AddIDP.U_Child_HOF;
			if (vul == Options.Separated_child) row.Cells[8].Value = !AddIDP.SepChild;
			if (vul == Options.Older_person) row.Cells[9].Value = !AddIDP.OlderPer  ;
			if (vul == Options.Child_headed_household) row.Cells[10].Value = !AddIDP.Child_HOF;

			//row.Cells[1].Value = AddIDP.Serious;
			//row.Cells[2].Value = AddIDP.PhysicalDis;
			//row.Cells[3].Value = AddIDP.VisualDis;
			//row.Cells[4].Value = AddIDP.HearingDis;
			//row.Cells[5].Value = AddIDP.IntellDis;
			//row.Cells[6].Value = AddIDP.Female_HOF;
			//row.Cells[7].Value = AddIDP.U_Child_HOF;
			//row.Cells[8].Value = AddIDP.SepChild;
			//row.Cells[9].Value = AddIDP.OlderPer;
			//row.Cells[10].Value = AddIDP.Child_HOF;

		}

		private void UpdateIDPForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                btnSave_Click(sender, e);
            }
            
            else if (e.KeyCode == Keys.F1)
            {
                cbGender.SelectedIndex = 1;
            }
            else if (e.KeyCode == Keys.F2)
            {
                cbGender.SelectedIndex = 2;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
			if (IsRequiredDataFilled())
			{
				String MemberID = txtIdentity.Text;
				String FName = txtFname.Text;
				String SName = txtSname.Text;
				String TName = txtTname.Text;
				FamilyName = txtFamiliyName.Text;
				Gender = cbGender.Text;
				String DOB = txtDOB.Text;


				Prgenant = Convert.ToBoolean(gvVul.Rows[0].Cells[0].Value);
				Serious = Convert.ToBoolean(gvVul.Rows[0].Cells[1].Value);
				PhysicalDis = Convert.ToBoolean(gvVul.Rows[0].Cells[2].Value);
				VisualDis = Convert.ToBoolean(gvVul.Rows[0].Cells[3].Value);
				HearingDis = Convert.ToBoolean(gvVul.Rows[0].Cells[4].Value);
				IntellDis = Convert.ToBoolean(gvVul.Rows[0].Cells[5].Value);
				Female_HOF = Convert.ToBoolean(gvVul.Rows[0].Cells[6].Value);
				U_Child_HOF = Convert.ToBoolean(gvVul.Rows[0].Cells[7].Value);
				SepChild = Convert.ToBoolean(gvVul.Rows[0].Cells[8].Value);
				OlderPer = Convert.ToBoolean(gvVul.Rows[0].Cells[9].Value);
				Child_HOF = Convert.ToBoolean(gvVul.Rows[0].Cells[10].Value);


				String Vul1 = Prgenant ? Options.Pregnant_woman : "";
				String Vul2 = Serious ? Options.Serious_medical : "";
				String Vul3 = PhysicalDis ? Options.Physical_disability : "";
				String Vul4 = VisualDis ? Options.Visual_impairment : "";
				String Vul5 = HearingDis ? Options.Hearing_impairment : "";
				String Vul6 = IntellDis ? Options.Intellectual_disability : "";
				String Vul7 = Female_HOF ? Options.Female_Head_of_Household : "";
				String Vul8 = U_Child_HOF ? Options.Unaccompanied_child : "";
				String Vul9 = SepChild ? Options.Separated_child : "";
				String Vul10 = OlderPer ? Options.Older_person : "";
				String Vul11 = Child_HOF ? Options.Child_headed_household : "";

				//MessageBox.Show(Vul1);
				//MessageBox.Show(Vul2);
				//MessageBox.Show(Vul3);
				//MessageBox.Show(Vul4);
				//MessageBox.Show(Vul5);
				//MessageBox.Show(Vul6);
				//MessageBox.Show(Vul7);
				//MessageBox.Show(Vul8);
				//MessageBox.Show(Vul9);
				//MessageBox.Show(Vul10);
				//MessageBox.Show(Vul11);

				ArrayList disabilities = new ArrayList();

				if (Vul1 != "")
					disabilities.Add(Vul1);
				if (Vul2 != "")
					disabilities.Add(Vul2);
				if (Vul3 != "")
					disabilities.Add(Vul3);
				if (Vul4 != "")
					disabilities.Add(Vul4);
				if (Vul5 != "")
					disabilities.Add(Vul5);
				if (Vul6 != "")
					disabilities.Add(Vul6);
				if (Vul7 != "")
					disabilities.Add(Vul7);
				if (Vul8 != "")
					disabilities.Add(Vul8);
				if (Vul9 != "")
					disabilities.Add(Vul9);
				if (Vul10 != "")
					disabilities.Add(Vul10);
				if (Vul11 != "")
					disabilities.Add(Vul11);

				for (int c = 0; c < 6; c++)
				{
					disabilities.Add("");
				}

				FamiliesShelterDataSetTableAdapters.DataTableAdapter adapter = new FamiliesShelterDataSetTableAdapters.DataTableAdapter();

				String Action = UpdateIDPForm.Action;

				//MessageBox.Show(IsExportedToExcel.ToString());
				//MessageBox.Show(Action.ToString());
				if (IsExportedToExcel)
				{
					if (UpdateIDPForm.Action == "إضافة")
					{
						Action = "تعديل";
					}
					else if (UpdateIDPForm.Action == "تعديل")
					{
						Action = "تعديل";
					}
					else
					{
						Action = "تعديل";
					}
				}
				else
				{
					if (UpdateIDPForm.Action == "إضافة")
					{
						Action = UpdateIDPForm.Action;
					}
					else if (UpdateIDPForm.Action == "تعديل")
					{

						Action = "تعديل";
					}
					else
					{
						Action = "تعديل";

					}
				}


				// UPDATE
				adapter.UpdateIDP(
							Fname,
							Sname,
							Tname,
							FamilyName,
							Convert.ToDateTime(DOB),
							Gender,
							disabilities[0].ToString(),
							disabilities[1].ToString(),
							disabilities[2].ToString(),
							disabilities[3].ToString(),
							disabilities[4].ToString(),
							disabilities[5].ToString(),
							Action,
							MemberID
							);


				//int status = adapter.UpdateIDP(Fname, Sname, Tname, Family, Birth, Gender, Vul1, Vul2, Vul3, Action, MemberID);


				Options.Info();
				Dispose();
			}
			else
			{
				MessageBox.Show("يجب تعبئة جميع الحقول الضرورية", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}


			//try
			//{
			//    String MemberID = txtIdentity.Text;
			//    String Fname = txtFname.Text;
			//    String Sname = txtSname.Text;
			//    String Tname = txtTname.Text;
			//    String Family = txtFamiliyName.Text;
			//    DateTime Birth = Convert.ToDateTime(txtDOB.Text);

			//    //String Vul1 = cbVul1.SelectedIndex == 0 ? "" : cbVul1.Text;
			//    //String Vul2 = cbVul2.SelectedIndex == 0 ? "" : cbVul2.Text;
			//    //String Vul3 = cbVul3.SelectedIndex == 0 ? "" : cbVul3.Text;
			//    String Gender = cbGender.Text;

			//    if (Fname != "" && Sname != "" && Tname != "" && Family != "" && txtDOB.Text != "" && cbGender.SelectedIndex != 0)
			//    {
			//        FamiliesShelterDataSetTableAdapters.QueriesTableAdapter qAdapter = new FamiliesShelterDataSetTableAdapters.QueriesTableAdapter();

			//        var subdays = DateTime.Now.Subtract(Birth).TotalDays;

			//        if (subdays > 1000)
			//        {
			//            FamiliesShelterDataSetTableAdapters.DataTableAdapter adapter = new FamiliesShelterDataSetTableAdapters.DataTableAdapter();
			//            String Action = UpdateIDPForm.Action;

			//            if (IsExportedToExcel )
			//            {
			//                if(UpdateIDPForm.Action == "إضافة")
			//                {
			//                    Action = "تعديل";
			//                }
			//                else if(UpdateIDPForm.Action == "تعديل")
			//                {
			//                    Action = "تعديل";
			//                }
			//                else
			//                {
			//                    Action = "تعديل";
			//                }
			//            }
			//            else
			//            {
			//                if (UpdateIDPForm.Action == "إضافة")
			//                {

			//                    Action = UpdateIDPForm.Action;
			//                }
			//                else if (UpdateIDPForm.Action == "تعديل")
			//                {

			//                    Action = "تعديل";
			//                }
			//                else
			//                {
			//                    Action = "تعديل";

			//                }
			//            }


			//            //int status = adapter.UpdateIDP(Fname, Sname, Tname, Family, Birth, Gender, Vul1, Vul2, Vul3, Action, MemberID);


			//            Options.Info();
			//            Dispose();
			//        }
			//        else
			//        {
			//            Options.Error("يبدو أن تاريخ الميلاد غير صحيح");
			//        }


			//    }
			//    else
			//    { Options.Error("يجب إضافة البيانات وملء الفراغات"); }
			//}
			//catch
			//{ Options.Error("خطأ غير متوقع"); }
		}

		private bool IsRequiredDataFilled()
		{
			return txtIdentity.Text != "" && txtIdentity.Text.Length == 9 && txtFname.Text != "" && txtSname.Text != "" && txtTname.Text != "" && txtFamiliyName.Text != "" && cbGender.SelectedIndex != 0;
		}
	}
}
