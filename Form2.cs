using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IDPSFamiliesExcelReporter
{
	public partial class Form2 : Form
	{

		public Form2()
		{
			InitializeComponent();

			dataGridView1.VirtualMode = true;
			dataGridView1.RowCount = GetRowCountFromDatabase();// 1000 Rows
			dataGridView1.CellValueNeeded += dataGridView1_CellValueNeeded;

			dataGridView1.Scroll += dataGridView1_Scroll;

			// Load data asynchronously
			Task.Run(() => LoadDataAsync());
		}



		#region
		// Asynchronous Data Loading
		private async Task LoadDataAsync()
		{
			await Task.Run(() =>
			{
				var data = GetEmployeeList(); // Fetch data in the background
				Invoke(new Action(() => bindingSource.DataSource = data));


			});
		}
		private DataTable GetEmployeeList()
		{
			// Fetch rows from the database (or cache)
			string query = "SELECT ID, Name, Department FROM Employees";
			DataTable table = new DataTable();
			using (OleDbConnection connection = new OleDbConnection("your_connection_string"))
			{
				OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection);
				adapter.Fill(table);
			}
			return table;
		}

		private int GetRowCountFromDatabase()
		{
			// Query to get the total number of rows in the table
			string query = "SELECT COUNT(*) FROM Employees";
			using (OleDbConnection connection = new OleDbConnection("your_connection_string"))
			{
				connection.Open();
				OleDbCommand command = new OleDbCommand(query, connection);
				return (int)command.ExecuteScalar();
			}
		}

		#endregion

		// Virtual Mode: Fetch data when requested
		private void dataGridView1_CellValueNeeded(object sender, DataGridViewCellValueEventArgs e)
		{
			var rowData = GetDataForRow(e.RowIndex);
			//e.Value = rowData[e.ColumnIndex];
		}

		private Employee GetDataForRow(int rowIndex)
		{
			// Example SQL to fetch just the row needed from Access DB
			string query = $"SELECT ID, Name, Department FROM Employees WHERE ID = {rowIndex + 1}";
			using (OleDbConnection connection = new OleDbConnection("your_connection_string"))
			{
				connection.Open();
				OleDbCommand command = new OleDbCommand(query, connection);
				OleDbDataReader reader = command.ExecuteReader();
				if (reader.Read())
				{
					return new Employee
					{
						ID = reader.GetInt32(0),
						Name = reader.GetString(1),
						Department = reader.GetString(2)
					};
				}
			}
			return null;
		}





		// Lazy loading when the user scrolls
		private void dataGridView1_Scroll(object sender, ScrollEventArgs e)
		{
			if (e.NewValue > dataGridView1.Rows.Count - 10) // Fetch more rows
			{
				LoadMoreRows();
			}
		}

		private void LoadMoreRows()
		{
			// Fetch the next set of rows and add to the DataGridView
			var additionalRows = GetNextBatchOfRows();
			bindingSource.Add(additionalRows);
		}

		private DataTable GetNextBatchOfRows()
		{
			// Example SQL to fetch more rows
		
			string query = "SELECT TOP 100 ID, Name, Department FROM Employees WHERE ID > @LastLoadedID";
			DataTable table = new DataTable();
			using (OleDbConnection connection = new OleDbConnection("your_connection_string"))
			{
				OleDbCommand command = new OleDbCommand(query, connection);
				command.Parameters.AddWithValue("@LastLoadedID", GetLastLoadedID());
				OleDbDataAdapter adapter = new OleDbDataAdapter(command);
				adapter.Fill(table);
			}
			return table;
		}

		private int GetLastLoadedID()
		{
			// Logic to get the ID of the last loaded row from the DataGridView
			return dataGridView1.Rows.Count > 0 ? (int)dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[0].Value : 0;
		}
	}

	internal class Employee
	{
		public int ID { get; set; }
		public string Name { get; set; }
		public string Department { get; set; }
	}
}
