using Dapper;
using Microsoft.Data.SqlClient;
using WinFormsApp1.Models;
using System.Data;
using System.Configuration;

namespace WinFormsApp1
{
    public partial class Login : Form
    {
        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ExaminationSystem"].ConnectionString);
        public Login()
        {
            InitializeComponent();
        }
        private void LoginButton_Click(object sender, EventArgs e)
        {
            try
            {
                var logins = connection.Query<Credentials>("Users.getLogins", commandType: CommandType.StoredProcedure);
                var match = logins.Where(l => l.Username == UserName.Text && l.Password == Password.Text).First();
                if (match.Role == "Instructor")
                {
                    var home = new InstructorDashboard(connection);
                    InstructorDashboard.instructorId = match.Id;
                    this.Hide();
                    home.ShowDialog();
                    this.Close();
                }
                else
                {
                    var home = new StudentDashboard(connection);
                    StudentDashboard.studentId = match.Id;
                    this.Hide();
                    home.ShowDialog();
                    this.Close();
                }
            }
            catch
            {
                MessageBox.Show("Invalid Username or Password", "", MessageBoxButtons.OK);
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
