using System;
using System.Windows.Forms;

namespace IDPSFamiliesExcelReporter
{
	public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNewIDP_Click(object sender, EventArgs e)
        {
            IDP_Updated form = new IDP_Updated();
            form.Show(this);
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            ExportToExcelForm form = new ExportToExcelForm();
            form.Show(this);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchForm form = new SearchForm();
            form.Show(this);  
        }

		private void btnCiviliansDataSearch_Click(object sender, EventArgs e)
		{
			if (!SearchFormGaza.activate)
			{
				SearchFormGaza.activate = true;
				SearchFormGaza form = new SearchFormGaza();

				form.Show(this);
			}

			//SearchFormGaza form = new SearchFormGaza();
			//form.Show(this);
		}

		private void btnGreen_Click(object sender, EventArgs e)
		{
            Options.Theme = System.Drawing.Color.Green;
            //Refresh();
		}

		private void btnSilver_Click(object sender, EventArgs e)
		{
			Options.Theme = System.Drawing.Color.Silver;
		}

		private void btnBlack_Click(object sender, EventArgs e)
		{
			Options.Theme = System.Drawing.Color.Black;
		}

		private void btnRed_Click(object sender, EventArgs e)
		{
			Options.Theme = System.Drawing.Color.DarkRed;
		}

		private void btnBlue_Click(object sender, EventArgs e)
		{
			Options.Theme = System.Drawing.Color.DarkBlue;
		}

		private void btnWhite_Click(object sender, EventArgs e)
		{
			Options.Theme = System.Drawing.Color.White;
		}
	}
}
