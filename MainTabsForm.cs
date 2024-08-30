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
	public partial class MainTabsForm : Form
	{
		public MainTabsForm()
		{
			InitializeComponent();
		}

		
		private void btnSave_Click(object sender, EventArgs e)
		{
			//GazaPeopleDataSet.DataDataTable gpDT =
			//  new GazaPeopleDataSet.DataDataTable();


			//GazaPeopleDataSetTableAdapters.DataTableAdapter gpTableAdapter =
			//	new GazaPeopleDataSetTableAdapters.DataTableAdapter();



			//if (gvIDPOperation.Rows.Count > 0)
			//{
			//	String HOFID = gvIDPOperation.Rows[0].Cells[0].Value.ToString();
			//	int HOFState = Convert.ToInt32(gvIDPOperation.Rows[0].Cells[15].Value);
			//	if (HOFID != "")
			//	{


			//		if (HOFState != 1)
			//		{
			//			// Process The Data
			//			gpDT = gpTableAdapter.GetData(HOFID);
			//			if (IsFoundInDB(gpDT))
			//			{
			//				PrintHOFInLabels(gpDT);
			//				FillCellsInGridView(gpDT, 0);
			//				SetSuccessRowStyleInGridView(0, 1, "البيانات سليمة لا يوجد مشكلات");

			//				if (IsHOFFemale())
			//				{
			//					gvIDPOperation.Rows[0].Cells[8].Value = true;
			//				}
			//			}
			//			else
			//			{
			//				SetFailRowStyleInGridView(0, -1, "لا يوجد بيانات في السجل المدني");
			//			}
			//		}

			//	}
			//	else
			//	{
			//		// Must fill the IDENTITy
			//		//Error Message
			//		MessageBox.Show("يجب أن يكون هناك رب أسرة لهذه العائلة", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
			//	}



			//	// 1 Success
			//	HOFState = Convert.ToInt32(gvIDPOperation.Rows[0].Cells[15].Value);
			//	if (HOFState == 1)
			//	{
			//		for (int i = 1; i < gvIDPOperation.Rows.Count; i++)
			//		{
			//			int state = Convert.ToInt32(gvIDPOperation.Rows[i].Cells[15].Value);

			//			if (state != 1)
			//			{
			//				String ID = gvIDPOperation.Rows[i].Cells[0].Value.ToString();
			//				if (ID != "")
			//				{
			//					// Wife
			//					//String Relation = gvIDPOperation.Rows[i].Cells[1].Value.ToString();
			//					//Relation == Options.WIFE
			//					if (IsRelType(i, Options.WIFE))
			//					{
			//						if (!IsHOFFemale())
			//						{
			//							gpDT = gpTableAdapter.GetData(ID);
			//							if (IsFoundInDB(gpDT))
			//							{
			//								// If is Not Male
			//								if (gpDT.Rows[0]["Gender"].ToString() == "2")
			//								{
			//									FillCellsInGridView(gpDT, i);
			//									SetSuccessRowStyleInGridView(i, 1, "البيانات سليمة لا يوجد مشكلات");
			//								}
			//								else
			//								{
			//									SetFailRowStyleInGridView(i, -4, "رقم الهوية خاص بـ ذكر وهذا لا يصح أن يكون زوجة");
			//								}
			//							}
			//							else
			//							{
			//								SetFailRowStyleInGridView(i, -1, "لا يوجد بيانات في السجل المدني");
			//							}
			//						}
			//						else
			//						{
			//							SetFailRowStyleInGridView(i, -2, "لا يمكن أن يكون هناك زوجة بسبب أن رب الأسرة هي أنثى");
			//						}
			//					}
			//					// Other
			//					else
			//					{
			//						gpDT = gpTableAdapter.GetData(ID);
			//						if (IsFoundInDB(gpDT))
			//						{
			//							if (!IsHOFFemale())
			//							{
			//								if (IsRelatedToHOF(gpDT))
			//								{
			//									FillCellsInGridView(gpDT, i);
			//									SetSuccessRowStyleInGridView(i, 1, "البيانات سليمة لا يوجد مشكلات");
			//								}
			//								else
			//								{
			//									SetFailRowStyleInGridView(i, -3, "هذا الابن/الابنه غير مرتبط برب الأسرة");
			//								}
			//							}
			//							else
			//							{
			//								FillCellsInGridView(gpDT, i);
			//								SetSuccessRowStyleInGridView(i, 1, "البيانات سليمة لا يوجد مشكلات");
			//							}

			//						}
			//						else
			//						{
			//							SetFailRowStyleInGridView(i, -1, "لا يوجد بيانات في السجل المدني");
			//						}
			//					}
			//				}
			//			}

			//		}
			//	}
			//	// -1 Fail
			//	else
			//	{
			//		MessageBox.Show("يجب أن يكون هناك رب أسرة لهذه العائلة", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
			//	}
			//}
		}


		private void ClearForm()
		{
			//gvIDPOperation.Rows.Clear();
			//lbHOFFamilyName.Text = "";
			//lbHOFFName.Text = "";
			//lbHOFIdentity.Text = "";
			//lbHOFSName.Text = "";
			//lbHOFGender.Text = "";
		}
	}
}
