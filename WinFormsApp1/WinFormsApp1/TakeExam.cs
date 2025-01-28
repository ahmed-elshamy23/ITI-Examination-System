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
    public partial class TakeExam : Form
    {
        SqlConnection connection;
        List<Course> allCourses;
        List<int> notTakenExams;
        Person student;
        public TakeExam(SqlConnection conn, Person s)
        {
            InitializeComponent();
            connection = conn;
            student = s;
            allCourses = connection.Query<Course>("Courses.getStudentCourses", new { id = student.Id }, commandType: CommandType.StoredProcedure).ToList();
            CourseList.DataSource = allCourses.Select(c => c.Name).ToList();
            notTakenExams = connection.Query<int>("Exams.getNotTakenExams", new { sid = student.Id, cid = allCourses.Where(c => c.Name == CourseList.SelectedItem).Select(c => c.Id).FirstOrDefault() }, commandType: CommandType.StoredProcedure).ToList();
            ExamList.DataSource = notTakenExams.Select(e => $"Exam #{e}").ToList();
        }

        private void StartExam_Click(object sender, EventArgs e)
        {
            var exam = new StartExam(connection, student.Id, notTakenExams[ExamList.SelectedIndex]);
            this.Hide();
            exam.ShowDialog();
            this.Close();
        }

        private void CourseList_SelectedIndexChanged(object sender, EventArgs e)
        {
            notTakenExams = connection.Query<int>("Exams.getNotTakenExams", new { sid = student.Id, cid = allCourses.Where(c => c.Name == CourseList.SelectedItem).Select(c => c.Id).FirstOrDefault() }, commandType: CommandType.StoredProcedure).ToList();
            ExamList.DataSource = notTakenExams.Select(e => $"Exam #{e}").ToList();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Hide();
            var home = new StudentDashboard(connection);
            home.ShowDialog();
            Close();
        }
    }
}
