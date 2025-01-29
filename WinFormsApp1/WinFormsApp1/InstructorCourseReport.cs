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
    public partial class InstructorCourseReport : Form
    {
        SqlConnection connection;
        List<Person> instructors;
        List<InstructorCourse> courses;
        public InstructorCourseReport(SqlConnection conn)
        {
            InitializeComponent();
            connection = conn;
            SqlMapper.SetTypeMap(typeof(InstructorCourse), new CustomPropertyTypeMap(
                typeof(InstructorCourse),
                (type, columnName) => type.GetProperties().FirstOrDefault(prop => prop.Name.Replace(" ", "") == columnName.Replace(" ", ""))
            ));
            instructors = connection.Query<Person>("Users.getAllInstructors", commandType: CommandType.StoredProcedure).ToList();
            InstructorBox.DataSource = instructors.Select(i => i.Name).ToList();
            courses = connection.Query<InstructorCourse>("Reports.getInstructorCourses", new { id = instructors.Where(i => i.Name == InstructorBox.SelectedItem).Select(i => i.Id).First() }, commandType: CommandType.StoredProcedure).ToList();
            dataGridView1.DataSource = courses;
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
            GeneratePdf.Generate($"Courses Associated with {InstructorBox.SelectedItem}", dataGridView1);
        }

        private void InstructorBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            courses = connection.Query<InstructorCourse>("Reports.getInstructorCourses", new { id = instructors.Where(i => i.Name == InstructorBox.SelectedItem).Select(i => i.Id).First() }, commandType: CommandType.StoredProcedure).ToList();
            dataGridView1.DataSource = courses;
        }
    }
}
