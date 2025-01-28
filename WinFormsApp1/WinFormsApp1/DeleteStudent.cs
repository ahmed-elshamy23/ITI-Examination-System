using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
	public partial class DeleteStudent : Form
	{
		SqlConnection connection;
		public DeleteStudent(SqlConnection conn, List<int> Ids)
		{
			InitializeComponent();
			connection = conn;
			DeleteBox.DataSource = Ids;
		}

		private void DeleteButton_Click(object sender, EventArgs e)
		{
			try
			{
				if (DeleteBox.SelectedItem == null)
					throw new Exception();
				if (MessageBox.Show("Are you sure?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
				{
					connection.ExecuteScalar(
						"Users.deleteStudent",
						new { id = DeleteBox.SelectedItem },
						commandType: CommandType.StoredProcedure);
					MessageBox.Show("Student Deleted Successfully", "", MessageBoxButtons.OK);
					this.Close();
				}
            }
			catch
			{
				MessageBox.Show("Unable to Delete Student", "", MessageBoxButtons.OK);
			}
		}
	}
}
