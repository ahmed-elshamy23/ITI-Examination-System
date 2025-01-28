namespace WinFormsApp1
{
    partial class PreviousExams
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
            ExamLabel = new Label();
            ExamBox = new ComboBox();
            SuspendLayout();
            // 
            // Back
            // 
            Back.BackColor = Color.FromArgb(154, 51, 51);
            Back.Cursor = Cursors.Hand;
            Back.FlatStyle = FlatStyle.Flat;
            Back.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Back.ForeColor = Color.White;
            Back.Location = new Point(15, 18);
            Back.Margin = new Padding(3, 4, 3, 4);
            Back.Name = "Back";
            Back.Size = new Size(80, 33);
            Back.TabIndex = 53;
            Back.Text = "BACK";
            Back.UseVisualStyleBackColor = false;
            Back.Click += Back_Click;
            // 
            // PanelQuestion
            // 
            PanelQuestion.Location = new Point(23, 118);
            PanelQuestion.Name = "PanelQuestion";
            PanelQuestion.Size = new Size(1236, 538);
            PanelQuestion.TabIndex = 57;
            // 
            // CourseNameLabel
            // 
            CourseNameLabel.AutoSize = true;
            CourseNameLabel.Font = new Font("Segoe UI", 12F);
            CourseNameLabel.Location = new Point(35, 66);
            CourseNameLabel.Name = "CourseNameLabel";
            CourseNameLabel.Size = new Size(76, 28);
            CourseNameLabel.TabIndex = 56;
            CourseNameLabel.Text = "Course:";
            // 
            // CourseBox
            // 
            CourseBox.AccessibleName = "";
            CourseBox.DropDownStyle = ComboBoxStyle.DropDownList;
            CourseBox.Font = new Font("Segoe UI", 12F);
            CourseBox.FormattingEnabled = true;
            CourseBox.Location = new Point(123, 62);
            CourseBox.Margin = new Padding(3, 4, 3, 4);
            CourseBox.Name = "CourseBox";
            CourseBox.Size = new Size(179, 36);
            CourseBox.TabIndex = 55;
            CourseBox.SelectedIndexChanged += CourseBox_SelectedIndexChanged;
            // 
            // ExamLabel
            // 
            ExamLabel.AutoSize = true;
            ExamLabel.Font = new Font("Segoe UI", 12F);
            ExamLabel.Location = new Point(984, 66);
            ExamLabel.Name = "ExamLabel";
            ExamLabel.Size = new Size(62, 28);
            ExamLabel.TabIndex = 59;
            ExamLabel.Text = "Exam:";
            // 
            // ExamBox
            // 
            ExamBox.AccessibleName = "";
            ExamBox.DropDownStyle = ComboBoxStyle.DropDownList;
            ExamBox.Font = new Font("Segoe UI", 12F);
            ExamBox.FormattingEnabled = true;
            ExamBox.Location = new Point(1055, 62);
            ExamBox.Margin = new Padding(3, 4, 3, 4);
            ExamBox.Name = "ExamBox";
            ExamBox.Size = new Size(179, 36);
            ExamBox.TabIndex = 58;
            ExamBox.SelectedIndexChanged += ExamBox_SelectedIndexChanged;
            // 
            // PreviousExams
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1279, 704);
            Controls.Add(ExamLabel);
            Controls.Add(ExamBox);
            Controls.Add(Back);
            Controls.Add(PanelQuestion);
            Controls.Add(CourseNameLabel);
            Controls.Add(CourseBox);
            MaximizeBox = false;
            Name = "PreviousExams";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "My Exams";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button Back;
        private Panel PanelQuestion;
        private Label CourseNameLabel;
        private ComboBox CourseBox;
        private Label ExamLabel;
        private ComboBox ExamBox;
    }
}