﻿using System;
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
			//BindGridView();

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
				cond += " MemberID='" + Identity + "'";
			}
			if (FName != "")
			{
				if (Identity != "") cond += " and ";
				cond += " Fname like '%" + FName + "%'";
			}
			if (SName != "")
			{
				if (FName != "" || Identity != "") cond += " and ";
				cond += " Sname like '%" + SName + "%'";
			}
			if (Family != "")
			{
				if (FName != "" || Identity != "" || SName != "") cond += " and ";
				cond += " Family like '%" + Family + "%'";
			}

			String sql = "SELECT HoFID AS [هوية رب الاسرة], Fname AS الاسم, Sname AS الاب, Tname AS الجد, Family AS العائلة, MemberID AS [هوية الفرد], Birth AS الميلاد, Gender AS التوع, Relation AS العلاقة, Vul1 AS هشاشة1, Vul2 AS هشاشة2, Vul3 AS هشاشة3, Vul4 AS هشاشة4, Vul5 AS هشاشة5, Vul6 AS هشاشة6, IsExported AS [إلى إكسل] ,[Action],RegDate as [تاريخ التسجيل] FROM Data " + cond;


			//MessageBox.Show(sql);
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
			SearchAction(sender, e);
		}

		private void SearchAction(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				if (((TextBox)sender).Text != "")
					BindGridView();
				else
					UnBindGridView();
			}
		}

		private void UnBindGridView()
		{
			gvSearch.DataSource = null;
		}

		private void txtFname_KeyDown(object sender, KeyEventArgs e)
		{
			SearchAction(sender, e);
		}

		private void txtSname_KeyDown(object sender, KeyEventArgs e)
		{
			SearchAction(sender, e);
		}

		private void txtFamiliyName_KeyDown(object sender, KeyEventArgs e)
		{
			SearchAction(sender, e);
		}

		private void gvSearch_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex != -1 && e.ColumnIndex != -1)
			{
				DataGridViewRow dataGridViewRow = gvSearch.Rows[e.RowIndex];
				String Identity = dataGridViewRow.Cells[0].Value.ToString();

				String Relation = dataGridViewRow.Cells[8].Value.ToString();

				UpdateIDPForm form = new UpdateIDPForm();

				if (Relation == "ابن" || Relation == "ابنه")
				{
					form.txtFamiliyName.ReadOnly = true;
					form.txtTname.ReadOnly = true;
					form.txtSname.ReadOnly = true;
				}
				else if (Relation == "نفسه (رب الاسرة)")
				{
					form.txtFname.ReadOnly = true;
					form.txtFamiliyName.ReadOnly = true;
					form.txtTname.ReadOnly = true;
					form.txtSname.ReadOnly = true;
				}
				else
				{
					form.txtFamiliyName.ReadOnly = false;
					form.txtTname.ReadOnly = false;
					form.txtSname.ReadOnly = false;
				}



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
				UpdateIDPForm.Vul4 = dataGridViewRow.Cells[12].Value.ToString();
				UpdateIDPForm.Vul5 = dataGridViewRow.Cells[13].Value.ToString();
				UpdateIDPForm.Vul6 = dataGridViewRow.Cells[14].Value.ToString();

				//            MessageBox.Show(UpdateIDPForm.Vul1);
				//MessageBox.Show(UpdateIDPForm.Vul2);
				//MessageBox.Show(UpdateIDPForm.Vul3);
				//MessageBox.Show(UpdateIDPForm.Vul4);
				//MessageBox.Show(UpdateIDPForm.Vul5);
				//MessageBox.Show(UpdateIDPForm.Vul6);

				UpdateIDPForm.IsExportedToExcel = Convert.ToBoolean(dataGridViewRow.Cells[15].Value.ToString());
				UpdateIDPForm.Action = dataGridViewRow.Cells[16].Value.ToString();

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
					DialogResult res = MessageBox.Show("هل تريد حذف هذا الفرد ؟", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
					if (res == DialogResult.Yes)
					{
						if (gvSearch.SelectedRows.Count > 0)
						{
							DataGridViewRow dataGridViewRow = gvSearch.SelectedRows[0];
							String Identity = dataGridViewRow.Cells[5].Value.ToString();

							FamiliesShelterDataSetTableAdapters.DataTableAdapter qAdapter = new FamiliesShelterDataSetTableAdapters.DataTableAdapter();

							bool IsExportedToExcel = Convert.ToBoolean(dataGridViewRow.Cells[15].Value.ToString());

							String CurrentAction = dataGridViewRow.Cells[16].Value.ToString();
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

		private void btnNewSearch_Click(object sender, EventArgs e)
		{
			txtIdentity.Text = "";
			txtFname.Text = "";
			txtSname.Text = "";
			txtFamiliyName.Text = "";
			gvSearch.DataSource = null;
		}
	}
}
