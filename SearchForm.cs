using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace IDPSFamiliesExcelReporter
{
    public partial class SearchForm : Form
    {
        public SearchForm()
        {
            InitializeComponent();
        }

        private void SearchForm_Load(object sender, EventArgs e)
        {
            BindGridView();

        }

        private void BindGridView()
        {
            OleDbConnection dbConnection = new OleDbConnection(Properties.Settings.Default.FamiliesInShelteCS);


            String Identity = txtIdentity.Text;
            String FName = txtFname.Text;
            String SName = txtSname.Text;
            String Family = txtFamiliyName.Text;

            String cond = "";
            if (Identity != "" || FName != "" || SName != "" || Family != "")
            {
                cond = " where ";
            }

            if (Identity != "")
            {
                cond += " MemberID='" + Identity+"'";
            }
            if (FName != "")
            {
                cond += " Fname like '%" + FName + "%'";
            }
            if (SName != "")
            {
                cond += " Sname like '%" + SName + "%'";
            }
            if (Family != "")
            {
                cond += " Family like '%" + Family + "%'";
            }

            String sql = "SELECT HoFID AS [هوية رب الاسرة], Fname AS الاسم, Sname AS الاب, Tname AS الجد, Family AS العائلة, MemberID AS [هوية الفرد], Birth AS الميلاد, Gender AS التوع, Relation AS العلاقة, Vul1 AS هشاشة1, Vul2 AS هشاشة2, Vul3 AS هشاشة3, Vul4 AS هشاشة4, Vul5 AS هشاشة5, Vul6 AS هشاشة6, IsExported AS [إلى إكسل], [Action] FROM Data " + cond;
            OleDbCommand command = new OleDbCommand(sql, dbConnection);

            dbConnection.Open();


            OleDbDataReader reader = command.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);



            gvSearch.DataSource = dt.DefaultView;
            dbConnection.Close();
        }

        private void txtIdentity_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                BindGridView();
        }

        private void txtFname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                BindGridView();
        }

        private void txtSname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                BindGridView();
        }

        private void txtFamiliyName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                BindGridView();
        }

        private void gvSearch_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                DataGridViewRow dataGridViewRow = gvSearch.Rows[e.RowIndex];
                String Identity = dataGridViewRow.Cells[0].Value.ToString();


                UpdateIDPForm form = new UpdateIDPForm();
                UpdateIDPForm.MemberID = dataGridViewRow.Cells[5].Value.ToString(); ;
                UpdateIDPForm.Fname = dataGridViewRow.Cells[1].Value.ToString();
                UpdateIDPForm.Sname = dataGridViewRow.Cells[2].Value.ToString(); ;
                UpdateIDPForm.Tname = dataGridViewRow.Cells[3].Value.ToString(); ;
                UpdateIDPForm.FamilyName = dataGridViewRow.Cells[4].Value.ToString(); ;
                UpdateIDPForm.Gender = dataGridViewRow.Cells[7].Value.ToString();
                UpdateIDPForm.DOB = Convert.ToDateTime(dataGridViewRow.Cells[6].Value.ToString());
                UpdateIDPForm.Vul1 = dataGridViewRow.Cells[9].Value.ToString();
                UpdateIDPForm.Vul2 = dataGridViewRow.Cells[10].Value.ToString();
                UpdateIDPForm.Vul3 = dataGridViewRow.Cells[11].Value.ToString();
                UpdateIDPForm.IsExportedToExcel = Convert.ToBoolean(dataGridViewRow.Cells[15].Value.ToString());
                UpdateIDPForm.Action = dataGridViewRow.Cells[13].Value.ToString();

                form.ShowDialog();

                BindGridView();
            }

        }
        private void Info()
        {
            
            MessageBox.Show(Options.SAVE_SUCCESFULLY, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void gvSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (gvSearch.Rows.Count > 0)
                {
                    if (gvSearch.SelectedRows.Count > 0)
                    {
                        DataGridViewRow dataGridViewRow = gvSearch.SelectedRows[0];
                        String Identity = dataGridViewRow.Cells[5].Value.ToString();

                        FamiliesShelterDataSetTableAdapters.DataTableAdapter qAdapter = new FamiliesShelterDataSetTableAdapters.DataTableAdapter();
                        
                        bool IsExportedToExcel=Convert.ToBoolean(dataGridViewRow.Cells[15].Value.ToString());

                        String CurrentAction = dataGridViewRow.Cells[13].Value.ToString();
                        String Action = CurrentAction;

                        if (IsExportedToExcel)
                        {
                            if (CurrentAction == "إضافة")
                            {
                                //Action = "حذف";
                                qAdapter.UpdateAction(Options.DELETE, Identity);
                                Info();
                                BindGridView();
                            }
                            else if (CurrentAction == "تعديل")
                            {
                                //Action = "حذف";
                                qAdapter.UpdateAction(Options.DELETE, Identity);
                                Info();
                                BindGridView();
                            }
                            else
                            {
                                //Do Nothing
                                
                            }
                        }
                        else
                        {
                            if (CurrentAction == "إضافة")
                            {
                                // Remove Completely
                                DialogResult dialogResult = MessageBox.Show(this, "ستقوم بحذف النازح بشكل نهائي هل أنت متاكد ؟", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                                if (dialogResult == DialogResult.Yes)
                                {
                                    qAdapter.DeleteIDP(Identity);
                                    Info();
                                    BindGridView();
                                }

                            }
                            else if (CurrentAction == "تعديل")
                            {
                                qAdapter.UpdateAction(Options.DELETE, Identity);
                                Info();
                                BindGridView();
                            }
                            else
                            {
                                //Do Nothing

                            }
                        }

                        //if (dataGridViewRow.Cells[13].Value.ToString() == "إضافة")
                        //{
                        //    //DialogResult dialogResult = MessageBox.Show(this,"ستقوم بحذف النازح بشكل نهائي هل أنت متاكد ؟","",MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        //    //if (dialogResult == DialogResult.Yes)
                        //    //{
                        //    //    qAdapter.DeleteIDP(Identity);
                        //    //    Info();
                        //    //    BindGridView();
                        //    //}
                        //}
                        //else
                        //{
                        //    //qAdapter.UpdateAction(Options.DELETE, Identity);
                        //    //Info();
                        //    //BindGridView();
                        //}
                    }

                }
            }
        }

        private void gvSearch_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SearchForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Dispose();
            }
        }
    }
}
