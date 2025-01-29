using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.ReportingServices.Diagnostics.Internal;
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
    public partial class StudentAnswersReport : Form
    {
        SqlConnection connection;
        List<Course> allCourses;
        List<CourseExam> courseExams;
        List<Person> examStudents;
        List<Exam> questions;
        List<List<int>> answerIds = new();
        List<StudentAnswer> studentAnswers;
        public StudentAnswersReport(SqlConnection conn)
        {
            InitializeComponent();
            connection = conn;
            SqlMapper.SetTypeMap(typeof(Exam), new CustomPropertyTypeMap(
                typeof(Exam),
                (type, columnName) => type.GetProperties().FirstOrDefault(prop => prop.Name.Replace(" ", "") == columnName.Replace(" ", ""))
            ));
            PanelQuestion.AutoScroll = true;
            courseExams = connection.Query<CourseExam>("Exams.examCourse", commandType: CommandType.StoredProcedure).ToList();
            allCourses = connection.Query<Course>("Courses.getCourseNames", commandType: CommandType.StoredProcedure).ToList();
            CourseBox.DataSource = allCourses.Select(c => c.Name).ToList();
            foreach (var course in courseExams)
            {
                if (course.CourseName == CourseBox.SelectedItem)
                {
                    ExamBox.Items.Add($"Exam #{course.ExamId}");
                }
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            var home = new Reports(connection);
            home.ShowDialog();
            this.Close();
        }

        private void CourseBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ExamBox.Items.Clear();
            PanelQuestion.Controls.Clear();
            StudentBox.SelectedItem = null;
            foreach (var course in courseExams)
            {
                if (course.CourseName == CourseBox.SelectedItem.ToString())
                {
                    ExamBox.Items.Add($"Exam #{course.ExamId}");
                }
            }
        }

        private void ExamBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            examStudents = connection.Query<Person>("Exams.getExamStudents", new { id = ExamBox.SelectedItem.ToString().Split("#")[1] }, commandType: CommandType.StoredProcedure).ToList();
            StudentBox.DataSource = examStudents.Select(s => s.Name).ToList();
            StudentBox.SelectedItem = null;
            PanelQuestion.Controls.Clear();
        }

        private void StudentBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (StudentBox.SelectedItem != null)
            {
                questions = connection.Query<Exam>("Exams.getGeneratedExam", new { id = int.Parse(ExamBox.Text.Split("#")[1]) }, commandType: CommandType.StoredProcedure).ToList();
                answerIds.Clear();
                foreach (var question in questions)
                {
                    if (question.Type != "True or False")
                        answerIds.Add(new List<int>
                        {
                            int.Parse(question.Option1.Split("...")[0]),
                            int.Parse(question.Option2.Split("...")[0]),
                            int.Parse(question.Option3.Split("...")[0]),
                            int.Parse(question.Option4.Split("...")[0])
                        });
                    else
                        answerIds.Add(new List<int>
                        {
                            int.Parse(question.Option1.Split("...")[0]),
                            int.Parse(question.Option2.Split("...")[0])
                        });
                }
                studentAnswers = connection.Query<StudentAnswer>("Reports.getStudentAnswers", new { sid = examStudents.Where(s => s.Name == StudentBox.SelectedItem).Select(s => s.Id).First(), eid = int.Parse(ExamBox.Text.Split("#")[1]) }, commandType: CommandType.StoredProcedure).ToList();
                UpdatePanel();
                CheckAnswers();
            }
        }
        private void CheckAnswers()
        {
            for (int i = 0; i < questions.Count; i++)
            {
                for (int j = 1; j < PanelQuestion.Controls[i].Controls.Count; j++)
                {
                    var radioButton = PanelQuestion.Controls[i].Controls[j] as RadioButton;
                    if (answerIds[i][j - 1] == studentAnswers[i].StudentAnswerId)
                    {
                        radioButton.Checked = true;
                        break;
                    }
                }
            }
        }

        private void UpdatePanel()
        {
            int previousLocation = 0;
            int previousGroup = 0;
            PanelQuestion.Controls.Clear();
            for (int i = 0; i < questions.Count; i++)
            {
                var questionGroupBox = new Panel
                {
                    AutoSize = true,
                    Location = new Point(10, previousGroup + 25)
                };

                var questionLabel = new Label
                {
                    Text = $"Q{i + 1}) {questions[i].Question}",
                    AutoSize = true,
                    Location = new Point(10, 25)
                };
                questionLabel.Font = new Font(questionLabel.Font, FontStyle.Bold);
                questionGroupBox.Controls.Add(questionLabel);
                previousLocation = questionLabel.Location.Y + questionLabel.Size.Height;

                var option1RadioButton = new RadioButton
                {
                    Text = questions[i].Option1.Split("...")[1],
                    AutoSize = true,
                    Location = new Point(30, previousLocation + 25),
                    Enabled = false
                };
                questionGroupBox.Controls.Add(option1RadioButton);
                previousLocation = option1RadioButton.Location.Y + option1RadioButton.Size.Height;

                var option2RadioButton = new RadioButton
                {
                    Text = questions[i].Option2.Split("...")[1],
                    AutoSize = true,
                    Location = new Point(30, previousLocation + 25),
                    Enabled = false
                };
                questionGroupBox.Controls.Add(option2RadioButton);
                previousLocation = option2RadioButton.Location.Y + option2RadioButton.Size.Height;

                if (questions[i].Type != "True or False")
                {
                    var option3RadioButton = new RadioButton
                    {
                        Text = questions[i].Option3.Split("...")[1],
                        AutoSize = true,
                        Location = new Point(30, previousLocation + 25),
                        Enabled = false
                    };
                    questionGroupBox.Controls.Add(option3RadioButton);
                    previousLocation = option3RadioButton.Location.Y + option3RadioButton.Size.Height;

                    var option4RadioButton = new RadioButton
                    {
                        Text = questions[i].Option4.Split("...")[1],
                        AutoSize = true,
                        Location = new Point(30, previousLocation + 25),
                        Enabled = false
                    };
                    questionGroupBox.Controls.Add(option4RadioButton);
                    previousLocation = option4RadioButton.Location.Y + option4RadioButton.Size.Height;
                }
                PanelQuestion.Controls.Add(questionGroupBox);
                previousGroup = questionGroupBox.Location.Y + questionGroupBox.Size.Height;
            }
        }

        private void GeneratePdfButton_Click(object sender, EventArgs e)
        {
            if (PanelQuestion.Controls.Count == 0)
                MessageBox.Show("Empty Data", "");
            else
                GeneratePdf.GenerateFromQuestionsAndAnswers($"Answers of {StudentBox.SelectedItem} in {CourseBox.SelectedItem} {ExamBox.SelectedItem}", questions, studentAnswers);
        }
    }
}
