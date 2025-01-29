using iTextSharp.text.pdf;
using iTextSharp.text;
using System.Drawing.Imaging;
using WinFormsApp1.Models;
using System.Windows.Forms;
using System.Diagnostics;

namespace WinFormsApp1
{
	internal static class GeneratePdf
	{
		public static void Generate(string t, DataGridView dataGridView1)
		{
			SaveFileDialog sfd = new SaveFileDialog();
			sfd.Filter = "PDF (*.pdf)|*.pdf";
			sfd.FileName = "Output.pdf";

			if (sfd.ShowDialog() == DialogResult.OK)
			{
				try
				{
					Paragraph title = new Paragraph(t, new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 18, iTextSharp.text.Font.BOLD));
					title.Alignment = Element.ALIGN_CENTER;
					title.SpacingAfter = 20f;

					PdfPTable pdfTable = new PdfPTable(dataGridView1.Columns.Count);
					pdfTable.DefaultCell.Padding = 3;
					pdfTable.WidthPercentage = 100;
					pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;

					foreach (DataGridViewColumn column in dataGridView1.Columns)
					{
						PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 10f, iTextSharp.text.Font.BOLD)));
						cell.HorizontalAlignment = Element.ALIGN_CENTER;
						cell.Padding = 5f;
						pdfTable.AddCell(cell);
					}

					foreach (DataGridViewRow row in dataGridView1.Rows)
					{
						foreach (DataGridViewCell cell in row.Cells)
						{
							pdfTable.AddCell(cell.Value.ToString());
						}
					}

					using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
					{
						Document pdfDoc = new Document(PageSize.A4, 25f, 25f, 20f, 10f);
						PdfWriter.GetInstance(pdfDoc, stream);
						pdfDoc.Open();
						pdfDoc.Add(title);
						pdfDoc.Add(pdfTable);
						string dateTimeText = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
						Paragraph dateParagraph = new Paragraph(dateTimeText);
						dateParagraph.Alignment = Element.ALIGN_RIGHT;
						dateParagraph.SetLeading(0f, 1.5f);
						pdfDoc.Add(dateParagraph);
						pdfDoc.Close();
						stream.Close();
					}

					MessageBox.Show("Data Exported Successfully!", "Info");
				}
				catch
				{
					MessageBox.Show("Couldn't Export Data");
				}
			}
		}

		public static void GenerateFromQuestions(string t, List<Exam> questions)
		{
			SaveFileDialog sfd = new SaveFileDialog();
			sfd.Filter = "PDF (*.pdf)|*.pdf";
			sfd.FileName = "Output.pdf";

			if (sfd.ShowDialog() == DialogResult.OK)
			{
				try
				{
					Paragraph title = new Paragraph(t, new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 18, iTextSharp.text.Font.BOLD));
					title.Alignment = Element.ALIGN_CENTER;
					title.SpacingAfter = 20f;

					using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
					{
						Document pdfDoc = new Document(PageSize.A4, 25f, 25f, 20f, 10f);
						PdfWriter.GetInstance(pdfDoc, stream);
						pdfDoc.Open();
						pdfDoc.Add(title);

						for (int i = 0; i < questions.Count; i++)
						{
							Paragraph body = new Paragraph($"Q{i + 1}) {questions[i].Question}", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 14));
							body.SpacingAfter = 20f;
							pdfDoc.Add(body);

							Paragraph option1 = new Paragraph($"\u2022   {questions[i].Option1}", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 14));
							option1.IndentationLeft = 30f;
							option1.SpacingAfter = 20f;
							pdfDoc.Add(option1);

							Paragraph option2 = new Paragraph($"\u2022   {questions[i].Option2}", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 14));
							option2.IndentationLeft = 30f;
							option2.SpacingAfter = 20f;
							pdfDoc.Add(option2);

							if (questions[i].Type != "True or False")
							{
								Paragraph option3 = new Paragraph($"\u2022   {questions[i].Option3}", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 14));
								option3.IndentationLeft = 30f;
								option3.SpacingAfter = 20f;
								pdfDoc.Add(option3);

								Paragraph option4 = new Paragraph($"\u2022   {questions[i].Option4}", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 14));
								option4.IndentationLeft = 30f;
								option4.SpacingAfter = 20f;
								pdfDoc.Add(option4);
							}
						}

						string dateTimeText = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
						Paragraph dateParagraph = new Paragraph(dateTimeText);
						dateParagraph.Alignment = Element.ALIGN_RIGHT;
						dateParagraph.SetLeading(0f, 1.5f);
						pdfDoc.Add(dateParagraph);
						pdfDoc.Close();
						stream.Close();
					}

					MessageBox.Show("Data Exported Successfully!", "Info");
				}
				catch
				{
					MessageBox.Show("Couldn't Export Data");
				}
			}
		}
		public static void GenerateFromQuestionsAndAnswers(string t, List<Exam> questions, List<StudentAnswer> studentAnswers)
		{
			SaveFileDialog sfd = new SaveFileDialog();
			sfd.Filter = "PDF (*.pdf)|*.pdf";
			sfd.FileName = "Output.pdf";

			if (sfd.ShowDialog() == DialogResult.OK)
			{
				try
				{
					Paragraph title = new Paragraph(t, new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 18, iTextSharp.text.Font.BOLD));
					title.Alignment = Element.ALIGN_CENTER;
					title.SpacingAfter = 20f;

					using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
					{
						Document pdfDoc = new Document(PageSize.A4, 25f, 25f, 20f, 10f);
						PdfWriter.GetInstance(pdfDoc, stream);
						pdfDoc.Open();
						pdfDoc.Add(title);

						for (int i = 0; i < questions.Count; i++)
						{
							Paragraph body = new Paragraph($"Q{i + 1}) {questions[i].Question}", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 14));
							body.SpacingAfter = 20f;
							pdfDoc.Add(body);

							List<int> answerIds = new();
							answerIds.Add(int.Parse(questions[i].Option1.Split("...")[0]));
							answerIds.Add(int.Parse(questions[i].Option2.Split("...")[0]));
							if (questions[i].Type != "True or False")
							{
								answerIds.Add(int.Parse(questions[i].Option3.Split("...")[0]));
								answerIds.Add(int.Parse(questions[i].Option4.Split("...")[0]));
							}

							var studentAnswerNumber = answerIds.IndexOf(studentAnswers[i].StudentAnswerId);

							Paragraph[] options;
                            if (questions[i].Type != "True or False")
                                options = new Paragraph[]
								{
									new Paragraph($"\u2022   {questions[i].Option1.Split("...")[1]}", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 14)),
									new Paragraph($"\u2022   {questions[i].Option2.Split("...")[1]}", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 14)),
									new Paragraph($"\u2022   {questions[i].Option3.Split("...")[1]}", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 14)),
									new Paragraph($"\u2022   {questions[i].Option4.Split("...")[1]}", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 14))
								};
							else
                                options = new Paragraph[]
                                {
                                    new Paragraph($"\u2022   {questions[i].Option1.Split("...")[1]}", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 14)),
                                    new Paragraph($"\u2022   {questions[i].Option2.Split("...")[1]}", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 14))
                                };

							var studentAnswerIndex = answerIds.IndexOf(studentAnswers[i].StudentAnswerId);
							switch (studentAnswerIndex)
							{
								case 0:
									options[studentAnswerIndex] = new Paragraph($"\u2022   {questions[i].Option1.Split("...")[1]}", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 14, iTextSharp.text.Font.ITALIC, BaseColor.BLUE));
                                    break;
								case 1:
                                    options[studentAnswerIndex] = new Paragraph($"\u2022   {questions[i].Option2.Split("...")[1]}", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 14, iTextSharp.text.Font.ITALIC, BaseColor.BLUE));
                                    break;
								case 2:
                                    options[studentAnswerIndex] = new Paragraph($"\u2022   {questions[i].Option3.Split("...")[1]}", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 14, iTextSharp.text.Font.ITALIC, BaseColor.BLUE));
                                    break;
								case 3:
                                    options[studentAnswerIndex] = new Paragraph($"\u2022   {questions[i].Option4.Split("...")[1]}", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 14, iTextSharp.text.Font.ITALIC, BaseColor.BLUE));
                                    break;
							}

                            foreach (var option in options)
                            {
                                option.IndentationLeft = 30f;
                                option.SpacingAfter = 20f;
                            }

                            pdfDoc.Add(options[0]);
                            pdfDoc.Add(options[1]);

                            if (questions[i].Type != "True or False")
							{
								pdfDoc.Add(options[2]);
								pdfDoc.Add(options[3]);
							}
						}

						string dateTimeText = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
						Paragraph dateParagraph = new Paragraph(dateTimeText);
						dateParagraph.Alignment = Element.ALIGN_RIGHT;
						dateParagraph.SetLeading(0f, 1.5f);
						pdfDoc.Add(dateParagraph);
						pdfDoc.Close();
						stream.Close();
					}

					MessageBox.Show("Data Exported Successfully!", "Info");
				}
				catch
				{
					MessageBox.Show("Couldn't Export Data");
				}
			}
		}
	}
}
