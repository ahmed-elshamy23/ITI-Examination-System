using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Tokens;
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
    public partial class InstructorProfile : Form
    {
        Person instructor;
        SqlConnection connection;
        public InstructorProfile(SqlConnection conn, Person ins)
        {
            InitializeComponent();
            connection = conn;
            instructor = ins;
            IdInput.Text = instructor.Id.ToString();
            NameInput.Text = instructor.Name;
            SalaryInput.Text = $"{instructor.Salary:c}";
            AddressInput.Text = instructor.Address;
            PhoneInput.Text = instructor.PhoneNumber;
            EmailInput.Text = instructor.Email;
            DepartmentInput.Text = instructor.Dept;
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
                            new { id = instructor.Id, address = AddressInput.Text },
                            commandType: CommandType.StoredProcedure);

                    if (!EmailInput.Text.IsNullOrEmpty())
                        connection.ExecuteScalar(
                            "Users.updateEmail",
                            new { id = instructor.Id, email = EmailInput.Text },
                            commandType: CommandType.StoredProcedure);

                    if (!PhoneInput.Text.IsNullOrEmpty())
                        connection.ExecuteScalar(
                            "Users.updatePhone",
                            new { id = instructor.Id, phone = PhoneInput.Text },
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
