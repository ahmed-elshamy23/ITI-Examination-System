using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.ReportingServices.Diagnostics.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.Models;

namespace WinFormsApp1
{
	public partial class StudentGradesReport : Form
	{
		SqlConnection connection;
		List<Person> allStudents;
		List<StudentGrade> studentGrades;
		public StudentGradesReport(SqlConnection conn)
		{
			InitializeComponent();
			connection = conn;
			allStudents = connection.Query<Person>("Users.getAllStudents", commandType: CommandType.StoredProcedure).ToList();
			StudentBox.DataSource = allStudents.Select(s => s.Name).ToList();
			studentGrades = connection.Query<StudentGrade>("Reports.getStudentGrades", new { id = allStudents.Where(s => s.Name == StudentBox.SelectedItem).Select(s => s.Id).First() }).ToList();
			dataGridView1.DataSource = studentGrades.Where(s => s.Grade != -1).ToList();
		}

		private void BackButton_Click(object sender, EventArgs e)
		{
			this.Hide();
			var home = new Reports(connection);
			home.ShowDialog();
			this.Close();
		}

		private void GeneratePdfButton_Click(object sender, EventArgs e)
		{
			if (dataGridView1.Rows.Count == 0)
				MessageBox.Show("Empty Data", "");
			else
				GeneratePdf.Generate($"Grades of {StudentBox.SelectedItem}", dataGridView1);
		}

		private void CourseBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			studentGrades = connection.Query<StudentGrade>("Reports.getStudentGrades", new { id = allStudents.Where(s => s.Name == StudentBox.SelectedItem).Select(s => s.Id).First() }).ToList();
			dataGridView1.DataSource = studentGrades.Where(s => s.Grade != -1).ToList();
		}
	}
}
