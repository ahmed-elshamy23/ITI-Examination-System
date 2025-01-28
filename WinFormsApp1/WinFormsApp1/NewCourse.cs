using Dapper;
using Microsoft.Data.SqlClient;
using System.Data;

namespace WinFormsApp1
{
    public partial class NewCourse : Form
    {
        SqlConnection connection;
        public NewCourse(SqlConnection conn)
        {
            InitializeComponent();
            connection = conn;
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Control c in this.Controls)
                {
                    if (c is TextBox)
                    {
                        TextBox textBox = c as TextBox;
                        if (textBox.Text == string.Empty)
                        {
                            throw new Exception();
                        }
                    }
                }
                connection.ExecuteScalar(
                    "Courses.newCourse",
                    new { name = CourseNameInput.Text, duration = CourseDurationInput.Text },
                    commandType: CommandType.StoredProcedure);
                MessageBox.Show("Course Added Successfully", "", MessageBoxButtons.OK);
                this.Close();
            }
            catch
            {
                MessageBox.Show("Unable to Insert Course", "", MessageBoxButtons.OK);
            }
        }
    }
}
