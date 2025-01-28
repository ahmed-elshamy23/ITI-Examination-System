using Dapper;
using Microsoft.Data.SqlClient;
using System.Data;
using WinFormsApp1.Models;

namespace WinFormsApp1
{
	public partial class PreviousExams : Form
	{
		SqlConnection connection;
		Person student;
		List<StudentExam> allStudentExams;
		List<Exam> questions;
        List<List<int>> answerIds = new();
        Panel panels = new();
        List<StudentAnswer> studentAnswers;
        public PreviousExams(SqlConnection conn, Person s)
		{
			InitializeComponent();
			connection = conn;
			student = s;
			PanelQuestion.AutoScroll = true;
			allStudentExams = (List<StudentExam>)connection.Query<StudentExam>("Exams.getStudentExams", new { id = student.Id }, commandType: CommandType.StoredProcedure);
			SqlMapper.SetTypeMap(typeof(Exam), new CustomPropertyTypeMap(
				typeof(Exam),
				(type, columnName) => type.GetProperties().FirstOrDefault(prop => prop.Name.Replace(" ", "") == columnName.Replace(" ", ""))
			));
            //CourseBox.DataSource = allStudentExams.Select(x => x.Course).Distinct().ToList();
            foreach (var course in allStudentExams)
            {
                if (!CourseBox.Items.Contains(course.Course))
                {
                    CourseBox.Items.Add(course.Course);
                }
            }
        }

		private void Back_Click(object sender, EventArgs e)
		{
			Hide();
			var home = new StudentDashboard(connection);
			home.ShowDialog();
			Close();
		}

		private void CourseBox_SelectedIndexChanged(object sender, EventArgs e)
		{
            ExamBox.Items.Clear();
            foreach (var exam in allStudentExams)
            {
                if (exam.Course == CourseBox.SelectedItem.ToString())
                {
                    ExamBox.Items.Add($"Exam #{exam.Exam}");
                }
            }
            ExamBox.SelectedItem = null;
			PanelQuestion.Controls.Clear();
		}

		private void ExamBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (ExamBox.SelectedItem != null)
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
                studentAnswers = connection.Query<StudentAnswer>("Reports.getStudentAnswers", new { sid = student.Id, eid = int.Parse(ExamBox.Text.Split("#")[1]) }, commandType: CommandType.StoredProcedure).ToList();
                UpdatePanel();
                CheckAnswers();
			}
		}

        private void CheckAnswers()
        {
            for (int i = 0; i < questions.Count; i++)
            {
                for (int j = 1; j < panels.Controls[i].Controls.Count; j++)
                {
                    var radioButton = panels.Controls[i].Controls[j] as RadioButton;
                    if (answerIds[i][j - 1] == studentAnswers[i].StudentAnswerId)
                    {
                        radioButton.Checked = true;
                        break;
                    }
                }
            }
            //var parameters = new DynamicParameters();
            //parameters.Add("@sid", studentId, DbType.Int32);
            //parameters.Add("@eid", examId, DbType.Int32);
            //parameters.Add("@questionsWithAnswers", submittedAnswers.AsTableValuedParameter("questionAndAnswer"));
            //return connection.Query<int>("Exams.saveExamAnswers", parameters, commandType: CommandType.StoredProcedure).First();
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
                panels = PanelQuestion;
                previousGroup = questionGroupBox.Location.Y + questionGroupBox.Size.Height;
            }
        }
    }
}
