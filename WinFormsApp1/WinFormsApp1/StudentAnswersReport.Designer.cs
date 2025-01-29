namespace WinFormsApp1
{
    partial class StudentAnswersReport
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
            Back = new Button();
            PanelQuestion = new Panel();
            CourseNameLabel = new Label();
            CourseBox = new ComboBox();
            GeneratePdfButton = new Button();
            ExamLabel = new Label();
            ExamBox = new ComboBox();
            StudentLabel = new Label();
            StudentBox = new ComboBox();
            SuspendLayout();
            // 
            // Back
            // 
            Back.BackColor = Color.FromArgb(154, 51, 51);
            Back.Cursor = Cursors.Hand;
            Back.FlatStyle = FlatStyle.Flat;
            Back.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Back.ForeColor = Color.White;
            Back.Location = new Point(17, 16);
            Back.Margin = new Padding(3, 4, 3, 4);
            Back.Name = "Back";
            Back.Size = new Size(80, 33);
            Back.TabIndex = 51;
            Back.Text = "BACK";
            Back.UseVisualStyleBackColor = false;
            Back.Click += Back_Click;
            // 
            // PanelQuestion
            // 
            PanelQuestion.Location = new Point(25, 146);
            PanelQuestion.Name = "PanelQuestion";
            PanelQuestion.Size = new Size(1236, 512);
            PanelQuestion.TabIndex = 55;
            // 
            // CourseNameLabel
            // 
            CourseNameLabel.AutoSize = true;
            CourseNameLabel.Font = new Font("Segoe UI", 12F);
            CourseNameLabel.Location = new Point(37, 78);
            CourseNameLabel.Name = "CourseNameLabel";
            CourseNameLabel.Size = new Size(76, 28);
            CourseNameLabel.TabIndex = 54;
            CourseNameLabel.Text = "Course:";
            // 
            // CourseBox
            // 
            CourseBox.AccessibleName = "";
            CourseBox.DropDownStyle = ComboBoxStyle.DropDownList;
            CourseBox.Font = new Font("Segoe UI", 12F);
            CourseBox.FormattingEnabled = true;
            CourseBox.Location = new Point(125, 76);
            CourseBox.Margin = new Padding(3, 4, 3, 4);
            CourseBox.Name = "CourseBox";
            CourseBox.Size = new Size(179, 36);
            CourseBox.TabIndex = 53;
            CourseBox.SelectedIndexChanged += CourseBox_SelectedIndexChanged;
            // 
            // GeneratePdfButton
            // 
            GeneratePdfButton.BackColor = Color.FromArgb(154, 51, 51);
            GeneratePdfButton.Cursor = Cursors.Hand;
            GeneratePdfButton.FlatStyle = FlatStyle.Flat;
            GeneratePdfButton.ForeColor = Color.White;
            GeneratePdfButton.Location = new Point(1040, 66);
            GeneratePdfButton.Margin = new Padding(3, 4, 3, 4);
            GeneratePdfButton.Name = "GeneratePdfButton";
            GeneratePdfButton.Size = new Size(208, 48);
            GeneratePdfButton.TabIndex = 52;
            GeneratePdfButton.Text = "Generate PDF";
            GeneratePdfButton.UseVisualStyleBackColor = false;
            GeneratePdfButton.Click += GeneratePdfButton_Click;
            // 
            // ExamLabel
            // 
            ExamLabel.AutoSize = true;
            ExamLabel.Font = new Font("Segoe UI", 12F);
            ExamLabel.Location = new Point(368, 78);
            ExamLabel.Name = "ExamLabel";
            ExamLabel.Size = new Size(62, 28);
            ExamLabel.TabIndex = 57;
            ExamLabel.Text = "Exam:";
            // 
            // ExamBox
            // 
            ExamBox.AccessibleName = "";
            ExamBox.DropDownStyle = ComboBoxStyle.DropDownList;
            ExamBox.Font = new Font("Segoe UI", 12F);
            ExamBox.FormattingEnabled = true;
            ExamBox.Location = new Point(449, 74);
            ExamBox.Margin = new Padding(3, 4, 3, 4);
            ExamBox.Name = "ExamBox";
            ExamBox.Size = new Size(179, 36);
            ExamBox.TabIndex = 56;
            ExamBox.SelectedIndexChanged += ExamBox_SelectedIndexChanged;
            // 
            // StudentLabel
            // 
            StudentLabel.AutoSize = true;
            StudentLabel.Font = new Font("Segoe UI", 12F);
            StudentLabel.Location = new Point(696, 78);
            StudentLabel.Name = "StudentLabel";
            StudentLabel.Size = new Size(84, 28);
            StudentLabel.TabIndex = 59;
            StudentLabel.Text = "Student:";
            // 
            // StudentBox
            // 
            StudentBox.AccessibleName = "";
            StudentBox.DropDownStyle = ComboBoxStyle.DropDownList;
            StudentBox.Font = new Font("Segoe UI", 12F);
            StudentBox.FormattingEnabled = true;
            StudentBox.Location = new Point(785, 74);
            StudentBox.Margin = new Padding(3, 4, 3, 4);
            StudentBox.Name = "StudentBox";
            StudentBox.Size = new Size(179, 36);
            StudentBox.TabIndex = 58;
            StudentBox.SelectedIndexChanged += StudentBox_SelectedIndexChanged;
            // 
            // StudentAnswersReport
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1279, 704);
            Controls.Add(StudentLabel);
            Controls.Add(StudentBox);
            Controls.Add(ExamLabel);
            Controls.Add(ExamBox);
            Controls.Add(Back);
            Controls.Add(PanelQuestion);
            Controls.Add(CourseNameLabel);
            Controls.Add(CourseBox);
            Controls.Add(GeneratePdfButton);
            Name = "StudentAnswersReport";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Student Answers";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Back;
        private Panel PanelQuestion;
        private Label CourseNameLabel;
        private ComboBox CourseBox;
        private Button GeneratePdfButton;
        private Label ExamLabel;
        private ComboBox ExamBox;
        private Label StudentLabel;
        private ComboBox StudentBox;
    }
}