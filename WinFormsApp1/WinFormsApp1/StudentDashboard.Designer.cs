namespace WinFormsApp1
{
    partial class StudentDashboard
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
            ShowProfile = new Label();
            LogoutButton = new Button();
            MyExamsButton = new Button();
            MyGradesButton = new Button();
            WelcomeLabel = new Label();
            TakeExamButton = new Button();
            SuspendLayout();
            // 
            // ShowProfile
            // 
            ShowProfile.AutoSize = true;
            ShowProfile.Cursor = Cursors.Hand;
            ShowProfile.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            ShowProfile.ForeColor = Color.FromArgb(154, 51, 51);
            ShowProfile.Location = new Point(464, 45);
            ShowProfile.Name = "ShowProfile";
            ShowProfile.Size = new Size(111, 28);
            ShowProfile.TabIndex = 49;
            ShowProfile.Text = "My Profile";
            ShowProfile.TextAlign = ContentAlignment.MiddleCenter;
            ShowProfile.Click += ShowProfile_Click;
            // 
            // LogoutButton
            // 
            LogoutButton.BackColor = Color.FromArgb(154, 51, 51);
            LogoutButton.Cursor = Cursors.Hand;
            LogoutButton.FlatStyle = FlatStyle.Flat;
            LogoutButton.ForeColor = Color.White;
            LogoutButton.Location = new Point(432, 576);
            LogoutButton.Margin = new Padding(3, 4, 3, 4);
            LogoutButton.Name = "LogoutButton";
            LogoutButton.Size = new Size(144, 40);
            LogoutButton.TabIndex = 48;
            LogoutButton.Text = "Logout";
            LogoutButton.UseVisualStyleBackColor = false;
            LogoutButton.Click += LogoutButton_Click;
            // 
            // MyExamsButton
            // 
            MyExamsButton.BackColor = Color.FromArgb(154, 51, 51);
            MyExamsButton.Cursor = Cursors.Hand;
            MyExamsButton.FlatStyle = FlatStyle.Flat;
            MyExamsButton.ForeColor = Color.White;
            MyExamsButton.Location = new Point(184, 296);
            MyExamsButton.Margin = new Padding(3, 4, 3, 4);
            MyExamsButton.Name = "MyExamsButton";
            MyExamsButton.Size = new Size(267, 61);
            MyExamsButton.TabIndex = 47;
            MyExamsButton.Text = "My Exams";
            MyExamsButton.UseVisualStyleBackColor = false;
            MyExamsButton.Click += MyExamsButton_Click;
            // 
            // MyGradesButton
            // 
            MyGradesButton.BackColor = Color.FromArgb(154, 51, 51);
            MyGradesButton.Cursor = Cursors.Hand;
            MyGradesButton.FlatStyle = FlatStyle.Flat;
            MyGradesButton.ForeColor = Color.White;
            MyGradesButton.Location = new Point(187, 150);
            MyGradesButton.Margin = new Padding(3, 4, 3, 4);
            MyGradesButton.Name = "MyGradesButton";
            MyGradesButton.Size = new Size(267, 61);
            MyGradesButton.TabIndex = 46;
            MyGradesButton.Text = "My Grades";
            MyGradesButton.UseVisualStyleBackColor = false;
            MyGradesButton.Click += MyGradesButton_Click;
            // 
            // WelcomeLabel
            // 
            WelcomeLabel.AutoSize = true;
            WelcomeLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            WelcomeLabel.ForeColor = Color.FromArgb(154, 51, 51);
            WelcomeLabel.Location = new Point(35, 38);
            WelcomeLabel.Name = "WelcomeLabel";
            WelcomeLabel.Size = new Size(136, 37);
            WelcomeLabel.TabIndex = 45;
            WelcomeLabel.Text = "Welcome";
            WelcomeLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TakeExamButton
            // 
            TakeExamButton.BackColor = Color.FromArgb(154, 51, 51);
            TakeExamButton.Cursor = Cursors.Hand;
            TakeExamButton.FlatStyle = FlatStyle.Flat;
            TakeExamButton.ForeColor = Color.White;
            TakeExamButton.Location = new Point(184, 440);
            TakeExamButton.Margin = new Padding(3, 4, 3, 4);
            TakeExamButton.Name = "TakeExamButton";
            TakeExamButton.Size = new Size(267, 61);
            TakeExamButton.TabIndex = 44;
            TakeExamButton.Text = "Take Exam";
            TakeExamButton.UseVisualStyleBackColor = false;
            TakeExamButton.Click += TakeExamButton_Click;
            // 
            // StudentDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(619, 660);
            Controls.Add(ShowProfile);
            Controls.Add(LogoutButton);
            Controls.Add(MyExamsButton);
            Controls.Add(MyGradesButton);
            Controls.Add(WelcomeLabel);
            Controls.Add(TakeExamButton);
            MaximizeBox = false;
            Name = "StudentDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Student Dashboard";
            Load += StudentDashboard_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        public static int studentId;
        private Label ShowProfile;
        private Button LogoutButton;
        private Button MyExamsButton;
        private Button MyGradesButton;
        private Label WelcomeLabel;
        private Button TakeExamButton;
    }
}