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
	public partial class UpdateStudent : Form
	{
		SqlConnection connection;
		List<Person> students;
		List<Department> departments;
        public UpdateStudent(SqlConnection conn, List<Person> allStudents, List<Department> allDepartments)
		{
			InitializeComponent();
			connection = conn;
			students = allStudents;
			departments = allDepartments;
			UpdateBox.DataSource = students.Select(s => s.Id).ToList();
			DepartmentBox.DataSource = departments.Select(d => d.Name).ToList();
		}

		private void UpdateButton_Click(object sender, EventArgs e)
		{
            try
            {
                if (UpdateBox.SelectedItem == null)
                    throw new Exception();
                if (MessageBox.Show("Are you sure?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
					if (!AddressInput.Text.IsNullOrEmpty())
                    connection.ExecuteScalar(
                        "Users.updateAddress",
                        new { id = UpdateBox.SelectedItem, address=AddressInput.Text },
                        commandType: CommandType.StoredProcedure);

                    if (!EmailInput.Text.IsNullOrEmpty())
                        connection.ExecuteScalar(
                            "Users.updateEmail",
                            new { id = UpdateBox.SelectedItem, email = EmailInput.Text },
                            commandType: CommandType.StoredProcedure);

                    if (!PhoneInput.Text.IsNullOrEmpty())
                        connection.ExecuteScalar(
                            "Users.updatePhone",
                            new { id = UpdateBox.SelectedItem, phone = PhoneInput.Text },
                            commandType: CommandType.StoredProcedure);

                    connection.ExecuteScalar(
                        "Users.updateStudentDepartment",
                        new { id = UpdateBox.SelectedItem, dept = departments.Where(d => d.Name == (string)DepartmentBox.SelectedItem).Select(d => d.Id).First() },
                        commandType: CommandType.StoredProcedure);

                    MessageBox.Show("Student Updated Successfully", "", MessageBoxButtons.OK);
                    this.Close();
                }
            }
            catch
            {
                MessageBox.Show("Unable to Update Student", "", MessageBoxButtons.OK);
            }
        }

		private void UpdateBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			NameInput.Text = students.Where(s => s.Id == (int)UpdateBox.SelectedItem).Select(s => s.Name).First();
			AddressInput.Text = students.Where(s => s.Id == (int)UpdateBox.SelectedItem).Select(s => s.Address).First();
			PhoneInput.Text = students.Where(s => s.Id == (int)UpdateBox.SelectedItem).Select(s => s.PhoneNumber).First();
			EmailInput.Text = students.Where(s => s.Id == (int)UpdateBox.SelectedItem).Select(s => s.Email).First();
		}
	}
}
