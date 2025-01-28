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
    public partial class StartExam : Form
    {
        SqlConnection connection;
        int studentId, examId;
        List<Exam> questions;
        List<List<int>> answerIds = new();
        DataTable submittedAnswers = new();
        Panel panels = new();
        public StartExam(SqlConnection conn, int sid, int eid)
        {
            InitializeComponent();
            this.connection = conn;
            studentId = sid;
            examId = eid;
            timeLeft = connection.Query<int>("Exams.getExamDuration", new { id = eid }, commandType: CommandType.StoredProcedure).First() * 60;
            SqlMapper.SetTypeMap(typeof(Exam), new CustomPropertyTypeMap(
                typeof(Exam),
                (type, columnName) => type.GetProperties().FirstOrDefault(prop => prop.Name.Replace(" ", "") == columnName.Replace(" ", ""))
            ));
            questions = connection.Query<Exam>("Exams.getGeneratedExam", new { id = eid }, commandType: CommandType.StoredProcedure).ToList();
            PanelQuestion.AutoScroll = true;
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
            submittedAnswers.Columns.Add("qid", typeof(int));
            submittedAnswers.Columns.Add("aid", typeof(int));
            UpdatePanel();
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
                    Location = new Point(30, previousLocation + 25)
                };
                questionGroupBox.Controls.Add(option1RadioButton);
                previousLocation = option1RadioButton.Location.Y + option1RadioButton.Size.Height;

                var option2RadioButton = new RadioButton
                {
                    Text = questions[i].Option2.Split("...")[1],
                    AutoSize = true,
                    Location = new Point(30, previousLocation + 25)
                };
                questionGroupBox.Controls.Add(option2RadioButton);
                previousLocation = option2RadioButton.Location.Y + option2RadioButton.Size.Height;

                if (questions[i].Type != "True or False")
                {
                    var option3RadioButton = new RadioButton
                    {
                        Text = questions[i].Option3.Split("...")[1],
                        AutoSize = true,
                        Location = new Point(30, previousLocation + 25)
                    };
                    questionGroupBox.Controls.Add(option3RadioButton);
                    previousLocation = option3RadioButton.Location.Y + option3RadioButton.Size.Height;

                    var option4RadioButton = new RadioButton
                    {
                        Text = questions[i].Option4.Split("...")[1],
                        AutoSize = true,
                        Location = new Point(30, previousLocation + 25)
                    };
                    questionGroupBox.Controls.Add(option4RadioButton);
                    previousLocation = option4RadioButton.Location.Y + option4RadioButton.Size.Height;
                }
                PanelQuestion.Controls.Add(questionGroupBox);
                panels = PanelQuestion;
                previousGroup = questionGroupBox.Location.Y + questionGroupBox.Size.Height;
            }
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    var grade = SubmitAnswers();
                    MessageBox.Show($"Your Grade is: {grade}%", "", MessageBoxButtons.OK);
                    var home = new StudentDashboard(connection);
                    this.Hide();
                    home.ShowDialog();
                    this.Close();
                }
            }
            catch
            {
                MessageBox.Show("Unable to Save Answers", "", MessageBoxButtons.OK);
            }
        }

        private int SubmitAnswers()
        {
            for (int i = 0; i < questions.Count; i++)
            {
                int? studentAnswer = null;
                for (int j = 1; j < panels.Controls[i].Controls.Count; j++)
                {
                    var radioButton = panels.Controls[i].Controls[j] as RadioButton;
                    if (radioButton.Checked)
                    {
                        studentAnswer = answerIds[i][j - 1];
                        break;
                    }
                }
                submittedAnswers.Rows.Add(questions[i].QuestionId, studentAnswer);
            }
            var parameters = new DynamicParameters();
            parameters.Add("@sid", studentId, DbType.Int32);
            parameters.Add("@eid", examId, DbType.Int32);
            parameters.Add("@questionsWithAnswers", submittedAnswers.AsTableValuedParameter("questionAndAnswer"));
            return connection.Query<int>("Exams.saveExamAnswers", parameters, commandType: CommandType.StoredProcedure).First();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timeLeft--;
            if (timeLeft == 0)
            {
                try
                {
                    MessageBox.Show("Time is Up", "", MessageBoxButtons.OK);
                    var grade = SubmitAnswers();
                    MessageBox.Show($"Your Grade is: {grade}%", "", MessageBoxButtons.OK);
                    var home = new StudentDashboard(connection);
                    this.Hide();
                    home.ShowDialog();
                    this.Close();
                }
                catch
                {
                    MessageBox.Show("Unable to Save Answers", "", MessageBoxButtons.OK);
                }
            }
            else
            {
                PanelQuestion.Focus();
                timeLabel.Text = $"{timeLeft / 60}:{timeLeft % 60}";
                PanelQuestion.Focus();
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Hide();
                var home = new StudentDashboard(connection);
                home.ShowDialog();
                Close();
            }
        }
    }
}
