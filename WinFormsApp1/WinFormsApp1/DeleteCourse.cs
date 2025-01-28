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
    public partial class DeleteCourse : Form
    {
        SqlConnection connection;
        List<Course> allCourses;
        public DeleteCourse(SqlConnection conn, List<Course> courses)
        {
            InitializeComponent();
            connection = conn;
            allCourses = courses;
            DeleteBox.DataSource = allCourses.Select(c => c.Name).ToList();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (DeleteBox.SelectedItem == null)
                    throw new Exception();
                if (MessageBox.Show("Are you sure?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    connection.ExecuteScalar(
                        "Courses.deleteCourse",
                        new { id = allCourses.Where(c => c.Name == DeleteBox.SelectedItem).Select(c => c.Id).First() },
                        commandType: CommandType.StoredProcedure);
                    MessageBox.Show("Course Deleted Successfully", "", MessageBoxButtons.OK);
                    this.Close();
                }
            }
            catch
            {
                MessageBox.Show("Unable to Delete Course", "", MessageBoxButtons.OK);
            }
        }
    }
}
