using Microsoft.Data.SqlClient;

namespace WinFormsApp1
{
	public partial class Reports : Form
	{
		SqlConnection connection;
		public Reports(SqlConnection conn)
		{
			InitializeComponent();
			connection = conn;
		}

		private void BackButton_Click(object sender, EventArgs e)
		{
			this.Hide();
			var home = new InstructorDashboard(connection);
			home.ShowDialog();
			this.Close();
		}

		private void ShowExamQuestionsButton_Click(object sender, EventArgs e)
		{
			this.Hide();
			var home = new ExamSelection(connection);
			home.ShowDialog();
			this.Close();
		}

		private void ShowDepartmentStudentsButton_Click(object sender, EventArgs e)
		{
			//this.Hide();
			//var report = new StudentDepartmentReport(connection);
			//report.ShowDialog();
			//this.Close();
		}
	}
}
