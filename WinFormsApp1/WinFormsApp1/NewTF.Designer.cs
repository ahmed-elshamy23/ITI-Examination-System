namespace WinFormsApp1
{
    partial class NewTF
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            MarkInput = new NumericUpDown();
            MarkLabel = new Label();
            QuestionBodyInput = new TextBox();
            QuestioonBodyLabel = new Label();
            InsertButton = new Button();
            CourseNameLabel = new Label();
            CourseBox = new ComboBox();
            CorrectAnswerLabel = new Label();
            CorrectAnswerBox = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)MarkInput).BeginInit();
            SuspendLayout();
            // 
            // MarkInput
            // 
            MarkInput.Location = new Point(504, 56);
            MarkInput.Name = "MarkInput";
            MarkInput.Size = new Size(130, 27);
            MarkInput.TabIndex = 73;
            // 
            // MarkLabel
            // 
            MarkLabel.AutoSize = true;
            MarkLabel.Font = new Font("Segoe UI", 12F);
            MarkLabel.Location = new Point(432, 52);
            MarkLabel.Name = "MarkLabel";
            MarkLabel.Size = new Size(61, 28);
            MarkLabel.TabIndex = 72;
            MarkLabel.Text = "Mark:";
            // 
            // QuestionBodyInput
            // 
            QuestionBodyInput.Location = new Point(40, 152);
            QuestionBodyInput.Multiline = true;
            QuestionBodyInput.Name = "QuestionBodyInput";
            QuestionBodyInput.Size = new Size(896, 88);
            QuestionBodyInput.TabIndex = 71;
            // 
            // QuestioonBodyLabel
            // 
            QuestioonBodyLabel.AutoSize = true;
            QuestioonBodyLabel.Font = new Font("Segoe UI", 12F);
            QuestioonBodyLabel.Location = new Point(32, 112);
            QuestioonBodyLabel.Name = "QuestioonBodyLabel";
            QuestioonBodyLabel.Size = new Size(145, 28);
            QuestioonBodyLabel.TabIndex = 70;
            QuestioonBodyLabel.Text = "Question Body:";
            // 
            // InsertButton
            // 
            InsertButton.BackColor = Color.FromArgb(154, 51, 51);
            InsertButton.Cursor = Cursors.Hand;
            InsertButton.FlatStyle = FlatStyle.Flat;
            InsertButton.Font = new Font("Segoe UI", 12F);
            InsertButton.ForeColor = Color.White;
            InsertButton.Location = new Point(784, 45);
            InsertButton.Margin = new Padding(3, 4, 3, 4);
            InsertButton.Name = "InsertButton";
            InsertButton.Size = new Size(153, 48);
            InsertButton.TabIndex = 69;
            InsertButton.Text = "Insert";
            InsertButton.UseVisualStyleBackColor = false;
            InsertButton.Click += InsertButton_Click;
            // 
            // CourseNameLabel
            // 
            CourseNameLabel.AutoSize = true;
            CourseNameLabel.Font = new Font("Segoe UI", 12F);
            CourseNameLabel.Location = new Point(32, 52);
            CourseNameLabel.Name = "CourseNameLabel";
            CourseNameLabel.Size = new Size(76, 28);
            CourseNameLabel.TabIndex = 68;
            CourseNameLabel.Text = "Course:";
            // 
            // CourseBox
            // 
            CourseBox.AccessibleName = "";
            CourseBox.DropDownStyle = ComboBoxStyle.DropDownList;
            CourseBox.Font = new Font("Segoe UI", 12F);
            CourseBox.FormattingEnabled = true;
            CourseBox.Location = new Point(120, 48);
            CourseBox.Margin = new Padding(3, 4, 3, 4);
            CourseBox.Name = "CourseBox";
            CourseBox.Size = new Size(179, 36);
            CourseBox.TabIndex = 67;
            // 
            // CorrectAnswerLabel
            // 
            CorrectAnswerLabel.AutoSize = true;
            CorrectAnswerLabel.Font = new Font("Segoe UI", 12F);
            CorrectAnswerLabel.Location = new Point(40, 276);
            CorrectAnswerLabel.Name = "CorrectAnswerLabel";
            CorrectAnswerLabel.Size = new Size(148, 28);
            CorrectAnswerLabel.TabIndex = 75;
            CorrectAnswerLabel.Text = "Correct Answer:";
            // 
            // CorrectAnswerBox
            // 
            CorrectAnswerBox.AccessibleName = "";
            CorrectAnswerBox.DropDownStyle = ComboBoxStyle.DropDownList;
            CorrectAnswerBox.Font = new Font("Segoe UI", 12F);
            CorrectAnswerBox.FormattingEnabled = true;
            CorrectAnswerBox.Location = new Point(200, 272);
            CorrectAnswerBox.Margin = new Padding(3, 4, 3, 4);
            CorrectAnswerBox.Name = "CorrectAnswerBox";
            CorrectAnswerBox.Size = new Size(179, 36);
            CorrectAnswerBox.TabIndex = 74;
            // 
            // NewTF
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(969, 370);
            Controls.Add(CorrectAnswerLabel);
            Controls.Add(CorrectAnswerBox);
            Controls.Add(MarkInput);
            Controls.Add(MarkLabel);
            Controls.Add(QuestionBodyInput);
            Controls.Add(QuestioonBodyLabel);
            Controls.Add(InsertButton);
            Controls.Add(CourseNameLabel);
            Controls.Add(CourseBox);
            MaximizeBox = false;
            Name = "NewTF";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "New True or False";
            ((System.ComponentModel.ISupportInitialize)MarkInput).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown MarkInput;
        private Label MarkLabel;
        private TextBox QuestionBodyInput;
        private Label QuestioonBodyLabel;
        private Button InsertButton;
        private Label CourseNameLabel;
        private ComboBox CourseBox;
        private Label CorrectAnswerLabel;
        private ComboBox CorrectAnswerBox;
    }
}