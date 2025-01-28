namespace WinFormsApp1
{
    partial class ExamSelection
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
            label1 = new Label();
            ShowExam = new Button();
            CourseList = new ComboBox();
            ExamList = new ComboBox();
            label2 = new Label();
            Back = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(258, 72);
            label1.Name = "label1";
            label1.Size = new Size(111, 41);
            label1.TabIndex = 0;
            label1.Text = "Course";
            // 
            // ShowExam
            // 
            ShowExam.BackColor = Color.FromArgb(154, 51, 51);
            ShowExam.Cursor = Cursors.Hand;
            ShowExam.Dock = DockStyle.Bottom;
            ShowExam.FlatStyle = FlatStyle.Flat;
            ShowExam.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ShowExam.ForeColor = Color.White;
            ShowExam.Location = new Point(0, 389);
            ShowExam.Margin = new Padding(3, 4, 3, 4);
            ShowExam.Name = "ShowExam";
            ShowExam.Size = new Size(800, 61);
            ShowExam.TabIndex = 38;
            ShowExam.Text = "Show Exam";
            ShowExam.UseVisualStyleBackColor = false;
            ShowExam.Click += ShowExam_Click;
            // 
            // CourseList
            // 
            CourseList.DropDownStyle = ComboBoxStyle.DropDownList;
            CourseList.FormattingEnabled = true;
            CourseList.Location = new Point(422, 85);
            CourseList.Name = "CourseList";
            CourseList.Size = new Size(151, 28);
            CourseList.TabIndex = 39;
            CourseList.SelectedIndexChanged += CourseList_SelectedIndexChanged;
            // 
            // ExamList
            // 
            ExamList.DropDownStyle = ComboBoxStyle.DropDownList;
            ExamList.FormattingEnabled = true;
            ExamList.Location = new Point(422, 204);
            ExamList.Name = "ExamList";
            ExamList.Size = new Size(151, 28);
            ExamList.TabIndex = 41;
            ExamList.SelectedIndexChanged += ExamList_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(258, 191);
            label2.Name = "label2";
            label2.Size = new Size(88, 41);
            label2.TabIndex = 40;
            label2.Text = "Exam";
            // 
            // Back
            // 
            Back.BackColor = Color.FromArgb(154, 51, 51);
            Back.Cursor = Cursors.Hand;
            Back.FlatStyle = FlatStyle.Flat;
            Back.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Back.ForeColor = Color.White;
            Back.Location = new Point(12, 13);
            Back.Margin = new Padding(3, 4, 3, 4);
            Back.Name = "Back";
            Back.Size = new Size(80, 33);
            Back.TabIndex = 42;
            Back.Text = "BACK";
            Back.UseVisualStyleBackColor = false;
            Back.Click += Back_Click;
            // 
            // ExamSelection
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Back);
            Controls.Add(ExamList);
            Controls.Add(label2);
            Controls.Add(CourseList);
            Controls.Add(ShowExam);
            Controls.Add(label1);
            MaximizeBox = false;
            Name = "ExamSelection";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Exam Selection";
            Load += ExamSelection_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button ShowExam;
        private ComboBox CourseList;
        private ComboBox ExamList;
        private Label label2;
        private Button Back;
    }
}