using System;
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

        public UpdateIDPForm()
        {
            InitializeComponent();
        }


        private void UpdateIDPForm_Load(object sender, EventArgs e)
        {
            cbGender.SelectedIndex = 0;
            cbVul1.SelectedIndex = 0;
            cbVul3.SelectedIndex = 0;   
            cbVul2.SelectedIndex = 0;

            FillData();
        }

        private void FillData()
        {
            txtDOB.Text = DOB.ToString();
            txtFamiliyName.Text = FamilyName;
            txtFname.Text = Fname;
            txtSname.Text = Sname;
            txtTname.Text = Tname;
            txtIdentity.Text = MemberID;
            cbGender.Text = Gender;
            cbVul1.Text = Vul1;
            cbVul2.Text = Vul2;
            cbVul3.Text = Vul3;
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
            try
            {
                String MemberID = txtIdentity.Text;
                String Fname = txtFname.Text;
                String Sname = txtSname.Text;
                String Tname = txtTname.Text;
                String Family = txtFamiliyName.Text;
                DateTime Birth = Convert.ToDateTime(txtDOB.Text);

                String Vul1 = cbVul1.SelectedIndex == 0 ? "" : cbVul1.Text;
                String Vul2 = cbVul2.SelectedIndex == 0 ? "" : cbVul2.Text;
                String Vul3 = cbVul3.SelectedIndex == 0 ? "" : cbVul3.Text;
                String Gender = cbGender.Text;

                if (Fname != "" && Sname != "" && Tname != "" && Family != "" && txtDOB.Text != "" && cbGender.SelectedIndex != 0)
                {
                    FamiliesShelterDataSetTableAdapters.QueriesTableAdapter qAdapter = new FamiliesShelterDataSetTableAdapters.QueriesTableAdapter();

                    var subdays = DateTime.Now.Subtract(Birth).TotalDays;

                    if (subdays > 1000)
                    {
                        FamiliesShelterDataSetTableAdapters.DataTableAdapter adapter = new FamiliesShelterDataSetTableAdapters.DataTableAdapter();
                        String Action = UpdateIDPForm.Action;

                        if (IsExportedToExcel )
                        {
                            if(UpdateIDPForm.Action == "إضافة")
                            {
                                Action = "تعديل";
                            }
                            else if(UpdateIDPForm.Action == "تعديل")
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
                        

                        int status = adapter.UpdateIDP(Fname, Sname, Tname, Family, Birth, Gender, Vul1, Vul2, Vul3, Action, MemberID);


                        Options.Info();
                        Dispose();
                    }
                    else
                    {
                        Options.Error("يبدو أن تاريخ الميلاد غير صحيح");
                    }


                }
                else
                { Options.Error("يجب إضافة البيانات وملء الفراغات"); }
            }
            catch
            { Options.Error("خطأ غير متوقع"); }
        }
    }
}
