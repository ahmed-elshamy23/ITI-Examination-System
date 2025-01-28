namespace WinFormsApp1
{
    partial class Reports
    {/// <summary>
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
            ShowExamQuestionsButton = new Button();
            InstructorCoursesButton = new Button();
            StudentGradesButton = new Button();
            ChooseReportLabel = new Label();
            ShowStudentAnswersButton = new Button();
            ShowDepartmentStudentsButton = new Button();
            CourseTopicsButton = new Button();
            BackButton = new Button();
            SuspendLayout();
            // 
            // ShowExamQuestionsButton
            // 
            ShowExamQuestionsButton.BackColor = Color.FromArgb(154, 51, 51);
            ShowExamQuestionsButton.Cursor = Cursors.Hand;
            ShowExamQuestionsButton.FlatStyle = FlatStyle.Flat;
            ShowExamQuestionsButton.ForeColor = Color.White;
            ShowExamQuestionsButton.Location = new Point(120, 296);
            ShowExamQuestionsButton.Margin = new Padding(3, 4, 3, 4);
            ShowExamQuestionsButton.Name = "ShowExamQuestionsButton";
            ShowExamQuestionsButton.Size = new Size(267, 61);
            ShowExamQuestionsButton.TabIndex = 1;
            ShowExamQuestionsButton.Text = "Show Exam Questions";
            ShowExamQuestionsButton.UseVisualStyleBackColor = false;
            ShowExamQuestionsButton.Click += ShowExamQuestionsButton_Click;
            // 
            // InstructorCoursesButton
            // 
            InstructorCoursesButton.BackColor = Color.FromArgb(154, 51, 51);
            InstructorCoursesButton.Cursor = Cursors.Hand;
            InstructorCoursesButton.FlatStyle = FlatStyle.Flat;
            InstructorCoursesButton.ForeColor = Color.White;
            InstructorCoursesButton.Location = new Point(488, 296);
            InstructorCoursesButton.Margin = new Padding(3, 4, 3, 4);
            InstructorCoursesButton.Name = "InstructorCoursesButton";
            InstructorCoursesButton.Size = new Size(267, 61);
            InstructorCoursesButton.TabIndex = 1;
            InstructorCoursesButton.Text = "Show Instructor Courses";
            InstructorCoursesButton.UseVisualStyleBackColor = false;
            // 
            // StudentGradesButton
            // 
            StudentGradesButton.BackColor = Color.FromArgb(154, 51, 51);
            StudentGradesButton.Cursor = Cursors.Hand;
            StudentGradesButton.FlatStyle = FlatStyle.Flat;
            StudentGradesButton.ForeColor = Color.White;
            StudentGradesButton.Location = new Point(488, 424);
            StudentGradesButton.Margin = new Padding(3, 4, 3, 4);
            StudentGradesButton.Name = "StudentGradesButton";
            StudentGradesButton.Size = new Size(267, 61);
            StudentGradesButton.TabIndex = 1;
            StudentGradesButton.Text = "Show Student Grades";
            StudentGradesButton.UseVisualStyleBackColor = false;
            // 
            // ChooseReportLabel
            // 
            ChooseReportLabel.AutoSize = true;
            ChooseReportLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ChooseReportLabel.ForeColor = Color.FromArgb(154, 51, 51);
            ChooseReportLabel.Location = new Point(24, 48);
            ChooseReportLabel.Name = "ChooseReportLabel";
            ChooseReportLabel.Size = new Size(233, 37);
            ChooseReportLabel.TabIndex = 12;
            ChooseReportLabel.Text = "Choose A Report";
            ChooseReportLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ShowStudentAnswersButton
            // 
            ShowStudentAnswersButton.BackColor = Color.FromArgb(154, 51, 51);
            ShowStudentAnswersButton.Cursor = Cursors.Hand;
            ShowStudentAnswersButton.FlatStyle = FlatStyle.Flat;
            ShowStudentAnswersButton.ForeColor = Color.White;
            ShowStudentAnswersButton.Location = new Point(120, 424);
            ShowStudentAnswersButton.Margin = new Padding(3, 4, 3, 4);
            ShowStudentAnswersButton.Name = "ShowStudentAnswersButton";
            ShowStudentAnswersButton.Size = new Size(267, 61);
            ShowStudentAnswersButton.TabIndex = 1;
            ShowStudentAnswersButton.Text = "Show Student Answers";
            ShowStudentAnswersButton.UseVisualStyleBackColor = false;
            // 
            // ShowDepartmentStudentsButton
            // 
            ShowDepartmentStudentsButton.BackColor = Color.FromArgb(154, 51, 51);
            ShowDepartmentStudentsButton.Cursor = Cursors.Hand;
            ShowDepartmentStudentsButton.FlatStyle = FlatStyle.Flat;
            ShowDepartmentStudentsButton.ForeColor = Color.White;
            ShowDepartmentStudentsButton.Location = new Point(120, 168);
            ShowDepartmentStudentsButton.Margin = new Padding(3, 4, 3, 4);
            ShowDepartmentStudentsButton.Name = "ShowDepartmentStudentsButton";
            ShowDepartmentStudentsButton.Size = new Size(267, 61);
            ShowDepartmentStudentsButton.TabIndex = 37;
            ShowDepartmentStudentsButton.Text = "Show Department Students";
            ShowDepartmentStudentsButton.UseVisualStyleBackColor = false;
            ShowDepartmentStudentsButton.Click += ShowDepartmentStudentsButton_Click;
            // 
            // CourseTopicsButton
            // 
            CourseTopicsButton.BackColor = Color.FromArgb(154, 51, 51);
            CourseTopicsButton.Cursor = Cursors.Hand;
            CourseTopicsButton.FlatStyle = FlatStyle.Flat;
            CourseTopicsButton.ForeColor = Color.White;
            CourseTopicsButton.Location = new Point(488, 168);
            CourseTopicsButton.Margin = new Padding(3, 4, 3, 4);
            CourseTopicsButton.Name = "CourseTopicsButton";
            CourseTopicsButton.Size = new Size(267, 61);
            CourseTopicsButton.TabIndex = 38;
            CourseTopicsButton.Text = "Show Course Topics";
            CourseTopicsButton.UseVisualStyleBackColor = false;
            // 
            // BackButton
            // 
            BackButton.BackColor = Color.FromArgb(154, 51, 51);
            BackButton.Cursor = Cursors.Hand;
            BackButton.FlatStyle = FlatStyle.Flat;
            BackButton.ForeColor = Color.White;
            BackButton.Location = new Point(648, 592);
            BackButton.Margin = new Padding(3, 4, 3, 4);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(144, 40);
            BackButton.TabIndex = 39;
            BackButton.Text = "Back";
            BackButton.UseVisualStyleBackColor = false;
            BackButton.Click += BackButton_Click;
            // 
            // Reports
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(839, 660);
            Controls.Add(BackButton);
            Controls.Add(CourseTopicsButton);
            Controls.Add(ShowDepartmentStudentsButton);
            Controls.Add(ChooseReportLabel);
            Controls.Add(StudentGradesButton);
            Controls.Add(ShowStudentAnswersButton);
            Controls.Add(InstructorCoursesButton);
            Controls.Add(ShowExamQuestionsButton);
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "Reports";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Reports";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ShowExamQuestionsButton;
        private Button InstructorCoursesButton;
        private Button StudentGradesButton;
        private Label ChooseReportLabel;
        private Button ShowStudentAnswersButton;
        private Button ShowDepartmentStudentsButton;
        private Button CourseTopicsButton;
        private Button BackButton;
    }
}