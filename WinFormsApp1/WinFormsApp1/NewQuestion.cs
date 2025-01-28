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
    public partial class NewQuestion : Form
    {
        SqlConnection connection;
        List<Course> allCourses;
        public NewQuestion(SqlConnection conn, List<Course> courses)
        {
            InitializeComponent();
            connection = conn;
            allCourses = courses;
        }

        private void NewMcqButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var newMcq = new NewMcq(connection, allCourses);
            newMcq.ShowDialog();
            this.Close();
        }

        private void NewTfButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var newTf = new NewTF(connection, allCourses);
            newTf.ShowDialog();
            this.Close();
        }
    }
}
