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
    public partial class NewExam : Form
    {
        SqlConnection connection;
        List<Course> allCourses;
        public NewExam(SqlConnection conn)
        {
            InitializeComponent();
            this.connection = conn;
            allCourses = (List<Course>)connection.Query<Course>("Courses.getAllCourses", commandType: CommandType.StoredProcedure);
            CourseBox.DataSource = allCourses.Select(c => c.Name).ToList();
        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (McqsInput.Value == 0 && TfInput.Value == 0) throw new Exception();
                if (MessageBox.Show("Are you sure?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    connection.ExecuteScalar(
                        "Exams.generateExam",
                        new { numOfMcq = McqsInput.Value, numOfTf = TfInput.Value, cid = allCourses.Where(c => c.Name == CourseBox.SelectedItem).Select(c => c.Id).First(), minutes = MinutesInput.Value },
                        commandType: CommandType.StoredProcedure);
                    MessageBox.Show("Exam Added Successfully", "", MessageBoxButtons.OK);
                    this.Close();
                }
            }
            catch
            {
                MessageBox.Show("Unable to Generate Exam", "", MessageBoxButtons.OK);
            }
        }
    }
}
