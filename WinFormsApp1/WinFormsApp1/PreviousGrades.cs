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
using WinFormsApp1.Models;

namespace WinFormsApp1
{
	public partial class PreviousGrades : Form
	{
		SqlConnection connection;
		Person student;
		List<StudentExam> allStudentExams;
		public PreviousGrades(SqlConnection conn, Person s)
		{
			InitializeComponent();
			connection = conn;
			student = s;
			allStudentExams = (List<StudentExam>)connection.Query<StudentExam>("Exams.getStudentExams", new { id = student.Id }, commandType: CommandType.StoredProcedure);
            //CourseBox.DataSource = allStudentExams.Select(x => x.Course).Distinct().ToList();
            foreach (var course in allStudentExams)
            {
                if (!CourseBox.Items.Contains(course.Course))
                {
                    CourseBox.Items.Add(course.Course);
                }
            }
            dataGridView1.DataSource = allStudentExams.Where(e => e.Course == CourseBox.SelectedItem).Select(x => new { x.Exam, x.Grade, x.Date }).ToList();
		}

		private void BackButton_Click(object sender, EventArgs e)
		{
			this.Hide();
			var home = new StudentDashboard(connection);
			home.ShowDialog();
			this.Close();
		}

		private void CourseBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			dataGridView1.DataSource = allStudentExams.Where(e => e.Course == CourseBox.SelectedItem.ToString()).Select(x => new { x.Exam, x.Grade, x.Date }).ToList();
		}
	}
}
