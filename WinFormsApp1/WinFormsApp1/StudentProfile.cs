using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Tokens;
using System.Data;
using WinFormsApp1.Models;

namespace WinFormsApp1
{
    public partial class StudentProfile : Form
    {
        Person student;
        SqlConnection connection;
        public StudentProfile(SqlConnection conn, Person s)
        {
            InitializeComponent();
            connection = conn;
            student = s;
            IdInput.Text = student.Id.ToString();
            NameInput.Text = student.Name;
            AddressInput.Text = student.Address;
            PhoneInput.Text = student.PhoneNumber;
            EmailInput.Text = student.Email;
            DepartmentInput.Text = student.Dept;
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (!AddressInput.Text.IsNullOrEmpty())
                        connection.ExecuteScalar(
                            "Users.updateAddress",
                            new { id = student.Id, address = AddressInput.Text },
                            commandType: CommandType.StoredProcedure);

                    if (!EmailInput.Text.IsNullOrEmpty())
                        connection.ExecuteScalar(
                            "Users.updateEmail",
                            new { id = student.Id, email = EmailInput.Text },
                            commandType: CommandType.StoredProcedure);

                    if (!PhoneInput.Text.IsNullOrEmpty())
                        connection.ExecuteScalar(
                            "Users.updatePhone",
                            new { id = student.Id, phone = PhoneInput.Text },
                            commandType: CommandType.StoredProcedure);

                    MessageBox.Show("Profile Updated Successfully", "", MessageBoxButtons.OK);
                    this.Close();
                }
            }
            catch
            {
                MessageBox.Show("Unable to Update Profile", "", MessageBoxButtons.OK);
            }
        }
    }
}
