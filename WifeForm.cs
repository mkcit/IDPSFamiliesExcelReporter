using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IDPSFamiliesExcelReporter
{
    public partial class WifeForm : Form
    {
        internal static string HOFID;

        public WifeForm()
        {
            InitializeComponent();
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
            //txtIdentity.Text = "";
            txtFname.Text = "";
            txtSname.Text = "";
            txtTname.Text = "";
            txtFamiliyName.Text = "";
            txtDOB.Text = "";
            cbGender.SelectedIndex = 2;
            cbVul1.SelectedIndex = 0;
            cbVul2.SelectedIndex = 0;
            cbVul3.SelectedIndex = 0;
        }
        private void WifeForm_Load(object sender, EventArgs e)
        {
            ClearData();

            cbGender.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                String HoFID = WifeForm.HOFID;
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

                        if (subdays > 1000)
                        {
                            if (cbGender.SelectedIndex == 2)
                            {
                                FamiliesShelterDataSetTableAdapters.DataTableAdapter adapter = new FamiliesShelterDataSetTableAdapters.DataTableAdapter();
                                //int status = adapter.Insert1(HoFID, Fname, Sname, Tname, Family, MemberID, Birth, Gender, Options.WIFE, Vul1, Vul2, Vul3, Options.ADD, false);


                                Info();
                                btnClose_Click(sender, null);

                            }
                            else
                            {
                                Error("النوع الاجتماعي يمثل خطأ .. حاول التأكد من دقة المعلومات");
                            }
                        }
                        else
                        {

                            Error("تاريخ الميلاد غير صحيح");
                        }
                    }
                    else
                    {
                        Error("لقد تم تسجيل هذا الاسم سابقا");
                    }


                }
                else
                {
                    Error("يجب إضافة البيانات وملء الفراغات");
                }
            }
            catch
            { Error("خطأ غير متوقع"); }
        }
        private void Info()
        {
            MessageBox.Show(Options.SAVE_SUCCESFULLY, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnNewIDP_Click(object sender, EventArgs e)
        {

            txtIdentity.Text = "";
            ClearData();
        }

        private void WifeForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                btnSave_Click(sender, e);
            }
            else if ((e.KeyCode == Keys.F4))
            {
                btnNewIDP_Click(sender, e);
            }
            else if (e.KeyCode == Keys.Escape)
            {
                btnClose_Click(sender, e);
            }
        }

        private void Error(string msg)
        {
            MessageBox.Show(this, msg, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void txtIdentity_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
