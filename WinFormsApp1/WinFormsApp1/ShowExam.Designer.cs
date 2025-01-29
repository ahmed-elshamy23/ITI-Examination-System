namespace WinFormsApp1
{
    partial class ShowExam
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
            Exam = new Label();
            Course = new Label();
            Back = new Button();
            sqlCommandBuilder1 = new Microsoft.Data.SqlClient.SqlCommandBuilder();
            label1 = new Label();
            PanelQuestion = new Panel();
            GeneratePdfButton = new Button();
            SuspendLayout();
            // 
            // Exam
            // 
            Exam.AutoSize = true;
            Exam.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Exam.ForeColor = Color.Red;
            Exam.Location = new Point(416, 16);
            Exam.Name = "Exam";
            Exam.Size = new Size(125, 31);
            Exam.TabIndex = 0;
            Exam.Text = "Exam #123";
            // 
            // Course
            // 
            Course.AutoSize = true;
            Course.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Course.ForeColor = Color.Red;
            Course.Location = new Point(704, 16);
            Course.Name = "Course";
            Course.Size = new Size(84, 31);
            Course.TabIndex = 1;
            Course.Text = "Course";
            // 
            // Back
            // 
            Back.BackColor = Color.FromArgb(154, 51, 51);
            Back.Cursor = Cursors.Hand;
            Back.FlatStyle = FlatStyle.Flat;
            Back.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Back.ForeColor = Color.White;
            Back.Location = new Point(7, 7);
            Back.Margin = new Padding(3, 4, 3, 4);
            Back.Name = "Back";
            Back.Size = new Size(80, 33);
            Back.TabIndex = 39;
            Back.Text = "BACK";
            Back.UseVisualStyleBackColor = false;
            Back.Click += Back_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 53);
            label1.Name = "label1";
            label1.Size = new Size(93, 23);
            label1.TabIndex = 40;
            label1.Text = "Questions:";
            // 
            // PanelQuestion
            // 
            PanelQuestion.Location = new Point(18, 85);
            PanelQuestion.Name = "PanelQuestion";
            PanelQuestion.Size = new Size(1238, 555);
            PanelQuestion.TabIndex = 41;
            // 
            // GeneratePdfButton
            // 
            GeneratePdfButton.BackColor = Color.FromArgb(154, 51, 51);
            GeneratePdfButton.Cursor = Cursors.Hand;
            GeneratePdfButton.FlatStyle = FlatStyle.Flat;
            GeneratePdfButton.ForeColor = Color.White;
            GeneratePdfButton.Location = new Point(1080, 24);
            GeneratePdfButton.Margin = new Padding(3, 4, 3, 4);
            GeneratePdfButton.Name = "GeneratePdfButton";
            GeneratePdfButton.Size = new Size(170, 43);
            GeneratePdfButton.TabIndex = 49;
            GeneratePdfButton.Text = "Generate PDF";
            GeneratePdfButton.UseVisualStyleBackColor = false;
            GeneratePdfButton.Click += GeneratePdfButton_Click;
            // 
            // ShowExam
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1279, 704);
            Controls.Add(GeneratePdfButton);
            Controls.Add(PanelQuestion);
            Controls.Add(label1);
            Controls.Add(Back);
            Controls.Add(Course);
            Controls.Add(Exam);
            MaximizeBox = false;
            Name = "ShowExam";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Show Exam";
            Load += ShowExam_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Exam;
        private Label Course;
        private Button Back;
        private Microsoft.Data.SqlClient.SqlCommandBuilder sqlCommandBuilder1;
        private Label label1;
        private Panel PanelQuestion;
        private Button GeneratePdfButton;
    }
}