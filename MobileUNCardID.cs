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
	public partial class MobileUNCardID : Form
	{
		public MobileUNCardID()
		{
			InitializeComponent();
		}

		public string MobileNumber { get; internal set; }
		public string UnCard { get; internal set; }

		private void MobileUNCardID_Load(object sender, EventArgs e)
		{
			txtMobile.Text = "";
			txtUNCard.Text = "";
			this.Activate();
			txtMobile.Focus();

		}

		private void button2_Click(object sender, EventArgs e)
		{
			MobileNumber = ""; UnCard = "";
			Dispose();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			MobileNumber = txtMobile.Text;
			UnCard = txtUNCard.Text;
			Dispose();
		}
	}
}
