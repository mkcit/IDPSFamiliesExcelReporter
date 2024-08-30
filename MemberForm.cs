using System;
using System.Data;
using System.Windows.Forms;

namespace IDPSFamiliesExcelReporter
{
    public partial class MemberForm : Form
    {

        public static String SName;
        public static String TName;
        public static String LName;
        internal static string HOFID;

        public MemberForm()
        {
            InitializeComponent();
        }
        private void Error(string msg)
        {
            MessageBox.Show(this, msg, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void txtIdentity_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtIdentity.Text != "")
                {
                    ClearData();

                    GazaPeopleDataSet.DataDataTable gpDT = new GazaPeopleDataSet.DataDataTable();

                    GazaPeopleDataSetTableAdapters.DataTableAdapter gpTableAdapter = new GazaPeopleDataSetTableAdapters.DataTableAdapter();

                    gpTableAdapter.Fill(gpDT, txtIdentity.Text);

                    FamiliesShelterDataSet.DataDataTable fisDT = new FamiliesShelterDataSet.DataDataTable();

                    FamiliesShelterDataSetTableAdapters.DataTableAdapter fisTableAdapter = new
                        FamiliesShelterDataSetTableAdapters.DataTableAdapter();


                    if (gpDT.Rows.Count > 0)
                    {
                        FillData(gpDT.Rows[0]);
                    }

                }

            }

        }


        private void FillData(DataRow dataRow)
        {
            if(!txtSname.Enabled)
            {
                if (dataRow[2].ToString().Trim() == SName.Trim() && dataRow[4].ToString().Trim() == LName.Trim())
                {
                    BindData(dataRow);
                }
                else
                { Error("رقم الهوية الابن المدخل ليس له علاقة بالأب ( رب الأسرة )"); }
            }
            else
            {
                BindData(dataRow);
            }
            
            
        }

        private void BindData(DataRow dataRow)
        {
            txtFname.Text = dataRow[1].ToString();
            txtSname.Text = dataRow[2].ToString();
            txtTname.Text = dataRow[3].ToString();
            txtFamiliyName.Text = dataRow[4].ToString();
            txtDOB.Text = Convert.ToDateTime(dataRow[6].ToString()).ToShortDateString();

            if (dataRow[7].ToString() == "1")
                cbGender.Text = "ذكر";
            else cbGender.Text = "أنثي";
        }

        private void ClearData()
        {
            txtIdentity.Focus();
            txtFname.Text = "";
            //txtSname.Text = "";
            //txtTname.Text = "";
            //txtFamiliyName.Text = "";
            txtDOB.Text = "";
            cbGender.SelectedIndex = 0;
            cbVul1.SelectedIndex = 0;
            cbVul2.SelectedIndex = 0;
            cbVul3.SelectedIndex = 0;
        }

        private void MemberForm_Load(object sender, EventArgs e)
        {
            ClearData();
            txtSname.Text = SName;
            txtTname.Text = TName;
            txtFamiliyName.Text = LName;
        }

        

        internal  void TextsEnabled(bool v)
        {
            txtTname.Enabled = v;
            txtSname.Enabled = v;
           txtFamiliyName.Enabled = v;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                String HoFID = MemberForm.HOFID;
                String Fname = txtFname.Text;
                String Sname = txtSname.Text;
                String Tname = txtTname.Text;
                String Family = txtFamiliyName.Text;
                String MemberID = txtIdentity.Text;
                DateTime Birth = Convert.ToDateTime(txtDOB.Text);

                String Vul1 = cbVul1.SelectedIndex == 0 ? "" : cbVul1.Text;
                String Vul2 = cbVul2.SelectedIndex == 0 ? "" : cbVul2.Text;
                String Vul3 = cbVul3.SelectedIndex == 0 ? "" : cbVul3.Text;
                String Gender = cbGender.Text;


                if (MemberID != "" && Fname != "" && Sname != "" && Tname != "" && Family != "" && txtDOB.Text != "" && cbGender.SelectedIndex != 0)
                {

                    FamiliesShelterDataSetTableAdapters.QueriesTableAdapter qAdapter = new FamiliesShelterDataSetTableAdapters.QueriesTableAdapter();

                    int? res = qAdapter.GetCountsOfMember(MemberID);
                    if (res == 0)
                    {
                        var subdays = DateTime.Now.Subtract(Birth).TotalDays;

                        if (subdays >= 0)
                        {
                            FamiliesShelterDataSetTableAdapters.DataTableAdapter adapter = new FamiliesShelterDataSetTableAdapters.DataTableAdapter();




                            //int status = adapter.Insert1(HoFID, Fname, Sname, Tname, Family, MemberID, Birth, Gender, cbGender.SelectedIndex == 1 ? Options.SON : Options.DAUGHTER, Vul1, Vul2, Vul3, Options.ADD, false);


                            Info();

                            btnNewMember_Click(sender, null);
                        }
                        else
                        { Error("تاريخ الميلاد غير صحيح"); }
                    }
                    else
                    {
                        Error("لقد تم تسجيل هذا الاسم سابقا");
                    }


                }
                else
                { Error("يجب إضافة البيانات وملء الفراغات"); }
            }
            catch
            { Error("خطأ غير متوقع"); }
        }

        private void Info()
        {
            MessageBox.Show(Options.SAVE_SUCCESFULLY, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtFamiliyName_TextChanged(object sender, EventArgs e)
        {

        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void MemberForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                btnSave_Click(sender, e);
            }
            else if ((e.KeyCode == Keys.F4))
            {
                btnNewMember_Click(sender, e);
            }
            else if (e.KeyCode == Keys.Escape)
            {
                btnClose_Click(sender, e);
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

        private void btnNewMember_Click(object sender, EventArgs e)
        {
            txtIdentity.Text = "";
            ClearData();
        }
    }
}
