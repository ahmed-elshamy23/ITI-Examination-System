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
	public partial class ShowExam : Form
	{
		private readonly SqlConnection connection;
		private readonly int examId;
		private readonly string courseName;
		List<Exam> exams;

		public ShowExam(SqlConnection _connection, int examId, string courseName)
		{
			InitializeComponent();
			connection = _connection;
			this.examId = examId;
			this.courseName = courseName;

			// Define custom type map for Exam class
			SqlMapper.SetTypeMap(typeof(Exam), new CustomPropertyTypeMap(
				typeof(Exam),
				(type, columnName) => type.GetProperties().FirstOrDefault(prop => prop.Name.Replace(" ", "") == columnName.Replace(" ", ""))
			));
		}

		private void ShowExam_Load(object sender, EventArgs e)
		{
			exams = connection.Query<Exam>("reports.getExamQuestions", new { id = examId }, commandType: CommandType.StoredProcedure).ToList();

			Exam.Text = $"Exam #{examId}";
			Course.Text = courseName;
			PanelQuestion.AutoScroll = true;

			int previousLocation = 0;
			int previousGroup = 0;
			
			for (int i = 0; i < exams.Count; i++)
			{
				var questionGroupBox = new Panel
				{
					AutoSize = true,
					Location = new Point(10, previousGroup + 25)
				};

				var questionLabel = new Label
				{
					Text = $"Q{i + 1}) {exams[i].Question}",
					AutoSize = true,
					Location = new Point(10, 25)
				};
				questionLabel.Font = new Font(questionLabel.Font, FontStyle.Bold);
				questionGroupBox.Controls.Add(questionLabel);
				previousLocation = questionLabel.Location.Y + questionLabel.Size.Height;

				var option1RadioButton = new RadioButton
				{
					Text = exams[i].Option1,
					AutoSize = true,
					Location = new Point(30, previousLocation + 25)
				};
				questionGroupBox.Controls.Add(option1RadioButton);
				previousLocation = option1RadioButton.Location.Y + option1RadioButton.Size.Height;

				var option2RadioButton = new RadioButton
				{
					Text = exams[i].Option2,
					AutoSize = true,
					Location = new Point(30, previousLocation + 25)
				};
				questionGroupBox.Controls.Add(option2RadioButton);
				previousLocation = option2RadioButton.Location.Y + option2RadioButton.Size.Height;

				if (exams[i].Type != "True or False")
				{
					var option3RadioButton = new RadioButton
					{
						Text = exams[i].Option3,
						AutoSize = true,
						Location = new Point(30, previousLocation + 25)
					};
					questionGroupBox.Controls.Add(option3RadioButton);
					previousLocation = option3RadioButton.Location.Y + option3RadioButton.Size.Height;

					var option4RadioButton = new RadioButton
					{
						Text = exams[i].Option4,
						AutoSize = true,
						Location = new Point(30, previousLocation + 25)
					};
					questionGroupBox.Controls.Add(option4RadioButton);
					previousLocation = option4RadioButton.Location.Y + option4RadioButton.Size.Height;
				}
				questionGroupBox.Width = 798;
				PanelQuestion.Controls.Add(questionGroupBox);
				previousGroup = questionGroupBox.Location.Y + questionGroupBox.Size.Height;
			}


			// Answers in two columns

			/*
			int verticalOffset = 10;

			for (int i = 0; i < exams.Count; i++)
			{
				var questionLabel = new Label
				{
					Text = $"Q{i + 1}) {exams[i].Question}",
					AutoSize = true,
					MaximumSize = new Size(PanelQuestion.Width - 20, 0),
					Location = new Point(10, verticalOffset)
				};
				questionLabel.Font = new Font(questionLabel.Font, FontStyle.Bold);
				PanelQuestion.Controls.Add(questionLabel);

				verticalOffset += questionLabel.Height + 10;

				var option1RadioButton = new RadioButton
				{
					Text = exams[i].Option1,
					AutoSize = true,
					MaximumSize = new Size((PanelQuestion.Width - 40) / 2, 0),
					Location = new Point(30, verticalOffset)
				};
				PanelQuestion.Controls.Add(option1RadioButton);

				var option2RadioButton = new RadioButton
				{
					Text = exams[i].Option2,
					AutoSize = true,
					MaximumSize = new Size((PanelQuestion.Width - 40) / 2, 0),
					Location = new Point(30 + (PanelQuestion.Width - 40) / 2, verticalOffset)
				};
				PanelQuestion.Controls.Add(option2RadioButton);

				verticalOffset += option1RadioButton.Height + 10;

				if (exams[i].Type != "True or False")
				{
					var option3RadioButton = new RadioButton
					{
						Text = exams[i].Option3,
						AutoSize = true,
						MaximumSize = new Size((PanelQuestion.Width - 40) / 2, 0),
						Location = new Point(30, verticalOffset)
					};
					PanelQuestion.Controls.Add(option3RadioButton);

					var option4RadioButton = new RadioButton
					{
						Text = exams[i].Option4,
						AutoSize = true,
						MaximumSize = new Size((PanelQuestion.Width - 40) / 2, 0),
						Location = new Point(30 + (PanelQuestion.Width - 40) / 2, verticalOffset)
					};
					PanelQuestion.Controls.Add(option4RadioButton);

					verticalOffset += option3RadioButton.Height + 20;
				}
				else
				{
					verticalOffset += 20;
				}
			}

			*/
		}

		private void Back_Click(object sender, EventArgs e)
		{
			Hide();
			var examSelection = new ExamSelection(connection);
			examSelection.ShowDialog();
			Close();
		}
	}
}
