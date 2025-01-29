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
    public partial class CourseTopicReport : Form
    {
        SqlConnection connection;
        List<Course> allCourses;
        List<CourseTopic> allTopics;
        public CourseTopicReport(SqlConnection conn)
        {
            InitializeComponent();
            connection = conn;
            allCourses = connection.Query<Course>("Courses.getCourseNames", commandType: CommandType.StoredProcedure).ToList();
            CourseBox.DataSource = allCourses.Select(c => c.Name).ToList();
            allTopics = connection.Query<CourseTopic>("Reports.getCourseTopics", new { id = allCourses.Where(c => c.Name == CourseBox.SelectedItem).Select(c => c.Id).First() }, commandType: CommandType.StoredProcedure).ToList();
            dataGridView1.DataSource = allTopics;
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
            GeneratePdf.Generate($"{CourseBox.SelectedItem} Topics", dataGridView1);
        }

        private void CourseBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            allTopics = connection.Query<CourseTopic>("Reports.getCourseTopics", new { id = allCourses.Where(c => c.Name == CourseBox.SelectedItem).Select(c => c.Id).First() }, commandType: CommandType.StoredProcedure).ToList();
            dataGridView1.DataSource = allTopics;
        }
    }
}
