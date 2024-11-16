using System;
using System.Windows.Forms;

namespace IDPSFamiliesExcelReporter
{
	public partial class AddIDP : Form
    {
        public static String Gender = "النوع الاجتماعي";
        public static bool Prgenant = false;
        public static bool Serious = false;
        public static bool PhysicalDis = false;
        public static bool VisualDis = false;
        public static bool HearingDis = false;
        public static bool IntellDis = false;
        public static bool Female_HOF = false;
        public static bool U_Child_HOF = false;
        public static bool SepChild = false;
        public static bool OlderPer = false;
        public static bool Child_HOF = false;
        internal static string HOFFName;
        internal static string HOFGender;
        internal static string HOFIdentity;
        internal static string HOFSName;
        internal static string FamilyName;
        internal static string Identity;
        internal static int RowIndex;

        private DataGridView gvIDPOperation;
        private IDP_Updated iDP_Updated;
        bool printData;
        public AddIDP(DataGridView gvIDPOperation, IDP_Updated iDP_Updated, bool printData)
        {
            this.printData = printData;
            this.iDP_Updated = iDP_Updated;
            this.gvIDPOperation = gvIDPOperation;
            InitializeComponent();
        }

        private void AddIDP_Load(object sender, EventArgs e)
        {
            PrepareGridView();
            FillData();

        }

        private void FillData()
        {
            txtIdentity.Text = Identity;
            txtFname.Select();
            txtFname.Focus();

            cbGender.SelectedIndex = 0;

            // قثط للأبناء
            if (printData)
            {
                txtSname.Text = HOFFName;
                txtTname.Text = HOFSName;
                txtFamiliyName.Text = FamilyName;

                txtSname.Enabled = false;
                txtTname.Enabled = false;
                txtFamiliyName.Enabled = false;
            }
            else
            {
                // إما رب الأسرة
                // إما زوجو
                if (RowIndex == 0)
                {
                    cbGender.SelectedIndex = 1;
                }
                else
                {
                    cbGender.SelectedIndex = 2;
                }
            }
           
            
        }

        private void PrepareGridView()
        {
            gvVul.Rows.Clear();

            DataGridViewRow row = new DataGridViewRow();
            row.CreateCells(gvVul);

            row.Cells[0].Value = AddIDP.Prgenant;
            row.Cells[1].Value = AddIDP.Serious;
            row.Cells[2].Value = AddIDP.PhysicalDis;
            row.Cells[3].Value = AddIDP.VisualDis;
            row.Cells[4].Value = AddIDP.HearingDis;
            row.Cells[5].Value = AddIDP.IntellDis;
            row.Cells[6].Value = AddIDP.Female_HOF;
            row.Cells[7].Value = AddIDP.U_Child_HOF;
            row.Cells[8].Value = AddIDP.SepChild;
            row.Cells[9].Value = AddIDP.OlderPer;
            row.Cells[10].Value = AddIDP.Child_HOF;

            gvVul.Rows.Add(row);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (IsRequiredDataFilled())
            {
                Identity = txtIdentity.Text;
                String FName = txtFname.Text;
                String SName = txtSname.Text;
                String TName = txtTname.Text;
                FamilyName = txtFamiliyName.Text;
                Gender = cbGender.Text;
                String DOB = txtDOB.Text;


                Prgenant = Convert.ToBoolean(gvVul.Rows[0].Cells[0].Value);
                Serious = Convert.ToBoolean(gvVul.Rows[0].Cells[1].Value);
                PhysicalDis = Convert.ToBoolean(gvVul.Rows[0].Cells[2].Value);
                VisualDis = Convert.ToBoolean(gvVul.Rows[0].Cells[3].Value);
                HearingDis = Convert.ToBoolean(gvVul.Rows[0].Cells[4].Value);
                IntellDis = Convert.ToBoolean(gvVul.Rows[0].Cells[5].Value);
                Female_HOF = Convert.ToBoolean(gvVul.Rows[0].Cells[6].Value);
				U_Child_HOF = Convert.ToBoolean(gvVul.Rows[0].Cells[7].Value);
				SepChild = Convert.ToBoolean(gvVul.Rows[0].Cells[8].Value);
				OlderPer = Convert.ToBoolean(gvVul.Rows[0].Cells[9].Value);
				Child_HOF = Convert.ToBoolean(gvVul.Rows[0].Cells[10].Value);


				

				gvIDPOperation.Rows[RowIndex].Cells["cPrgenant"].Value = Prgenant;
                gvIDPOperation.Rows[RowIndex].Cells["cSerious"].Value = Serious;
                gvIDPOperation.Rows[RowIndex].Cells["cPhysicalDis"].Value = PhysicalDis;
                gvIDPOperation.Rows[RowIndex].Cells["cVisualDis"].Value = VisualDis;
                gvIDPOperation.Rows[RowIndex].Cells["cHearingDis"].Value = HearingDis;
                gvIDPOperation.Rows[RowIndex].Cells["cIntellDis"].Value = IntellDis;
                gvIDPOperation.Rows[RowIndex].Cells["cFemale_HOF"].Value = Female_HOF;
				gvIDPOperation.Rows[RowIndex].Cells["cU_Child_HOF"].Value = U_Child_HOF;
				gvIDPOperation.Rows[RowIndex].Cells["cSepChild"].Value = SepChild;
                gvIDPOperation.Rows[RowIndex].Cells["cOlderPer"].Value = OlderPer;
                gvIDPOperation.Rows[RowIndex].Cells["cChild_HOF"].Value = Child_HOF;

                gvIDPOperation.Rows[RowIndex].Cells[0].Value = Identity;
                gvIDPOperation.Rows[RowIndex].Cells[18].Value = FName;
                gvIDPOperation.Rows[RowIndex].Cells[19].Value = SName;
                gvIDPOperation.Rows[RowIndex].Cells[20].Value = TName;
                gvIDPOperation.Rows[RowIndex].Cells[21].Value = FamilyName;
                gvIDPOperation.Rows[RowIndex].Cells[22].Value = Gender == "ذكر" ? 1 : 2;
                gvIDPOperation.Rows[RowIndex].Cells[23].Value = DOB;
                
                iDP_Updated.SetSuccessRowStyleInGridView(RowIndex, 1, "البيانات سليمة لا يوجد مشكلات");

                if (RowIndex == 0)
                {
                    iDP_Updated.GetIdentityLabel().Text = Identity;
                    iDP_Updated.GetFNameLabel().Text = FName;
                    iDP_Updated.GetSNameLabel().Text = SName;
                    iDP_Updated.GetFamilyNameLabel().Text = FamilyName;
                    iDP_Updated.GetGenderLabel().Text = Gender == "ذكر" ? "1" : "2";

                    if (iDP_Updated.GetGenderLabel().Text == "2")
                    {
                        gvIDPOperation.Rows[RowIndex].Cells["cFemale_HOF"].Value = true;
                    }
                }

                Dispose();
            }
            else
            {
                MessageBox.Show("يجب تعبئة جميع الحقول الضرورية", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool IsRequiredDataFilled()
        {
            return txtIdentity.Text != "" && txtIdentity.Text.Length == 9 && txtFname.Text != "" && txtSname.Text != "" && txtTname.Text != "" && txtFamiliyName.Text != "" && cbGender.SelectedIndex != 0;
        }

        private void AddIDP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                //btnSave_Click(sender, e);
            }
            else if ((e.KeyCode == Keys.F4))
            {
                //btnNewIDP_Click(sender, e);
            }
            else if (e.KeyCode == Keys.Escape)
            {
                //btnClose_Click(sender, e);
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
    }
}
