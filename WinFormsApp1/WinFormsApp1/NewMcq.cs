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
	public partial class NewMcq : Form
	{
		SqlConnection connection;
		List<Course> allCourses;
		public NewMcq(SqlConnection conn, List<Course> courses)
		{
			InitializeComponent();
			connection = conn;
			allCourses = courses;
			CourseBox.DataSource = allCourses.Select(c => c.Name).ToList();
		}

		private void InsertButton_Click(object sender, EventArgs e)
		{
			try
			{
				foreach (Control c in this.Controls)
				{
					if (c is TextBox)
					{
						TextBox textBox = c as TextBox;
						if (textBox.Text == string.Empty)
						{
							throw new Exception();
						}
					}
				}
				if (MarkInput.Value == 0) throw new Exception();
				if (MessageBox.Show("Are you sure?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
				{
					connection.ExecuteScalar(
						"Exams.newQuestion",
						new { body = QuestionBodyInput.Text, courseName = CourseBox.SelectedItem, mark = MarkInput.Value, Type = 1, option1 = Option1Input.Text, option2 = Option2Input.Text, option3 = Option3Input.Text, option4 = Option4Input.Text },
						commandType: CommandType.StoredProcedure);
					MessageBox.Show("Question Added Successfully", "", MessageBoxButtons.OK);
					this.Close();
				}
			}
			catch
			{
				MessageBox.Show("Unable to Insert Question", "", MessageBoxButtons.OK);
			}
		}
	}
}
