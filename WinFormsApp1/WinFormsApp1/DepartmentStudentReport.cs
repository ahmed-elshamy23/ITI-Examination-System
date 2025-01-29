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
    public partial class DepartmentStudentReport : Form
    {
        SqlConnection connection;
        List<Person> allStudents;
        List<Department> allDepts;
        public DepartmentStudentReport(SqlConnection conn)
        {
            InitializeComponent();
            connection = conn;
            allDepts = (List<Department>)connection.Query<Department>("Courses.getDepartmentNames", commandType: CommandType.StoredProcedure);
            DepartmentBox.DataSource = allDepts.Select(d => d.Name).ToList();
            allStudents = (List<Person>)connection.Query<Person>("Reports.getStudentsByDepartment", new { did = allDepts.Where(d => d.Name == DepartmentBox.SelectedItem).Select(d => d.Id).First() }, commandType: CommandType.StoredProcedure);
            dataGridView1.DataSource = allStudents.Select(s => new { s.Id, s.Name, s.Age, s.Address, s.PhoneNumber, s.Email }).ToList();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var home = new Reports(connection);
            home.ShowDialog();
            this.Close();
        }

        private void DepartmentBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            allStudents = (List<Person>)connection.Query<Person>("Reports.getStudentsByDepartment", new { did = allDepts.Where(d => d.Name == DepartmentBox.SelectedItem).Select(d => d.Id).First() }, commandType: CommandType.StoredProcedure);
            dataGridView1.DataSource = allStudents.Select(s => new { s.Id, s.Name, s.Age, s.Address, s.PhoneNumber, s.Email }).ToList();
        }

        private void GeneratePdfButton_Click(object sender, EventArgs e)
        {
            GeneratePdf.Generate($"Students in Department {DepartmentBox.SelectedItem}", dataGridView1);
        }
    }
}
