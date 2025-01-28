namespace WinFormsApp1
{
    partial class NewCourse
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
            btn_insert = new Button();
            CourseNameLabel = new Label();
            CourseNameInput = new TextBox();
            CourseDurationInput = new TextBox();
            CourseDurationLabel = new Label();
            SuspendLayout();
            // 
            // btn_insert
            // 
            btn_insert.BackColor = Color.FromArgb(154, 51, 51);
            btn_insert.Cursor = Cursors.Hand;
            btn_insert.FlatStyle = FlatStyle.Flat;
            btn_insert.Font = new Font("Segoe UI", 12F);
            btn_insert.ForeColor = Color.White;
            btn_insert.Location = new Point(104, 200);
            btn_insert.Margin = new Padding(3, 4, 3, 4);
            btn_insert.Name = "btn_insert";
            btn_insert.Size = new Size(281, 45);
            btn_insert.TabIndex = 28;
            btn_insert.Text = "Insert";
            btn_insert.UseVisualStyleBackColor = false;
            btn_insert.Click += btn_insert_Click;
            // 
            // CourseNameLabel
            // 
            CourseNameLabel.AutoSize = true;
            CourseNameLabel.Font = new Font("Segoe UI", 12F);
            CourseNameLabel.Location = new Point(104, 74);
            CourseNameLabel.Name = "CourseNameLabel";
            CourseNameLabel.Size = new Size(68, 28);
            CourseNameLabel.TabIndex = 26;
            CourseNameLabel.Text = "Name:";
            // 
            // CourseNameInput
            // 
            CourseNameInput.Font = new Font("Segoe UI", 12F);
            CourseNameInput.Location = new Point(192, 72);
            CourseNameInput.Margin = new Padding(3, 4, 3, 4);
            CourseNameInput.Name = "CourseNameInput";
            CourseNameInput.Size = new Size(187, 34);
            CourseNameInput.TabIndex = 29;
            // 
            // CourseDurationInput
            // 
            CourseDurationInput.Font = new Font("Segoe UI", 12F);
            CourseDurationInput.Location = new Point(192, 136);
            CourseDurationInput.Margin = new Padding(3, 4, 3, 4);
            CourseDurationInput.Name = "CourseDurationInput";
            CourseDurationInput.Size = new Size(187, 34);
            CourseDurationInput.TabIndex = 31;
            // 
            // CourseDurationLabel
            // 
            CourseDurationLabel.AutoSize = true;
            CourseDurationLabel.Font = new Font("Segoe UI", 12F);
            CourseDurationLabel.Location = new Point(88, 138);
            CourseDurationLabel.Name = "CourseDurationLabel";
            CourseDurationLabel.Size = new Size(93, 28);
            CourseDurationLabel.TabIndex = 30;
            CourseDurationLabel.Text = "Duration:";
            // 
            // NewCourse
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(476, 306);
            Controls.Add(CourseDurationInput);
            Controls.Add(CourseDurationLabel);
            Controls.Add(CourseNameInput);
            Controls.Add(btn_insert);
            Controls.Add(CourseNameLabel);
            MaximizeBox = false;
            Name = "NewCourse";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "New Course";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_insert;
        private Label CourseNameLabel;
        private TextBox CourseNameInput;
        private TextBox CourseDurationInput;
        private Label CourseDurationLabel;
    }
}