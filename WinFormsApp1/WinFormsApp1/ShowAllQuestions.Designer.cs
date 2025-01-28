namespace WinFormsApp1
{
    partial class ShowAllQuestions
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
            NewQuestionButton = new Button();
            CourseBox = new ComboBox();
            CourseNameLabel = new Label();
            PanelQuestion = new Panel();
            Back = new Button();
            previousButton = new Button();
            nextButton = new Button();
            SuspendLayout();
            // 
            // NewQuestionButton
            // 
            NewQuestionButton.BackColor = Color.FromArgb(154, 51, 51);
            NewQuestionButton.Cursor = Cursors.Hand;
            NewQuestionButton.FlatStyle = FlatStyle.Flat;
            NewQuestionButton.ForeColor = Color.White;
            NewQuestionButton.Location = new Point(1024, 48);
            NewQuestionButton.Margin = new Padding(3, 4, 3, 4);
            NewQuestionButton.Name = "NewQuestionButton";
            NewQuestionButton.Size = new Size(208, 48);
            NewQuestionButton.TabIndex = 47;
            NewQuestionButton.Text = "New Question";
            NewQuestionButton.UseVisualStyleBackColor = false;
            NewQuestionButton.Click += NewQuestionButton_Click;
            // 
            // CourseBox
            // 
            CourseBox.AccessibleName = "";
            CourseBox.DropDownStyle = ComboBoxStyle.DropDownList;
            CourseBox.Font = new Font("Segoe UI", 12F);
            CourseBox.FormattingEnabled = true;
            CourseBox.Location = new Point(120, 56);
            CourseBox.Margin = new Padding(3, 4, 3, 4);
            CourseBox.Name = "CourseBox";
            CourseBox.Size = new Size(179, 36);
            CourseBox.TabIndex = 48;
            CourseBox.SelectedIndexChanged += CourseBox_SelectedIndexChanged;
            // 
            // CourseNameLabel
            // 
            CourseNameLabel.AutoSize = true;
            CourseNameLabel.Font = new Font("Segoe UI", 12F);
            CourseNameLabel.Location = new Point(32, 60);
            CourseNameLabel.Name = "CourseNameLabel";
            CourseNameLabel.Size = new Size(72, 28);
            CourseNameLabel.TabIndex = 49;
            CourseNameLabel.Text = "Course";
            // 
            // PanelQuestion
            // 
            PanelQuestion.Location = new Point(20, 112);
            PanelQuestion.Name = "PanelQuestion";
            PanelQuestion.Size = new Size(1236, 512);
            PanelQuestion.TabIndex = 50;
            // 
            // Back
            // 
            Back.BackColor = Color.FromArgb(154, 51, 51);
            Back.Cursor = Cursors.Hand;
            Back.FlatStyle = FlatStyle.Flat;
            Back.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Back.ForeColor = Color.White;
            Back.Location = new Point(12, 12);
            Back.Margin = new Padding(3, 4, 3, 4);
            Back.Name = "Back";
            Back.Size = new Size(80, 33);
            Back.TabIndex = 40;
            Back.Text = "BACK";
            Back.UseVisualStyleBackColor = false;
            Back.Click += Back_Click;
            // 
            // previousButton
            // 
            previousButton.BackColor = Color.FromArgb(154, 51, 51);
            previousButton.Cursor = Cursors.Hand;
            previousButton.FlatStyle = FlatStyle.Flat;
            previousButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            previousButton.ForeColor = Color.White;
            previousButton.Location = new Point(12, 648);
            previousButton.Margin = new Padding(3, 4, 3, 4);
            previousButton.Name = "previousButton";
            previousButton.Size = new Size(80, 33);
            previousButton.TabIndex = 51;
            previousButton.Text = "PREV";
            previousButton.UseVisualStyleBackColor = false;
            previousButton.Click += previousButton_Click;
            // 
            // nextButton
            // 
            nextButton.BackColor = Color.FromArgb(154, 51, 51);
            nextButton.Cursor = Cursors.Hand;
            nextButton.FlatStyle = FlatStyle.Flat;
            nextButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nextButton.ForeColor = Color.White;
            nextButton.Location = new Point(1180, 648);
            nextButton.Margin = new Padding(3, 4, 3, 4);
            nextButton.Name = "nextButton";
            nextButton.Size = new Size(80, 33);
            nextButton.TabIndex = 52;
            nextButton.Text = "NEXT";
            nextButton.UseVisualStyleBackColor = false;
            nextButton.Click += nextButton_Click;
            // 
            // ShowAllQuestions
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1279, 704);
            Controls.Add(nextButton);
            Controls.Add(previousButton);
            Controls.Add(Back);
            Controls.Add(PanelQuestion);
            Controls.Add(CourseNameLabel);
            Controls.Add(CourseBox);
            Controls.Add(NewQuestionButton);
            MaximizeBox = false;
            Name = "ShowAllQuestions";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Questions";
            Load += ShowAllQuestions_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button NewQuestionButton;
        private ComboBox CourseBox;
        private Label CourseNameLabel;
        private Panel PanelQuestion;
        private Button Back;
        private Button previousButton;
        private Button nextButton;
    }
}