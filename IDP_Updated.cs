using System;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;
using static IDPSFamiliesExcelReporter.GazaPeopleDataSet;

namespace IDPSFamiliesExcelReporter
{
	public partial class IDP_Updated : Form
    {
        internal static bool Prgenant = false;
        internal static bool Serious = false;
        internal static bool PhysicalDis = false;
        internal static bool VisualDis = false;
        internal static bool HearingDis = false;
        internal static bool IntellDis = false;
        internal static bool Female_HOF = false;
        internal static bool U_Child_HOF = false;
        internal static bool SepChild = false;
        internal static bool OlderPer = false;
        internal static bool Child_HOF = false;
        internal static string FName;
        internal static string SName;
        internal static string Identity;
        internal static string TName;
		internal static string FamilyName;
        internal static string DOB;
        internal static string Gender;
        internal static int RowIndex;
        public IDP_Updated()
        {
            InitializeComponent();
        }
        public DataGridView GetGridView()
        {
            return gvIDPOperation;
        }
        public Label GetFNameLabel()
        {
            return lbHOFFName;
        }
        public Label GetSNameLabel()
        {
            return lbHOFSName;
        }
        public Label GetFamilyNameLabel()
        {
            return lbHOFFamilyName;
        }
        public Label GetIdentityLabel()
        {
            return lbHOFIdentity;
        }
        public Label GetGenderLabel()
        {
            return lbHOFGender;
        }


        // إصل للكنترول الي انت قاعد بتحدث فيها في السيل
        private void gvIDPOperation_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= TextboxNumeric_KeyPress;

            int colindex = (int)(((System.Windows.Forms.DataGridView)(sender)).CurrentCell.ColumnIndex);

            if (colindex == 0)
            {
                e.Control.KeyPress += TextboxNumeric_KeyPress;
            }
        }

        private void TextboxNumeric_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool nonNumberEntered = true;
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || e.KeyChar == 8)
            {
                nonNumberEntered = false;
            }
            if (nonNumberEntered)
            {
                // Stop the character from being entered into the control since it is non-numerical.
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }
        private void IDP_Updated_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DataGridViewRow dataGridViewRow = new DataGridViewRow();
                dataGridViewRow.CreateCells(gvIDPOperation);
                dataGridViewRow.Cells[0].Value = "";
                dataGridViewRow.Cells[2].Value = false;
                dataGridViewRow.Cells[3].Value = false;
                dataGridViewRow.Cells[4].Value = false;
                dataGridViewRow.Cells[5].Value = false;
                dataGridViewRow.Cells[6].Value = false;
                dataGridViewRow.Cells[7].Value = false;
                dataGridViewRow.Cells[8].Value = false;
                dataGridViewRow.Cells[9].Value = false;
                dataGridViewRow.Cells[10].Value = false;
                dataGridViewRow.Cells[11].Value = false;
                dataGridViewRow.Cells[12].Value = false;


				dataGridViewRow.Cells[15].Value = 0;
                dataGridViewRow.Cells[16].Value = "";
                dataGridViewRow.Cells[18].Value = "";
                dataGridViewRow.Cells[19].Value = "";
                dataGridViewRow.Cells[20].Value = "";
                dataGridViewRow.Cells[21].Value = "";
                dataGridViewRow.Cells[22].Value = "";
                dataGridViewRow.Cells[23].Value = "";

                int rows_count = gvIDPOperation.Rows.Count;

                if (rows_count == 0)
                {
                    dataGridViewRow.Cells[1].Value = Options.HIMSELF;
                    gvIDPOperation.Rows.Add(dataGridViewRow);
                }
                else if (rows_count > 0)
                {
                    if (!e.Shift)
                    {
                        dataGridViewRow.Cells[1].Value = Options.SON_DAUGHTER;
                    }
                    else
                    {
                        dataGridViewRow.Cells[1].Value = Options.WIFE;
                    }

                    // If The Previous Row Is Empty Do nothing
                    // You Must fill up the previous rows before you add new Memeber
                    String value = gvIDPOperation.Rows[rows_count - 1].Cells[0].Value.ToString();
                    if (value != "")
                    {
                        gvIDPOperation.Rows.Add(dataGridViewRow);
                        
                        // select the last row - focus on it.
                        gvIDPOperation.Rows[gvIDPOperation.Rows.Count-1].Cells[0].Selected = true;
                    }
                }
            }

            if (e.KeyCode == Keys.Add || e.KeyCode == Keys.Space)
            {

                if (gvIDPOperation.Rows.Count > 0)
                {
                    // End Edit To Add New Wife
                    gvIDPOperation.EndEdit();

                    gvIDPOperation.Rows[gvIDPOperation.Rows.Count - 1].Cells[0].Selected = true;
                    DataGridViewRow dataGridViewRow = new DataGridViewRow();
                    dataGridViewRow.CreateCells(gvIDPOperation);
                    dataGridViewRow.Cells[0].Value = "";
                    dataGridViewRow.Cells[2].Value = false;
                    dataGridViewRow.Cells[3].Value = false;
                    dataGridViewRow.Cells[4].Value = false;
                    dataGridViewRow.Cells[5].Value = false;
                    dataGridViewRow.Cells[6].Value = false;
                    dataGridViewRow.Cells[7].Value = false;
                    dataGridViewRow.Cells[8].Value = false;
                    dataGridViewRow.Cells[9].Value = false;
                    dataGridViewRow.Cells[10].Value = false;
                    dataGridViewRow.Cells[11].Value = false;
                    dataGridViewRow.Cells[12].Value = false;
                    dataGridViewRow.Cells[15].Value = 0;
                    dataGridViewRow.Cells[16].Value = "";
                    dataGridViewRow.Cells[18].Value = "";
                    dataGridViewRow.Cells[19].Value = "";
                    dataGridViewRow.Cells[20].Value = "";
                    dataGridViewRow.Cells[21].Value = "";
                    dataGridViewRow.Cells[22].Value = "";
                    dataGridViewRow.Cells[23].Value = "";

                    dataGridViewRow.Cells[1].Value = Options.WIFE;

                    int rows_count = gvIDPOperation.Rows.Count;
                    // If The Previous Row Is Empty Do nothing
                    // You Must fill up the previous rows before you add new Memeber
                    String value = gvIDPOperation.Rows[rows_count - 1].Cells[0].Value.ToString();
                    if (value != "")
                    {
                        gvIDPOperation.Rows.Add(dataGridViewRow);

                        // select the last row - focus on it.
                        gvIDPOperation.Rows[gvIDPOperation.Rows.Count - 1].Cells[0].Selected = true;
                    }
                }
            }

            if (e.KeyCode == Keys.Subtract)
            {
                if (gvIDPOperation.Rows.Count > 0) 
                {
                    RemoveFromGridView(gvIDPOperation.Rows.Count - 1);
                }
            }
        }

		private void btnSave_Click(object sender, EventArgs e)
        {
            
            FamiliesShelterDataSetTableAdapters.QueriesTableAdapter qAdapter = 
                new FamiliesShelterDataSetTableAdapters.QueriesTableAdapter();

            FamiliesShelterDataSetTableAdapters.DataTableAdapter adapter = 
                new FamiliesShelterDataSetTableAdapters.DataTableAdapter();

			String Mobile = "";
			String UnCard = "";
			if (cbYes.Checked)
			{
				if (gvIDPOperation.Rows.Count > 0)
				{
					MobileUNCardID form = new MobileUNCardID();
					form.ShowDialog(this);

					Mobile = form.MobileNumber;
					UnCard = form.UnCard;
					//MessageBox.Show(Mobile + " ; " + UnCard);
				}

			}


			for (int i = 0; i < gvIDPOperation.Rows.Count; i++)
            {
                int state = Convert.ToInt32(gvIDPOperation.Rows[i].Cells[15].Value);
                if (state == 1)
                {
                    String HOFID = lbHOFIdentity.Text;
                    String MemberID = gvIDPOperation.Rows[i].Cells[0].Value.ToString();
                    String Fname = gvIDPOperation.Rows[i].Cells["cFName"].Value.ToString();
                    String Sname = gvIDPOperation.Rows[i].Cells["cSName"].Value.ToString();
                    String Tname = gvIDPOperation.Rows[i].Cells["cTName"].Value.ToString();
                    String Family = gvIDPOperation.Rows[i].Cells["cFamilyName"].Value.ToString();
                    String Gender = gvIDPOperation.Rows[i].Cells["cGender"].Value.ToString() == "1" ? Options.Male : Options.Female;
                    String Vul1 = Convert.ToBoolean(gvIDPOperation.Rows[i].Cells[2].Value) ? Options.Pregnant_woman : "";
                    String Vul2 = Convert.ToBoolean(gvIDPOperation.Rows[i].Cells[3].Value) ? Options.Serious_medical : "";
                    String Vul3 = Convert.ToBoolean(gvIDPOperation.Rows[i].Cells[4].Value) ? Options.Physical_disability : "";
                    String Vul4 = Convert.ToBoolean(gvIDPOperation.Rows[i].Cells[5].Value) ? Options.Visual_impairment : "";
                    String Vul5 = Convert.ToBoolean(gvIDPOperation.Rows[i].Cells[6].Value) ? Options.Hearing_impairment : "";
                    String Vul6 = Convert.ToBoolean(gvIDPOperation.Rows[i].Cells[7].Value) ? Options.Intellectual_disability : "";
                    String Vul7 = Convert.ToBoolean(gvIDPOperation.Rows[i].Cells[8].Value) ? Options.Female_Head_of_Household : "";
                    String Vul8 = Convert.ToBoolean(gvIDPOperation.Rows[i].Cells[9].Value) ? Options.Unaccompanied_child : "";
                    String Vul9 = Convert.ToBoolean(gvIDPOperation.Rows[i].Cells[10].Value) ? Options.Separated_child : "";
                    String Vul10 = Convert.ToBoolean(gvIDPOperation.Rows[i].Cells[11].Value) ? Options.Older_person : "";
                    String Vul11 = Convert.ToBoolean(gvIDPOperation.Rows[i].Cells[12].Value) ? Options.Child_headed_household : "";

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


                    DateTime Birth = Convert.ToDateTime(gvIDPOperation.Rows[i].Cells[23].Value.ToString());


                    int? res = qAdapter.GetCountsOfMember(MemberID);
                    if (res == 0)
                    {
                        String RelationType = gvIDPOperation.Rows[i].Cells[1].Value.ToString();
                        if (RelationType == Options.SON_DAUGHTER)
                        {
                            if (Gender == Options.Male)
                            {
                                RelationType = Options.SON;
                            }
                            else
                            {
                                RelationType = Options.DAUGHTER;
                            }
                        }



                        

                        adapter.Insert1(HOFID,
                            Fname,
                            Sname,
                            Tname,
							Family,
                            MemberID,
                            Birth,
                            Gender,
                            RelationType,
                            disabilities[0].ToString(),
                            disabilities[1].ToString(),
                            disabilities[2].ToString(),
                            disabilities[3].ToString(),
                            disabilities[4].ToString(),
                            disabilities[5].ToString(),
							Options.ADD,
							false,
							UnCard,
							Mobile,
                            DateTime.Now
                            );
						
					}
                    else
                    {
                        String Name = Fname + " " + Sname + " " + Tname + " " + Family;
                        MessageBox.Show(Name + " مسجل سابقا في قاعدة البيانات", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            ClearForm();
        }

        private bool IsRelatedToHOF(GazaPeopleDataSet.DataDataTable gpDT)
        {
            return 
                PrepareTextToBeComparedBetter(gpDT.Rows[0]["SName"].ToString()) ==
                PrepareTextToBeComparedBetter(lbHOFFName.Text) 
                && 
                PrepareTextToBeComparedBetter(gpDT.Rows[0]["TName"].ToString()) == 
                PrepareTextToBeComparedBetter(lbHOFSName.Text) 
                && 
                PrepareTextToBeComparedBetter(gpDT.Rows[0]["LName"].ToString()) == 
                PrepareTextToBeComparedBetter(lbHOFFamilyName.Text);
        }

        String PrepareTextToBeComparedBetter(String text)
        {
            return text.
                Replace(" ", "").
                Replace("أ","ا").
                Replace("ؤ", "و").
                Replace("آ", "ا").
                Replace("ة","ه").
                Replace("ي","ى");
        }
        private bool IsHOFFemale()
        {
            return lbHOFGender.Text == "2";
        }

        internal void SetFailRowStyleInGridView(int i, int code, string msg)
        {
            gvIDPOperation.Rows[i].Cells[15].Value = code;
            gvIDPOperation.Rows[i].DefaultCellStyle.BackColor = Color.Red;
            gvIDPOperation.Rows[i].Cells[16].Value = msg;
        }

        internal void SetSuccessRowStyleInGridView(int i, int code, string msg)
        {
            gvIDPOperation.Rows[i].Cells[15].Value = code;
            gvIDPOperation.Rows[i].DefaultCellStyle.BackColor = Color.LightGreen;
            gvIDPOperation.Rows[i].Cells[16].Value = msg;
        }

        internal void FillCellsInGridView(GazaPeopleDataSet.DataDataTable gpDT, int i)
        {
            gvIDPOperation.Rows[i].Cells[18].Value = gpDT.Rows[0]["FName"].ToString();
            gvIDPOperation.Rows[i].Cells[19].Value = gpDT.Rows[0]["SName"].ToString();
            gvIDPOperation.Rows[i].Cells[20].Value = gpDT.Rows[0]["TName"].ToString();
            gvIDPOperation.Rows[i].Cells[21].Value = gpDT.Rows[0]["LName"].ToString();
            gvIDPOperation.Rows[i].Cells[22].Value = gpDT.Rows[0]["Gender"].ToString();
            gvIDPOperation.Rows[i].Cells[23].Value = gpDT.Rows[0]["DOB"].ToString();
        }

        internal void PrintHOFInLabels(GazaPeopleDataSet.DataDataTable gpDT)
        {
            lbHOFIdentity.Text = gpDT.Rows[0]["Identity"].ToString();
            lbHOFFName.Text = gpDT.Rows[0]["FName"].ToString();
            lbHOFSName.Text = gpDT.Rows[0]["SName"].ToString();
            lbHOFFamilyName.Text = gpDT.Rows[0]["LName"].ToString();
            lbHOFGender.Text = gpDT.Rows[0]["Gender"].ToString();
        }

        private static bool IsFoundInDB(DataDataTable gpDT)
        {
            return gpDT.Rows.Count > 0;
        }

        internal void DoneSuccessfully(int rowIndex, bool isSuccess, string msg,int code)
        {
            if (isSuccess)
            {
                gvIDPOperation.Rows[rowIndex].Cells[15].Value = 1;
                gvIDPOperation.Rows[rowIndex].DefaultCellStyle.BackColor = Color.LightGreen;
                gvIDPOperation.Rows[rowIndex].Cells[16].Value = msg;
            }
            else
            {
                gvIDPOperation.Rows[rowIndex].Cells[15].Value = -1;
                gvIDPOperation.Rows[rowIndex].DefaultCellStyle.BackColor = Color.Red;
                gvIDPOperation.Rows[rowIndex].Cells[16].Value = msg;
            }

        }

        private void gvIDPOperation_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                if (IsPressedOnShowMessageButton(e))
                {
                    String Msg = gvIDPOperation.Rows[e.RowIndex].Cells[16].Value.ToString();
                    MessageBox.Show(this, Msg, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (IsPressedOnAddManualButton(e))
                {
                    int state = 
                        Convert.ToInt32(gvIDPOperation.Rows[e.RowIndex].Cells[15].Value);
                    if (state != 0)
                    {
                        if (state == -1)
                        {

                            if (e.RowIndex == 0 || IsRelType(e.RowIndex, Options.WIFE) || IsHOFFemale()) // If Is HOF or Wife or HOF_Female
                            {
                                ShowAddManualForm(e, false);
                            }
                            else
                            {
                                ShowAddManualForm(e, true);
                            }
                        }
                        else
                        {
                            var Msg = gvIDPOperation.Rows[e.RowIndex].Cells[16].Value.ToString();
                            MessageBox.Show(this, Msg, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    
                }
                else if (IsPressedOnDeleteButton(e))
                {
                    RemoveFromGridView(e.RowIndex);
                }
            }

        }

        private bool IsRelType(int rowIndex, String rel)
        {
            String Rel = gvIDPOperation.Rows[rowIndex].Cells[1].Value.ToString();
            return Rel == rel;
        }

        private static bool IsWife(string Rel)
        {
            return Rel == Options.WIFE;
        }

        private bool NewMethod()
        {
            return lbHOFGender.Text == "2";
        }

        private void ShowAddManualForm(DataGridViewCellEventArgs e, bool printData)
        {
            AddIDP form = new AddIDP(GetGridView(), this,printData);


            AddIDP.Prgenant = Convert.ToBoolean(gvIDPOperation.Rows[e.RowIndex].Cells["cPrgenant"].Value);
            AddIDP.Serious = Convert.ToBoolean(gvIDPOperation.Rows[e.RowIndex].Cells["cSerious"].Value);
            AddIDP.PhysicalDis = Convert.ToBoolean(gvIDPOperation.Rows[e.RowIndex].Cells["cPhysicalDis"].Value);
            AddIDP.VisualDis = Convert.ToBoolean(gvIDPOperation.Rows[e.RowIndex].Cells["cVisualDis"].Value);
            AddIDP.HearingDis = Convert.ToBoolean(gvIDPOperation.Rows[e.RowIndex].Cells["cHearingDis"].Value);
            AddIDP.IntellDis = Convert.ToBoolean(gvIDPOperation.Rows[e.RowIndex].Cells["cIntellDis"].Value);
            AddIDP.Female_HOF = Convert.ToBoolean(gvIDPOperation.Rows[e.RowIndex].Cells["cFemale_HOF"].Value);
            AddIDP.U_Child_HOF = Convert.ToBoolean(gvIDPOperation.Rows[e.RowIndex].Cells["cU_Child_HOF"].Value);
            AddIDP.SepChild = Convert.ToBoolean(gvIDPOperation.Rows[e.RowIndex].Cells["cSepChild"].Value);
            AddIDP.OlderPer = Convert.ToBoolean(gvIDPOperation.Rows[e.RowIndex].Cells["cOlderPer"].Value);
            AddIDP.Child_HOF = Convert.ToBoolean(gvIDPOperation.Rows[e.RowIndex].Cells["cChild_HOF"].Value);
            AddIDP.HOFFName = lbHOFFName.Text;
            AddIDP.HOFGender = lbHOFGender.Text;
            AddIDP.HOFIdentity = lbHOFIdentity.Text;
            AddIDP.HOFSName = lbHOFSName.Text;
            AddIDP.FamilyName = lbHOFFamilyName.Text;
            AddIDP.Identity = gvIDPOperation.Rows[e.RowIndex].Cells[0].Value.ToString();
            AddIDP.RowIndex = e.RowIndex;



            form.ShowDialog(this);
        }

        private static bool IsPressedOnAddManualButton(DataGridViewCellEventArgs e)
        {
            return e.ColumnIndex == 14;
        }

        private static bool IsPressedOnShowMessageButton(DataGridViewCellEventArgs e)
        {
            return e.ColumnIndex == 13;
        }

        private static bool IsPressedOnDeleteButton(DataGridViewCellEventArgs e)
        {
            return e.ColumnIndex == 17;
        }

        private void RemoveFromGridView(int rowIndex)
        {
            String Rel = gvIDPOperation.Rows[rowIndex].Cells[1].Value.ToString();
            if (Rel == Options.HIMSELF)
            {
                DialogResult res = MessageBox.Show("أنت تقوم بحذف رب الاسرة سيتم حذف جميع البيانات الأخرى", "",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (res == DialogResult.Yes)
                {
                    ClearForm();
                }
            }
            else
            {
                gvIDPOperation.Rows.RemoveAt(rowIndex);
            }
        }

        private void IDP_Updated_Load(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            gvIDPOperation.Rows.Clear();
            lbHOFFamilyName.Text = "";
            lbHOFFName.Text = "";
            lbHOFIdentity.Text = "";
            lbHOFSName.Text = "";
            lbHOFGender.Text = "";

            gvIDPOperation.Focus();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            GazaPeopleDataSet.DataDataTable gpDT =
               new GazaPeopleDataSet.DataDataTable();


            GazaPeopleDataSetTableAdapters.DataTableAdapter gpTableAdapter =
                new GazaPeopleDataSetTableAdapters.DataTableAdapter();



            if (gvIDPOperation.Rows.Count > 0)
            {
                String HOFID = gvIDPOperation.Rows[0].Cells[0].Value.ToString();
                int HOFState = Convert.ToInt32(gvIDPOperation.Rows[0].Cells[15].Value);
				//DateTime HOFDOB = Convert.ToDateTime();
                //MessageBox.Show(HOFDOB.ToString());
				if (HOFID != "")
                {
                    if (HOFState != 1)
                    {
                        // Process The Data
                        gpDT = gpTableAdapter.GetData(HOFID);
                        if (IsFoundInDB(gpDT))
                        {
                            PrintHOFInLabels(gpDT);
                            FillCellsInGridView(gpDT, 0);
                            SetSuccessRowStyleInGridView(0, 1,
                                "البيانات سليمة لا يوجد مشكلات");

                            DateTime dob;
                            bool isSucess = DateTime.TryParse(
                                gvIDPOperation.Rows[0].Cells[23].Value.ToString(), out dob);
                            if (isSucess)
                            {
								if (IsGreaterThan60(dob))
								{
									gvIDPOperation.Rows[0].Cells[11].Value = true;
								}
								if (IsLessThan18(dob))
								{
									gvIDPOperation.Rows[0].Cells[12].Value = true;
								}
							}

							if (IsHOFFemale())
                            {
                                gvIDPOperation.Rows[0].Cells[8].Value = true;
                            }
                            
                        }
                        else
                        {
                            SetFailRowStyleInGridView(0, -1, "لا يوجد بيانات في السجل المدني");
                        }
                    }

                }
                else
                {
                    // Must fill the IDENTITy
                    //Error Message
                    MessageBox.Show("يجب أن يكون هناك رب أسرة لهذه العائلة", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }



                // 1 Success
                HOFState = Convert.ToInt32(gvIDPOperation.Rows[0].Cells[15].Value);
                if (HOFState == 1)
                {
                    for (int i = 1; i < gvIDPOperation.Rows.Count; i++)
                    {
                        int state = Convert.ToInt32(gvIDPOperation.Rows[i].Cells[15].Value);

                        if (state != 1)
                        {
                            String ID = gvIDPOperation.Rows[i].Cells[0].Value.ToString();
                            if (ID != "")
                            {
                                // Wife
                                //String Relation = gvIDPOperation.Rows[i].Cells[1].Value.ToString();
                                //Relation == Options.WIFE
                                if (IsRelType(i, Options.WIFE))
                                {
                                    if (!IsHOFFemale())
                                    {
                                        gpDT = gpTableAdapter.GetData(ID);
                                        if (IsFoundInDB(gpDT))
                                        {
                                            // If is Not Male
                                            if (gpDT.Rows[0]["Gender"].ToString() == "2")
                                            {
                                                FillCellsInGridView(gpDT, i);
                                                SetSuccessRowStyleInGridView(i, 1, "البيانات سليمة لا يوجد مشكلات");
                                            }
                                            else
                                            {
                                                SetFailRowStyleInGridView(i, -4, "رقم الهوية خاص بـ ذكر وهذا لا يصح أن يكون زوجة");
                                            }
                                        }
                                        else
                                        {
                                            SetFailRowStyleInGridView(i, -1, "لا يوجد بيانات في السجل المدني");
                                        }
                                    }
                                    else
                                    {
                                        SetFailRowStyleInGridView(i, -2, "لا يمكن أن يكون هناك زوجة بسبب أن رب الأسرة هي أنثى");
                                    }
                                }
                                // Other
                                else
                                {
                                    gpDT = gpTableAdapter.GetData(ID);
                                    if (IsFoundInDB(gpDT))
                                    {
                                        if (!IsHOFFemale())
                                        {
                                            if (IsRelatedToHOF(gpDT))
                                            {
                                                FillCellsInGridView(gpDT, i);
                                                SetSuccessRowStyleInGridView(i, 1, "البيانات سليمة لا يوجد مشكلات");
                                            }
                                            else
                                            {
                                                SetFailRowStyleInGridView(i, -3, "هذا الابن/الابنه غير مرتبط برب الأسرة");
                                            }
                                        }
                                        else
                                        {
                                            FillCellsInGridView(gpDT, i);
                                            SetSuccessRowStyleInGridView(i, 1, "البيانات سليمة لا يوجد مشكلات");
                                        }

                                    }
                                    else
                                    {
                                        SetFailRowStyleInGridView(i, -1, "لا يوجد بيانات في السجل المدني");
                                    }
                                }
                            }
                        }
                        
                    }
                }
                // -1 Fail
                else
                {
                    MessageBox.Show("يجب أن يكون هناك رب أسرة لهذه العائلة", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

		private bool IsLessThan18(DateTime dob)
		{
			DateTime currentDate = DateTime.Now;
			TimeSpan timeSpan;
			if (dob <= DateTime.Now)
			{
				timeSpan = currentDate - dob;
			}
			else
			{
				dob = new DateTime(dob.Year - 100, dob.Month, dob.Day);
				timeSpan = currentDate - dob;
			}

			return (timeSpan.TotalDays / 365) < 18;
		}

		private bool IsGreaterThan60(DateTime dob)
		{
			DateTime currentDate = DateTime.Now;
            TimeSpan timeSpan;
			if (dob <= DateTime.Now)
            {
				 timeSpan = currentDate - dob;
			}
            else
            {
                dob = new DateTime(dob.Year-100, dob.Month, dob.Day);
				timeSpan = currentDate - dob;
			}

            return (timeSpan.TotalDays / 365) >= 60;
		}

		private void gvIDPOperation_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void btnDataGaza_Click(object sender, EventArgs e)
		{
            if (!SearchFormGaza.activate)
            {
				SearchFormGaza.activate = true;
				SearchFormGaza form = new SearchFormGaza();

				form.Show();
			}
            
		}
	}
}
