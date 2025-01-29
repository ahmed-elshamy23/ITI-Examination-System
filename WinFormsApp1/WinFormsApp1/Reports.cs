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
            this.Hide();
            var report = new DepartmentStudentReport(connection);
            report.ShowDialog();
            this.Close();
        }

        private void CourseTopicsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var report = new CourseTopicReport(connection);
            report.ShowDialog();
            this.Close();
        }

        private void StudentGradesButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var report = new StudentGradesReport(connection);
            report.ShowDialog();
            this.Close();
        }

        private void InstructorCoursesButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var report = new InstructorCourseReport(connection);
            report.ShowDialog();
            this.Close();
        }

        private void ShowStudentAnswersButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var report = new StudentAnswersReport(connection);
            report.ShowDialog();
            this.Close();
        }
    }
}
