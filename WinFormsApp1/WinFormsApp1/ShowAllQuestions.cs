using Dapper;
using Microsoft.Data.SqlClient;
using System.Data;
using WinFormsApp1.Models;

namespace WinFormsApp1
{
    public partial class ShowAllQuestions : Form
    {
        SqlConnection connection;
        List<Course> allCourses;
        List<Exam> questions;
        int pageNumber = 0;
        public ShowAllQuestions(SqlConnection conn)
        {
            InitializeComponent();
            connection = conn;
            allCourses = (List<Course>)connection.Query<Course>("Courses.getCourseNames", commandType: CommandType.StoredProcedure);
            CourseBox.DataSource = allCourses.Select(x => x.Name).ToList();
            SqlMapper.SetTypeMap(typeof(Exam), new CustomPropertyTypeMap(
                typeof(Exam),
                (type, columnName) => type.GetProperties().FirstOrDefault(prop => prop.Name.Replace(" ", "") == columnName.Replace(" ", ""))
            ));
            questions = connection.Query<Exam>("Exams.getAllQuestions", new { cid = allCourses.Where(c => c.Name == CourseBox.SelectedItem).Select(c => c.Id).First() }, commandType: CommandType.StoredProcedure).ToList();
            PanelQuestion.AutoScroll = true;
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Hide();
            var home = new InstructorDashboard(connection);
            home.ShowDialog();
            Close();
        }

        private void ShowAllQuestions_Load(object sender, EventArgs e)
        {
            updateButtons();
            UpdatePanel();
        }

        private void UpdatePanel()
        {
            int previousLocation = 0;
            int previousGroup = 0;
            PanelQuestion.Controls.Clear();
            for (int i = 125 * pageNumber; i < 124 + 125 * pageNumber && i < questions.Count; i++)
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
                    Text = questions[i].Option1,
                    AutoSize = true,
                    Location = new Point(30, previousLocation + 25),
                    Enabled = false
                };
                questionGroupBox.Controls.Add(option1RadioButton);
                previousLocation = option1RadioButton.Location.Y + option1RadioButton.Size.Height;

                var option2RadioButton = new RadioButton
                {
                    Text = questions[i].Option2,
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
                        Text = questions[i].Option3,
                        AutoSize = true,
                        Location = new Point(30, previousLocation + 25),
                        Enabled = false
                    };
                    questionGroupBox.Controls.Add(option3RadioButton);
                    previousLocation = option3RadioButton.Location.Y + option3RadioButton.Size.Height;

                    var option4RadioButton = new RadioButton
                    {
                        Text = questions[i].Option4,
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

        private void updateButtons()
        {
            if (pageNumber > 0 && pageNumber < questions.Count / 125)
            {
                previousButton.BackColor = Color.FromArgb(154, 51, 51);
                previousButton.Cursor = Cursors.Hand;
                nextButton.BackColor = Color.FromArgb(154, 51, 51);
                nextButton.Cursor = Cursors.Hand;
            }
            if (pageNumber == 0)
            {
                previousButton.BackColor = Color.FromArgb(100, 154, 51, 51);
                previousButton.Cursor = Cursors.No;
                if (questions.Count / 125 > 0)
                {
                    nextButton.BackColor = Color.FromArgb(154, 51, 51);
                    nextButton.Cursor = Cursors.Hand;
                }
                else
                {
                    nextButton.BackColor = Color.FromArgb(100, 154, 51, 51);
                    nextButton.Cursor = Cursors.No;
                }
            }
            else if (pageNumber == questions.Count / 125)
            {
                previousButton.BackColor = Color.FromArgb(154, 51, 51);
                previousButton.Cursor = Cursors.Hand;
                nextButton.BackColor = Color.FromArgb(100, 154, 51, 51);
                nextButton.Cursor = Cursors.No;
            }
        }

        private void previousButton_Click(object sender, EventArgs e)
        {
            if (pageNumber > 0)
            {
                pageNumber--;
                updateButtons();
                UpdatePanel();
            }
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            if (pageNumber < questions.Count / 125)
            {
                pageNumber++;
                updateButtons();
                UpdatePanel();
            }
        }

        private void CourseBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            questions = connection.Query<Exam>("Exams.getAllQuestions", new { cid = allCourses.Where(c => c.Name == CourseBox.SelectedItem).Select(c => c.Id).First() }, commandType: CommandType.StoredProcedure).ToList();
            pageNumber = 0;
            updateButtons();
            UpdatePanel();
        }

        private void NewQuestionButton_Click(object sender, EventArgs e)
        {
            var newQuestion = new NewQuestion(connection, allCourses);
            newQuestion.ShowDialog();
            questions = connection.Query<Exam>("Exams.getAllQuestions", new { cid = allCourses.Where(c => c.Name == CourseBox.SelectedItem).Select(c => c.Id).First() }, commandType: CommandType.StoredProcedure).ToList();
            updateButtons();
            UpdatePanel();
        }
    }
}
