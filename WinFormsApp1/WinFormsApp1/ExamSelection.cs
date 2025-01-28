using Dapper;
using Microsoft.Data.SqlClient;
using System.Data;
using WinFormsApp1.Models;

namespace WinFormsApp1
{
    public partial class ExamSelection : Form
    {
        SqlConnection connection;
        List<CourseExam> courseExams;
        int examId = -1;
        string? courseName = null;
        public ExamSelection(SqlConnection conn)
        {
            InitializeComponent();
            connection = conn;
        }

        private void ExamSelection_Load(object sender, EventArgs e)
        {
            courseExams = connection.Query<CourseExam>("Exams.examCourse", commandType: CommandType.StoredProcedure).ToList();

            foreach (var course in courseExams)
            {
                if (!CourseList.Items.Contains(course.CourseName))
                {
                    CourseList.Items.Add(course.CourseName);
                }
            }
        }

        private void CourseList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ExamList.Items.Clear();
            ExamList.Text = "Select Exam";
            examId = -1;
            foreach (var course in courseExams)
            {
                if (course.CourseName == CourseList.SelectedItem.ToString())
                {
                    ExamList.Items.Add($"Exam #{course.ExamId}");
                }
            }
            courseName = CourseList.SelectedItem.ToString();
        }

        private void ShowExam_Click(object sender, EventArgs e)
        {
            if (examId != -1 && courseName != null)
            {
                this.Hide();
                var showExam = new ShowExam(connection, examId, courseName);
                showExam.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Please select an exam for course");
            }

        }

        private void ExamList_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the selected exam id
            examId = int.Parse(ExamList.SelectedItem.ToString().Replace("Exam #", ""));
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            var instructor = new Reports(connection);
            instructor.ShowDialog();
            this.Close();
        }
    }
}
