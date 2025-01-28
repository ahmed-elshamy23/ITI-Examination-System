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
    public partial class NewStudent : Form
    {
        SqlConnection connection;
        List<Department> allDepts;

        public NewStudent(SqlConnection conn, List<Department> departments)
        {
            InitializeComponent();
            connection = conn;
            allDepts = departments;
            DeptInput.DataSource = allDepts.Select(d => d.Name).ToList();
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
                    "Users.newStudent",
                    new { fname = FirstNameInput.Text, lname = LastNameInput.Text, Address = AddressInput.Text, dob = DobInput.Value, Phone = PhoneInput.Text, email = EmailInput.Text, dept = allDepts.Where(d => d.Name == DeptInput.SelectedItem).Select(d => d.Id).First() },
                    commandType: CommandType.StoredProcedure);
                MessageBox.Show("Student Added Successfully", "", MessageBoxButtons.OK);
                this.Close();
            }
            catch
            {
                MessageBox.Show("Unable to Insert Student", "", MessageBoxButtons.OK);
            }
        }
    }
}
