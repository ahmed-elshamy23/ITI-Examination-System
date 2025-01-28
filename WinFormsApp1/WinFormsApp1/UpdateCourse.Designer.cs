namespace WinFormsApp1
{
    partial class UpdateCourse
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
            DeleteBox = new ComboBox();
            UpdateButton = new Button();
            CourseNameLabel = new Label();
            CourseDurationInput = new TextBox();
            CourseDurationLabel = new Label();
            SuspendLayout();
            // 
            // DeleteBox
            // 
            DeleteBox.DropDownStyle = ComboBoxStyle.DropDownList;
            DeleteBox.FormattingEnabled = true;
            DeleteBox.Location = new Point(200, 72);
            DeleteBox.Name = "DeleteBox";
            DeleteBox.Size = new Size(184, 28);
            DeleteBox.TabIndex = 40;
            // 
            // UpdateButton
            // 
            UpdateButton.BackColor = Color.FromArgb(154, 51, 51);
            UpdateButton.Cursor = Cursors.Hand;
            UpdateButton.FlatStyle = FlatStyle.Flat;
            UpdateButton.Font = new Font("Segoe UI", 12F);
            UpdateButton.ForeColor = Color.White;
            UpdateButton.Location = new Point(98, 208);
            UpdateButton.Margin = new Padding(3, 4, 3, 4);
            UpdateButton.Name = "UpdateButton";
            UpdateButton.Size = new Size(281, 45);
            UpdateButton.TabIndex = 39;
            UpdateButton.Text = "Update";
            UpdateButton.UseVisualStyleBackColor = false;
            UpdateButton.Click += UpdateButton_Click;
            // 
            // CourseNameLabel
            // 
            CourseNameLabel.AutoSize = true;
            CourseNameLabel.Font = new Font("Segoe UI", 12F);
            CourseNameLabel.Location = new Point(112, 70);
            CourseNameLabel.Name = "CourseNameLabel";
            CourseNameLabel.Size = new Size(68, 28);
            CourseNameLabel.TabIndex = 38;
            CourseNameLabel.Text = "Name:";
            // 
            // CourseDurationInput
            // 
            CourseDurationInput.Font = new Font("Segoe UI", 12F);
            CourseDurationInput.Location = new Point(197, 136);
            CourseDurationInput.Margin = new Padding(3, 4, 3, 4);
            CourseDurationInput.Name = "CourseDurationInput";
            CourseDurationInput.Size = new Size(187, 34);
            CourseDurationInput.TabIndex = 42;
            // 
            // CourseDurationLabel
            // 
            CourseDurationLabel.AutoSize = true;
            CourseDurationLabel.Font = new Font("Segoe UI", 12F);
            CourseDurationLabel.Location = new Point(93, 138);
            CourseDurationLabel.Name = "CourseDurationLabel";
            CourseDurationLabel.Size = new Size(93, 28);
            CourseDurationLabel.TabIndex = 41;
            CourseDurationLabel.Text = "Duration:";
            // 
            // UpdateCourse
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(476, 306);
            Controls.Add(CourseDurationInput);
            Controls.Add(CourseDurationLabel);
            Controls.Add(DeleteBox);
            Controls.Add(UpdateButton);
            Controls.Add(CourseNameLabel);
            MaximizeBox = false;
            Name = "UpdateCourse";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Update Course";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox DeleteBox;
        private Button UpdateButton;
        private Label CourseNameLabel;
        private TextBox CourseDurationInput;
        private Label CourseDurationLabel;
    }
}