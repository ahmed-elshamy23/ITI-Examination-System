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
    public partial class ShowAllCourses : Form
    {
        List<Course> allCourses;
        public ShowAllCourses(SqlConnection conn)
        {
            InitializeComponent();
            connection = conn;
            allCourses = (List<Course>)connection.Query<Course>("Courses.getAllCourses", commandType: CommandType.StoredProcedure);
            dataGridView1.DataSource = allCourses;
            dataGridView1.Columns[0].ReadOnly = true;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var home = new InstructorDashboard(connection);
            home.ShowDialog();
            this.Close();
        }

        private void NewCourseButton_Click(object sender, EventArgs e)
        {
            var newCourse = new NewCourse(connection);
            newCourse.ShowDialog();
            allCourses = (List<Course>)connection.Query<Course>("Courses.getAllCourses", commandType: CommandType.StoredProcedure);
            dataGridView1.DataSource = allCourses.ToList();
        }

        private void DeleteCourseButton_Click(object sender, EventArgs e)
        {
            var deleteCourse = new DeleteCourse(connection, allCourses);
            deleteCourse.ShowDialog();
            allCourses = (List<Course>)connection.Query<Course>("Courses.getAllCourses", commandType: CommandType.StoredProcedure);
            dataGridView1.DataSource = allCourses.ToList();
        }

        private void UpdateCourseButton_Click(object sender, EventArgs e)
        {
            var updateCourse = new UpdateCourse(connection, allCourses);
            updateCourse.ShowDialog();
            allCourses = (List<Course>)connection.Query<Course>("Courses.getAllCourses", commandType: CommandType.StoredProcedure);
            dataGridView1.DataSource = allCourses.ToList();
        }
    }
}
