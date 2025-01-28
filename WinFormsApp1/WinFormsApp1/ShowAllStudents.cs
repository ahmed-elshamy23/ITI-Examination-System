using Dapper;
using Microsoft.Data.SqlClient;
using System.Data;
using WinFormsApp1.Models;

namespace WinFormsApp1
{
	public partial class ShowAllStudents : Form
	{
		SqlConnection connection;
		List<Person> allStudents;
		List<Course> allCourses;
		List<Department> allDepts;
		public ShowAllStudents(SqlConnection conn)
		{
			InitializeComponent();
			connection = conn;
			allStudents = (List<Person>)connection.Query<Person>("Users.getAllStudents", commandType: CommandType.StoredProcedure);
			allCourses = (List<Course>)connection.Query<Course>("Courses.getCourseNames", commandType: CommandType.StoredProcedure);
			allDepts = (List<Department>)connection.Query<Department>("Courses.getDepartmentNames", commandType: CommandType.StoredProcedure);
			dataGridView1.DataSource = allStudents.Select(s => new { s.Id, s.Name, s.Age, s.Address, s.PhoneNumber, s.Email }).OrderBy(s => s.Id).ToList();
			var courseName = allCourses.Select(x => x.Name).ToList();
			var deptName = allDepts.Select(x => x.Name).ToList();
			CourseBox.DataSource = courseName;
			DepartmentBox.DataSource = deptName;
		}
		private void BackButton_Click(object sender, EventArgs e)
		{
			this.Hide();
			var home = new InstructorDashboard(connection);
			home.ShowDialog();
			this.Close();
		}

		private void NewStudentButton_Click(object sender, EventArgs e)
		{
			var newStudent = new NewStudent(connection, allDepts);
			newStudent.ShowDialog();
			allStudents = (List<Person>)connection.Query<Person>("Users.getAllStudents", commandType: CommandType.StoredProcedure);
			dataGridView1.DataSource = allStudents.OrderBy(s => s.Id).ToList();
		}

		private void ApplyFilters(object sender, EventArgs e)
		{
			var deptStudents = connection.Query<Person>("Reports.getStudentsByDepartment", new { did = allDepts.Where(d => d.Name == (string)DepartmentBox.SelectedItem).Select(d => d.Id).First() }, commandType: CommandType.StoredProcedure).Select(s => new { s.Id, s.Name, s.Age, s.Address, s.PhoneNumber, s.Email });
			var courseStudents = connection.Query<Person>("Reports.getStudentsByCourse", new { cid = allCourses.Where(c => c.Name == (string)CourseBox.SelectedItem).Select(c => c.Id).First() }, commandType: CommandType.StoredProcedure);
			if (CourseCheckBox.Checked && DepartmentCheckBox.Checked)
			{
				dataGridView1.DataSource =
				allStudents.Join(deptStudents,
								 s => s.Id,
								 s => s.Id,
								 (s, s1) => s)
							.Join(courseStudents,
								 s => s.Id,
								 s => s.Id,
								 (s, s1) => s).Select(s => new { s.Id, s.Name, s.Age, s.Address, s.PhoneNumber, s.Email }).OrderBy(s => s.Id).ToList();
			}
			else if (CourseCheckBox.Checked)
				dataGridView1.DataSource =
				allStudents.Join(courseStudents,
								 s => s.Id,
								 s => s.Id,
								 (s, s1) => s).Select(s => new { s.Id, s.Name, s.Age, s.Address, s.PhoneNumber, s.Email }).OrderBy(s => s.Id).ToList();
			else if (DepartmentCheckBox.Checked)
				dataGridView1.DataSource =
				allStudents.Join(deptStudents,
								 s => s.Id,
								 s => s.Id,
								 (s, s1) => s).Select(s => new { s.Id, s.Name, s.Age, s.Address, s.PhoneNumber, s.Email }).OrderBy(s => s.Id).ToList();
			else dataGridView1.DataSource = allStudents.Select(s => new { s.Id, s.Name, s.Age, s.Address, s.PhoneNumber, s.Email }).OrderBy(s => s.Id).ToList();
		}

		private void DeleteStudentButton_Click(object sender, EventArgs e)
		{
			var deleteStudent = new DeleteStudent(connection, allStudents.Select(s => s.Id).ToList());
			deleteStudent.ShowDialog();
			allStudents = (List<Person>)connection.Query<Person>("Users.getAllStudents", commandType: CommandType.StoredProcedure);
			dataGridView1.DataSource = allStudents.OrderBy(s => s.Id).ToList();
		}

		private void UpdateStudentButton_Click(object sender, EventArgs e)
		{
			var updateStudent = new UpdateStudent(connection, allStudents, allDepts);
			updateStudent.ShowDialog();
			allStudents = (List<Person>)connection.Query<Person>("Users.getAllStudents", commandType: CommandType.StoredProcedure);
			DepartmentCheckBox.Checked = false;
			CourseCheckBox.Checked = false;
			dataGridView1.DataSource = allStudents.OrderBy(s => s.Id).ToList();
		}
	}
}
