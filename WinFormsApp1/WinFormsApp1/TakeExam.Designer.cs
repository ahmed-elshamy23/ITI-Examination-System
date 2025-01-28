namespace WinFormsApp1
{
    partial class TakeExam
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
            ExamList = new ComboBox();
            label2 = new Label();
            CourseList = new ComboBox();
            StartExam = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // Back
            // 
            Back.BackColor = Color.FromArgb(154, 51, 51);
            Back.Cursor = Cursors.Hand;
            Back.FlatStyle = FlatStyle.Flat;
            Back.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Back.ForeColor = Color.White;
            Back.Location = new Point(12, 7);
            Back.Margin = new Padding(3, 4, 3, 4);
            Back.Name = "Back";
            Back.Size = new Size(80, 33);
            Back.TabIndex = 48;
            Back.Text = "BACK";
            Back.UseVisualStyleBackColor = false;
            Back.Click += Back_Click;
            // 
            // ExamList
            // 
            ExamList.DropDownStyle = ComboBoxStyle.DropDownList;
            ExamList.FormattingEnabled = true;
            ExamList.Location = new Point(422, 198);
            ExamList.Name = "ExamList";
            ExamList.Size = new Size(151, 28);
            ExamList.TabIndex = 47;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(258, 185);
            label2.Name = "label2";
            label2.Size = new Size(88, 41);
            label2.TabIndex = 46;
            label2.Text = "Exam";
            // 
            // CourseList
            // 
            CourseList.DropDownStyle = ComboBoxStyle.DropDownList;
            CourseList.FormattingEnabled = true;
            CourseList.Location = new Point(422, 79);
            CourseList.Name = "CourseList";
            CourseList.Size = new Size(151, 28);
            CourseList.TabIndex = 45;
            CourseList.SelectedIndexChanged += CourseList_SelectedIndexChanged;
            // 
            // StartExam
            // 
            StartExam.BackColor = Color.FromArgb(154, 51, 51);
            StartExam.Cursor = Cursors.Hand;
            StartExam.Dock = DockStyle.Bottom;
            StartExam.FlatStyle = FlatStyle.Flat;
            StartExam.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            StartExam.ForeColor = Color.White;
            StartExam.Location = new Point(0, 389);
            StartExam.Margin = new Padding(3, 4, 3, 4);
            StartExam.Name = "StartExam";
            StartExam.Size = new Size(800, 61);
            StartExam.TabIndex = 44;
            StartExam.Text = "Start Exam";
            StartExam.UseVisualStyleBackColor = false;
            StartExam.Click += StartExam_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(258, 66);
            label1.Name = "label1";
            label1.Size = new Size(111, 41);
            label1.TabIndex = 43;
            label1.Text = "Course";
            // 
            // TakeExam
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Back);
            Controls.Add(ExamList);
            Controls.Add(label2);
            Controls.Add(CourseList);
            Controls.Add(StartExam);
            Controls.Add(label1);
            MaximizeBox = false;
            Name = "TakeExam";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TakeExam";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Back;
        private ComboBox ExamList;
        private Label label2;
        private ComboBox CourseList;
        private Button StartExam;
        private Label label1;
    }
}