namespace WinFormsApp1
{
	partial class InstructorDashboard
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
            WelcomeLabel = new Label();
            NewQuestionButton = new Button();
            AllStudentsButton = new Button();
            AllCoursesButton = new Button();
            LogoutButton = new Button();
            ShowProfile = new Label();
            ReportsButton = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // WelcomeLabel
            // 
            WelcomeLabel.AutoSize = true;
            WelcomeLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            WelcomeLabel.ForeColor = Color.FromArgb(154, 51, 51);
            WelcomeLabel.Location = new Point(24, 48);
            WelcomeLabel.Name = "WelcomeLabel";
            WelcomeLabel.Size = new Size(136, 37);
            WelcomeLabel.TabIndex = 12;
            WelcomeLabel.Text = "Welcome";
            WelcomeLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // NewQuestionButton
            // 
            NewQuestionButton.BackColor = Color.FromArgb(154, 51, 51);
            NewQuestionButton.Cursor = Cursors.Hand;
            NewQuestionButton.FlatStyle = FlatStyle.Flat;
            NewQuestionButton.ForeColor = Color.White;
            NewQuestionButton.Location = new Point(104, 296);
            NewQuestionButton.Margin = new Padding(3, 4, 3, 4);
            NewQuestionButton.Name = "NewQuestionButton";
            NewQuestionButton.Size = new Size(267, 61);
            NewQuestionButton.TabIndex = 1;
            NewQuestionButton.Text = "Questions";
            NewQuestionButton.UseVisualStyleBackColor = false;
            NewQuestionButton.Click += NewQuestionButton_Click;
            // 
            // AllStudentsButton
            // 
            AllStudentsButton.BackColor = Color.FromArgb(154, 51, 51);
            AllStudentsButton.Cursor = Cursors.Hand;
            AllStudentsButton.FlatStyle = FlatStyle.Flat;
            AllStudentsButton.ForeColor = Color.White;
            AllStudentsButton.Location = new Point(104, 152);
            AllStudentsButton.Margin = new Padding(3, 4, 3, 4);
            AllStudentsButton.Name = "AllStudentsButton";
            AllStudentsButton.Size = new Size(267, 61);
            AllStudentsButton.TabIndex = 37;
            AllStudentsButton.Text = "Students";
            AllStudentsButton.UseVisualStyleBackColor = false;
            AllStudentsButton.Click += AllStudentsButton_Click;
            // 
            // AllCoursesButton
            // 
            AllCoursesButton.BackColor = Color.FromArgb(154, 51, 51);
            AllCoursesButton.Cursor = Cursors.Hand;
            AllCoursesButton.FlatStyle = FlatStyle.Flat;
            AllCoursesButton.ForeColor = Color.White;
            AllCoursesButton.Location = new Point(472, 152);
            AllCoursesButton.Margin = new Padding(3, 4, 3, 4);
            AllCoursesButton.Name = "AllCoursesButton";
            AllCoursesButton.Size = new Size(267, 61);
            AllCoursesButton.TabIndex = 38;
            AllCoursesButton.Text = "Courses";
            AllCoursesButton.UseVisualStyleBackColor = false;
            AllCoursesButton.Click += AllCoursesButton_Click;
            // 
            // LogoutButton
            // 
            LogoutButton.BackColor = Color.FromArgb(154, 51, 51);
            LogoutButton.Cursor = Cursors.Hand;
            LogoutButton.FlatStyle = FlatStyle.Flat;
            LogoutButton.ForeColor = Color.White;
            LogoutButton.Location = new Point(648, 592);
            LogoutButton.Margin = new Padding(3, 4, 3, 4);
            LogoutButton.Name = "LogoutButton";
            LogoutButton.Size = new Size(144, 40);
            LogoutButton.TabIndex = 39;
            LogoutButton.Text = "Logout";
            LogoutButton.UseVisualStyleBackColor = false;
            LogoutButton.Click += LogoutButton_Click;
            // 
            // ShowProfile
            // 
            ShowProfile.AutoSize = true;
            ShowProfile.Cursor = Cursors.Hand;
            ShowProfile.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            ShowProfile.ForeColor = Color.FromArgb(154, 51, 51);
            ShowProfile.Location = new Point(648, 56);
            ShowProfile.Name = "ShowProfile";
            ShowProfile.Size = new Size(111, 28);
            ShowProfile.TabIndex = 40;
            ShowProfile.Text = "My Profile";
            ShowProfile.TextAlign = ContentAlignment.MiddleCenter;
            ShowProfile.Click += ShowProfile_Click;
            // 
            // ReportsButton
            // 
            ReportsButton.AutoEllipsis = true;
            ReportsButton.BackColor = Color.FromArgb(154, 51, 51);
            ReportsButton.Cursor = Cursors.Hand;
            ReportsButton.FlatStyle = FlatStyle.Flat;
            ReportsButton.ForeColor = Color.White;
            ReportsButton.Location = new Point(288, 434);
            ReportsButton.Margin = new Padding(3, 4, 3, 4);
            ReportsButton.Name = "ReportsButton";
            ReportsButton.Size = new Size(267, 61);
            ReportsButton.TabIndex = 41;
            ReportsButton.Text = "Reports";
            ReportsButton.UseVisualStyleBackColor = false;
            ReportsButton.Click += ReportsButton_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(154, 51, 51);
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(472, 296);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(267, 61);
            button1.TabIndex = 42;
            button1.Text = "Generate Exam";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // InstructorDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(839, 660);
            Controls.Add(button1);
            Controls.Add(ReportsButton);
            Controls.Add(ShowProfile);
            Controls.Add(LogoutButton);
            Controls.Add(AllCoursesButton);
            Controls.Add(AllStudentsButton);
            Controls.Add(WelcomeLabel);
            Controls.Add(NewQuestionButton);
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "InstructorDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Instructor Dashboard";
            Load += InstructorDashboard_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public static int instructorId;
		private Label WelcomeLabel;
		private Button NewQuestionButton;
		private Button AllStudentsButton;
		private Button AllCoursesButton;
        private Button LogoutButton;
        private Label ShowProfile;
        private Button ReportsButton;
        private Button button1;
    }
}