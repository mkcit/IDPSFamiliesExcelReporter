using IDPSFamiliesExcelReporter.FamiliesShelterDataSetTableAdapters;
using OfficeOpenXml;
using System;
using System.Data.Common;
using System.IO;
using System.Windows.Forms;
using static IDPSFamiliesExcelReporter.FamiliesShelterDataSet;

namespace IDPSFamiliesExcelReporter
{
	public partial class ExportToExcelForm : Form
	{

		private DataDataTable dt;
		private DataTableAdapter adapter;
		public ExportToExcelForm()
		{
			InitializeComponent();
		}

		private void ExportToExcel_Load(object sender, EventArgs e)
		{
			 dt = new DataDataTable();
			 adapter = new DataTableAdapter();

			dt = adapter.GetNotExportedData();
			gvExportToExcel.DataSource = dt;
		}
		private void Info(String filename)
		{
			MessageBox.Show("تمت عملية تصدير المعلومات إلى ملف إكسل بنجاح  " + filename, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void Error(string msg)
		{
			MessageBox.Show(this, msg, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}
		private void btnExportToExcel_Click(object sender, EventArgs e)
		{
			try
			{
				ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
				String path = @"c:\db\members_" + DateTime.Now.ToShortDateString().Replace("/", "_") + "_" + DateTime.Now.ToLongTimeString().Replace(":", "_").Replace(" ", "_") + ".xlsx";


				bool fileExists = File.Exists(path);
				using (var package = new ExcelPackage(new FileInfo(path)))
				{
					ExcelWorksheet worksheet;
					if (fileExists)
					{
						worksheet = package.Workbook.Worksheets[0];
					}
					else
					{
						worksheet = package.Workbook.Worksheets.Add("Sheet1");
					}



					if (dt != null && adapter != null)
					{
						for (int i = 1; i <= dt.Rows.Count; i++)
						{

							worksheet.Cells[i, 1].Value = dt.Rows[i - 1][0];//HOF ID
							//MessageBox.Show(dt.Rows[i - 1][0].ToString());
							worksheet.Cells[i, 2].Value = dt.Rows[i - 1][1];//FName
							//MessageBox.Show(dt.Rows[i - 1][1].ToString());
							worksheet.Cells[i, 3].Value = dt.Rows[i - 1][2];// SName
							//MessageBox.Show(dt.Rows[i - 1][2].ToString());
							worksheet.Cells[i, 4].Value = dt.Rows[i - 1][3];//TName
							//MessageBox.Show(dt.Rows[i - 1][3].ToString());
							worksheet.Cells[i, 5].Value = dt.Rows[i - 1][4];//FamilyName
							//MessageBox.Show(dt.Rows[i - 1][4].ToString());
							worksheet.Cells[i, 6].Value = dt.Rows[i - 1][5];//MemeberID
							//MessageBox.Show(dt.Rows[i - 1][5].ToString());
							worksheet.Cells[i, 7].Value = dt.Rows[i - 1][6];//Birth
							//MessageBox.Show(dt.Rows[i - 1][6].ToString());
							worksheet.Cells[i, 8].Value = dt.Rows[i - 1][7];//Gender
							//MessageBox.Show(dt.Rows[i - 1][7].ToString());
							worksheet.Cells[i, 9].Value = dt.Rows[i - 1][8];//Rel
																			//MessageBox.Show(dt.Rows[i - 1][8].ToString());


							worksheet.Cells[i, 10].Value = null;
							worksheet.Cells[i, 10].Value = Convert.ToString(dt.Rows[i - 1][9]);//Vul
																							   //MessageBox.Show(worksheet.Cells[i, 10].Value.ToString().Length.ToString());
																							   //MessageBox.Show(dt.Rows[i - 1][9].ToString());
							worksheet.Cells[i, 11].Value = null;
							worksheet.Cells[i, 11].Value = Convert.ToString(dt.Rows[i - 1][10]);//Vul
																								//MessageBox.Show(worksheet.Cells[i, 11].Value.ToString().Length.ToString());
																								//MessageBox.Show(dt.Rows[i - 1][10].ToString());
							worksheet.Cells[i, 12].Value = null;
							worksheet.Cells[i, 12].Value = Convert.ToString(dt.Rows[i - 1][11]);//Vul
																								//MessageBox.Show(worksheet.Cells[i, 12].Value.ToString().Length.ToString());
																								//MessageBox.Show(dt.Rows[i - 1][11].ToString());
							worksheet.Cells[i, 13].Value = null;
							worksheet.Cells[i, 13].Value = Convert.ToString(dt.Rows[i - 1][12]);//Vul
																								//MessageBox.Show(worksheet.Cells[i, 13].Value.ToString().Length.ToString());
																								//MessageBox.Show(dt.Rows[i - 1][14].ToString());
							worksheet.Cells[i, 14].Value = null;
							worksheet.Cells[i, 14].Value = Convert.ToString(dt.Rows[i - 1][13]);//Vul
																								//MessageBox.Show(worksheet.Cells[i, 14].Value.ToString().Length.ToString());
																								//MessageBox.Show(dt.Rows[i - 1][15].ToString());
							worksheet.Cells[i, 15].Value = null;
							worksheet.Cells[i, 15].Value = Convert.ToString(dt.Rows[i - 1][14]);//Vul
																												 //MessageBox.Show(dt.Rows[i - 1][16].ToString());
																												 //worksheet.Cells[i, 16].Value = dt.Rows[i - 1][15];//تم// تم
																												 //MessageBox.Show(dt.Rows[i - 1][16].ToString());
							worksheet.Cells[i, 16].Value = dt.Rows[i - 1][16];//ACTION
							//MessageBox.Show(dt.Rows[i - 1][16].ToString());
							worksheet.Cells[i, 17].Value = dt.Rows[i - 1][17];//mOBILE
							worksheet.Cells[i, 18].Value = dt.Rows[i - 1][18];//UNCARD



							//                     MessageBox.Show(dt.Rows[i - 1][0].ToString());
							//MessageBox.Show(dt.Rows[i - 1][1].ToString());
							//MessageBox.Show(dt.Rows[i - 1][2].ToString());
							//MessageBox.Show(dt.Rows[i - 1][3].ToString());
							//MessageBox.Show(dt.Rows[i - 1][4].ToString());
							//MessageBox.Show(dt.Rows[i - 1][5].ToString());
							//MessageBox.Show(dt.Rows[i - 1][6].ToString());
							//MessageBox.Show(dt.Rows[i - 1][7].ToString());
							//MessageBox.Show(dt.Rows[i - 1][8].ToString());
							//MessageBox.Show(dt.Rows[i - 1][9].ToString());
							//MessageBox.Show(dt.Rows[i - 1][10].ToString());
							//MessageBox.Show(dt.Rows[i - 1][11].ToString());
							//MessageBox.Show(dt.Rows[i - 1][12].ToString());
							//MessageBox.Show(dt.Rows[i - 1][13].ToString());
							//MessageBox.Show(dt.Rows[i - 1][14].ToString());
							//MessageBox.Show(dt.Rows[i - 1][15].ToString());
							//MessageBox.Show(dt.Rows[i - 1][16].ToString());

							String MemberID = dt.Rows[i - 1][5].ToString();
							adapter.UpdateIsExported(true, MemberID);

						}

						if (dt.Rows.Count > 0)
						{
							package.Save();
							Info(path);
						}
						else
						{
							Error("لايوجد بيانات لتصديرها");
						}

					}

				}
			}
			catch (Exception ex)
			{

				Error(ex.Message);
			}


		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void ExportToExcelForm_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.F5)
			{
				btnExportToExcel_Click(sender, e);
			}

			else if (e.KeyCode == Keys.Escape)
			{
				btnClose_Click(sender, e);
			}

		}
	}
}
