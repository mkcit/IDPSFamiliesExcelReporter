using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace IDPSFamiliesExcelReporter
{
    public partial class IDPForm : Form 
    {
        public IDPForm()
        {
            InitializeComponent();
        }

  

        private  void txtIdentity_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //ClearData();
                if (txtIdentity.Text != "")
                {
                    GazaPeopleDataSet.DataDataTable gpDT = new GazaPeopleDataSet.DataDataTable();


                    GazaPeopleDataSetTableAdapters.DataTableAdapter gpTableAdapter = new GazaPeopleDataSetTableAdapters.DataTableAdapter();

                    gpTableAdapter.Fill(gpDT, txtIdentity.Text);

                    if (gpDT.Rows.Count > 0)
                    {
                        FillData(gpDT.Rows[0]);
                    }

                    BindGridView();

                }

            }
            

        }

        private void BindGridView()
        {
            FamiliesShelterDataSet.DataDataTable fisDT = new FamiliesShelterDataSet.DataDataTable();

            FamiliesShelterDataSetTableAdapters.DataTableAdapter fisTableAdapter = new FamiliesShelterDataSetTableAdapters.DataTableAdapter();
            fisTableAdapter.Fill(fisDT, txtIdentity.Text);


            gvFamliyMembersExportedToExcel.AutoGenerateColumns = true;
            gvFamliyMembersExportedToExcel.DataSource = fisDT;
            
        }

        private void ActiveButtons(bool v)
        {
            btnAddWife.Enabled = v;
            btnAddSonsDaughters.Enabled = v;
        }

        private void FillData(DataRow dataRow)
        {
            txtFname.Text= dataRow[1].ToString();
            txtSname.Text = dataRow[2].ToString();
            txtTname.Text = dataRow[3].ToString();
            txtFamiliyName.Text = dataRow[4].ToString();
            txtDOB.Text = Convert.ToDateTime( dataRow[6].ToString()).ToShortDateString();

            if (dataRow[7].ToString() == "1")
                cbGender.Text = "ذكر";
            else cbGender.Text = "أنثي";
            if (cbGender.Text == "أنثي")
            {
                cbVul1.SelectedIndex = 7;
            }
        }

        private void ClearData()
        {
            txtIdentity.Focus();
            txtFname.Text = "";
            txtSname.Text = "";
            txtTname.Text = "";
            txtFamiliyName.Text = "";
            txtDOB.Text = "";
            cbGender.SelectedIndex = 1;
            cbVul1.SelectedIndex = 0;
            cbVul2.SelectedIndex = 0;
            cbVul3.SelectedIndex = 0;


            gvFamliyMembersExportedToExcel.DataSource = null;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ClearData();



           // btnSave.Enabled = true;
        }
        private void Info()
        {
            MessageBox.Show(Options.SAVE_SUCCESFULLY, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                String HoFID = txtIdentity.Text;
                String Fname = txtFname.Text;
                String Sname = txtSname.Text;
                String Tname = txtTname.Text;
                String Family = txtFamiliyName.Text;
                String MemberID = HoFID;
                DateTime Birth = Convert.ToDateTime(txtDOB.Text);

                String Vul1 = cbVul1.SelectedIndex == 0 ? "" : cbVul1.Text;
                String Vul2 = cbVul2.SelectedIndex == 0 ? "" : cbVul2.Text;
                String Vul3 = cbVul3.SelectedIndex == 0 ? "" : cbVul3.Text;
                String Gender = cbGender.Text;

                if (HoFID != "" && Fname != "" && Sname != "" && Tname != "" && Family != "" && txtDOB.Text != "" && cbGender.SelectedIndex != 0)
                {
                    FamiliesShelterDataSetTableAdapters.QueriesTableAdapter qAdapter = new FamiliesShelterDataSetTableAdapters.QueriesTableAdapter();


                    int? res = qAdapter.GetCountsOfMember(HoFID);
                    if (res == 0)
                    {
                        var subdays = DateTime.Now.Subtract(Birth).TotalDays;

                        if (subdays > 1000)
                        {
                            FamiliesShelterDataSetTableAdapters.DataTableAdapter adapter = new FamiliesShelterDataSetTableAdapters.DataTableAdapter();

                            //int status = 
                            //    adapter.Insert1(HoFID, Fname, Sname, Tname, Family, MemberID, Birth, Gender, Options.HIMSELF, Vul1, Vul2, Vul3, Options.ADD, false);

                            ////MessageBox.Show(status.ToString());
                            //if (status > 0)
                            //{
                            //    BindGridView();
                            //}

                            Info();

                            //btnSave.Enabled = false;
                        }
                        else
                        {
                            Error("يبدو أن تاريخ الميلاد غير صحيح");
                        }
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

        private void Error(string msg)
        {
            MessageBox.Show(this, msg, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnAddWife_Click(object sender, EventArgs e)
        {
            if ( txtIdentity.Text != "")
            {

                if (cbGender.SelectedIndex == 1)
                {
                    WifeForm.HOFID = txtIdentity.Text;
                    WifeForm frm = new WifeForm();
                    frm.ShowDialog();
                    BindGridView();
                }
                else
                {
                    Error("نعتقد أن رب الأسرة هي من النساء لذلك لا يمكن أن يكون هناك زوجة");
                }
            }
            else
            { Error("يجب أن يكون هناك رقم هوية"); }
        }

        private void btnAddSonsDaughters_Click(object sender, EventArgs e)
        {
            MemberForm frm = new MemberForm();
            if (txtFname.Text != "" && txtSname.Text != "" && txtFamiliyName.Text != "" && txtIdentity.Text != "")
            {

                if (cbGender.SelectedIndex == 1)
                {
                    MemberForm.SName = txtFname.Text;
                    MemberForm.TName = txtSname.Text;
                    MemberForm.LName = txtFamiliyName.Text;
                    frm.TextsEnabled(false);
                }
                else
                {
                    MemberForm.SName = "";
                    MemberForm.TName = "";
                    MemberForm.LName = "";
                    frm.TextsEnabled(true);
                }   
                
                
                MemberForm.HOFID = txtIdentity.Text;
                frm.ShowDialog();

                BindGridView();
            }
            else
            { Error("يجب أن يكون هناك رقم هوية واسم للوالد"); }
        }

        private void gvFamliyMembersExportedToExcel_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            
            for (int i = 0; i < gvFamliyMembersExportedToExcel.Rows.Count; i++)
            {
                //DataGridViewRow row = gvFamliyMembersExportedToExcel.Rows[i];

                String relation = gvFamliyMembersExportedToExcel.Rows[i].Cells[8].Value.ToString();
                ////MessageBox.Show(relation);
                if (relation.Contains(Options.HIMSELF))
                {
                    gvFamliyMembersExportedToExcel.Rows[i].DefaultCellStyle.BackColor = Color.LightBlue;
                }
                else if (relation.Contains(Options.WIFE))
                {
                    gvFamliyMembersExportedToExcel.Rows[i].DefaultCellStyle.BackColor = Color.HotPink;
                }
                else if (relation.Contains(Options.SON))
                {
                    gvFamliyMembersExportedToExcel.Rows[i].DefaultCellStyle.BackColor = Color.LightGreen;
                }
                else if (relation.Contains(Options.DAUGHTER))
                {
                    gvFamliyMembersExportedToExcel.Rows[i].DefaultCellStyle.BackColor = Color.LightPink;
                }
            }
        }

        private void IDPForm_KeyDown(object sender, KeyEventArgs e)
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
            else if (e.KeyCode == Keys.F1)
            {
                cbGender.SelectedIndex = 1;
            }
            else if (e.KeyCode == Keys.F2)
            {
                cbGender.SelectedIndex = 2;
            }
        }

        private void btnNewIDP_Click(object sender, EventArgs e)
        {
            txtIdentity.Text = "";
            ClearData();

            //btnSave.Enabled = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Dispose( );
        }

        private void cbGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbGender.SelectedIndex == 2)
            {
                cbVul1.SelectedIndex = 7;
            }
            else
            {
                cbVul1.SelectedIndex = 0;
            }
        }
    }
}
