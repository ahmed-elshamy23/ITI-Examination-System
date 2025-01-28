using Dapper;
using Microsoft.Data.SqlClient;
using System.Data;
using WinFormsApp1.Models;

namespace WinFormsApp1
{
    public partial class InstructorDashboard : Form
    {
        SqlConnection connection;
        Person instructor;
        public InstructorDashboard(SqlConnection conn)
        {
            InitializeComponent();
            connection = conn;
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var login = new Login();
            login.ShowDialog();
            this.Close();
        }

        private void ReportsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var reports = new Reports(connection);
            reports.ShowDialog();
            this.Close();
        }

        private void AllStudentsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var allStudents = new ShowAllStudents(connection);
            allStudents.ShowDialog();
            this.Close();
        }

        private void AllCoursesButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var allCourses = new ShowAllCourses(connection);
            allCourses.ShowDialog();
            this.Close();
        }

        private void InstructorDashboard_Load(object sender, EventArgs e)
        {
            instructor = connection.Query<Person>("Users.getInstructor", new { id = instructorId }, commandType: CommandType.StoredProcedure).First();
            WelcomeLabel.Text += $" {instructor.Name}";
        }

        private void ShowProfile_Click(object sender, EventArgs e)
        {
            var profile = new InstructorProfile(connection, instructor);
            profile.ShowDialog();
            instructor = connection.Query<Person>("Users.getInstructor", new { id = instructorId }, commandType: CommandType.StoredProcedure).First();
        }

        private void AllExamsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var ExamSelect = new ExamSelection(connection);
            ExamSelect.ShowDialog();
            this.Close();
        }

        private void NewQuestionButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var questions = new ShowAllQuestions(connection);
            questions.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var exam = new NewExam(connection);
            exam.ShowDialog();
        }
    }
}
