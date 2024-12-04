using System;
using System.Data;
using System.Data.OleDb;
using System.Security.Principal;
using System.Windows.Forms;
using System.Xml.Linq;

namespace IDPSFamiliesExcelReporter
{
	public partial class SearchFormGaza : Form
	{
		internal static bool activate = false;
		internal int pageIndex = 1;
		private OleDbConnection dbConnection;

		public SearchFormGaza()
		{
			dbConnection = new OleDbConnection(Properties.Settings.Default.GazaPeopleCS);
			InitializeComponent();
		}

		private  void BindGridView()
		{
			gvSearch.Focus();

			String Identity = txtIdentity.Text;
			String FName = txtFname.Text;
			String SName = txtSname.Text;
			string TName = txtTName.Text;
			String Family = txtFamiliyName.Text;
			if (Identity == "" && FName == "" && SName == "" && TName == "" && Family == "") return;

			String cond = " where ";
			//if (Identity != "" || FName != "" || SName != "" || Family != "")
			//{
			//	cond = " where ";
			//}

			if (Identity != "")
			{
				cond += " Identity like '%" + Identity + "%'";
			}
			if (FName != "")
			{
				if (Identity != "") cond += " and ";
				cond += " FName like '%" + FName + "%'";
			}
			if (SName != "")
			{
				if (FName != "" || Identity != "") cond += " and ";
				cond += " SName like '%" + SName + "%'";
			}
			if (TName != "")
			{
				if (FName != "" || Identity != "" || SName != "") cond += " and ";
				cond += " TName like '%" + TName + "%'";
			}
			if (Family != "")
			{
				if (FName != "" || Identity != "" || SName != "" || TName != "") cond += " and ";
				cond += " LName like '%" + Family + "%'";
			}

			//Task.Run(() =>
			{


				int MaxRows = 1000;
				int page = pageIndex * MaxRows + 1;




				string sql = "SELECT[Identity] as [رقم الهويه], FName AS[الاسم], SName AS[الاب],TName AS[الجد], " +
					"LName AS العائلة, MotherName AS[اسم الأم], DOB AS[تاريخ الميلاد]  FROM( " +
				"SELECT TOP " + MaxRows + " * FROM( " +
				"SELECT   top " + page + " * FROM Data " + cond + " ORDER BY[Identity] " +
				")AS Temp ORDER BY[Identity]  DESC " +
				")AS Temp2 ORDER BY Temp2.[Identity]  ";


				OleDbCommand command = new OleDbCommand(sql, dbConnection);

				dbConnection.Open();
				OleDbDataReader reader = command.ExecuteReader();

				DataTable dt = new DataTable();
				//BindingSource bs = new BindingSource();
				dt.Load(reader);

				//bs.DataSource = dt;
				gvSearch.DataSource = dt;

				dbConnection.Close();


			}
			//);
			
		}

		private void txtIdentity_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
				SearchAction(sender, e);
		}

		private void SearchAction(object sender, KeyEventArgs e)
		{
			BindGridView();
		}

		private void UnBindGridView()
		{
			gvSearch.DataSource = null;
		}

		private void txtFname_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
				SearchAction(sender, e);
		}

		private void txtSname_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
				SearchAction(sender, e);
		}

		private void txtFamiliyName_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
				SearchAction(sender, e);
		}

		private void SearchForm_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape)
			{
				Close();
			}
		}

		private void gvSearch_KeyUp(object sender, KeyEventArgs e)
		{

			if (e.Control && e.KeyCode == Keys.C)
			{
				if (gvSearch.Rows.Count > 0)
				{
					if (gvSearch.SelectedRows.Count > 0)
					{

						Options.copy_data.Clear();
						string identity = gvSearch.SelectedRows[0].Cells[1].Value.ToString();
						string FName = gvSearch.SelectedRows[0].Cells[2].Value.ToString();
						string SName = gvSearch.SelectedRows[0].Cells[3].Value.ToString();
						string TName = gvSearch.SelectedRows[0].Cells[4].Value.ToString();
						string LName = gvSearch.SelectedRows[0].Cells[5].Value.ToString();
						DateTime DOB = Convert.ToDateTime(gvSearch.SelectedRows[0].Cells[7].Value);


						Options.copy_data.Add(identity);
						Options.copy_data.Add(FName);
						Options.copy_data.Add(SName);
						Options.copy_data.Add(TName);
						Options.copy_data.Add(LName);
						Options.copy_data.Add(DOB);


						MessageBox.Show(Options.copy_data[0].ToString() + ", " + Options.copy_data[1].ToString() + ", " + Options.copy_data[2].ToString() + ", " + Options.copy_data[3].ToString() + ", " + Options.copy_data[4].ToString() + ", " + Options.copy_data[5].ToString());


					}
				}
			}
		}

		private void SearchFormGaza_Load(object sender, EventArgs e)
		{
			//txtPageNumber.Text = pageIndex.ToString();
		}

		private void txtTName_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
				SearchAction(sender, e);
		}

		private void SearchFormGaza_FormClosing(object sender, FormClosingEventArgs e)
		{
			SearchFormGaza.activate=false;
		}

		private void btnNext_Click(object sender, EventArgs e)
		{
			//if (!isLastPage())
			//{
			//	pageIndex++;
			//	txtPageNumber.Text = pageIndex.ToString();

			//	BindGridView();
			//}
		}

		private bool isLastPage()
		{
			return false;
		}

		private void btnPrevious_Click(object sender, EventArgs e)
		{
			//if (!isFirstPage())
			//{
			//	pageIndex--;
			//	txtPageNumber.Text = pageIndex.ToString();
			//	BindGridView();
			//}
		}

		private bool isFirstPage()
		{
			if (pageIndex == 1) return true;
			return false;
		}

		private void gvSearch_CellValueNeeded(object sender, DataGridViewCellValueEventArgs e)
		{
			MessageBox.Show(e.Value.ToString());
		}

		private void gvSearch_Scroll(object sender, ScrollEventArgs e)
		{
			if (e.ScrollOrientation == ScrollOrientation.VerticalScroll && e.NewValue >= gvSearch.Rows.Count - 1)
			{
				// Load More Data();
			}
		}

		private void gvSearch_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex > -1)
			{
				String id = gvSearch.Rows[e.RowIndex].Cells[1].Value.ToString();
				String fname = gvSearch.Rows[e.RowIndex].Cells[2].Value.ToString();
				String sname = gvSearch.Rows[e.RowIndex].Cells[3].Value.ToString();
				String tname = gvSearch.Rows[e.RowIndex].Cells[4].Value.ToString();

				DateTime DOB = Convert.ToDateTime(gvSearch.SelectedRows[0].Cells[7].Value);
				String familyName = gvSearch.Rows[e.RowIndex].Cells[5].Value.ToString();
				
				
				Clipboard.SetText($"{id}");
				Options.copy_data.Clear();
				Options.copy_data.Add(DateTime.Now);
				Options.copy_data.Add(id);
				Options.copy_data.Add(fname);
				Options.copy_data.Add(sname);
				Options.copy_data.Add(tname);
				Options.copy_data.Add(familyName);
				Options.copy_data.Add(DOB);
			}
		}

		private void btnNewSearch_Click(object sender, EventArgs e)
		{
			txtFamiliyName.Text = "";
			txtFname.Text = "";
			txtTName.Text = "";
			txtSname.Text = "";
			txtIdentity.Text = "";

			Options.copy_data.Clear();
			gvSearch.DataSource = null;
		}

		private void btnSearch_Click(object sender, EventArgs e)
		{
			SearchAction(null,null);
		}
	}
}
