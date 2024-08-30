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
            form.ShowDialog(this);
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            ExportToExcelForm form = new ExportToExcelForm();
            form.ShowDialog(this);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchForm form = new SearchForm();
            form.ShowDialog(this);  
        }

    }
}
