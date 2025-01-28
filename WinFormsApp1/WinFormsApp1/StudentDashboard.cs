using Dapper;
using Microsoft.Data.SqlClient;
using System.Data;
using WinFormsApp1.Models;

namespace WinFormsApp1
{
    public partial class StudentDashboard : Form
    {
        SqlConnection connection;
        Person student;
        public StudentDashboard(SqlConnection conn)
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

        private void StudentDashboard_Load(object sender, EventArgs e)
        {
            student = connection.Query<Person>("Users.getStudent", new { id = studentId }, commandType: CommandType.StoredProcedure).First();
            WelcomeLabel.Text += $" {student.Name}";
        }

        private void ShowProfile_Click(object sender, EventArgs e)
        {
            var profile = new StudentProfile(connection, student);
            profile.ShowDialog();
            student = connection.Query<Person>("Users.getStudent", new { id = studentId }, commandType: CommandType.StoredProcedure).First();
        }

        private void TakeExamButton_Click(object sender, EventArgs e)
        {
            var exam = new TakeExam(connection, student);
            this.Hide();
            exam.ShowDialog();
            this.Close();
        }

        private void MyExamsButton_Click(object sender, EventArgs e)
        {
            var exams = new PreviousExams(connection, student);
            this.Hide();
            exams.ShowDialog();
            this.Close();
        }

        private void MyGradesButton_Click(object sender, EventArgs e)
        {
            var grades = new PreviousGrades(connection, student);
            this.Hide();
            grades.ShowDialog();
            this.Close();
        }
    }
}
