namespace WinFormsApp1
{
    partial class DeleteStudent
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
            DeleteButton = new Button();
            CourseNameLabel = new Label();
            DeleteBox = new ComboBox();
            SuspendLayout();
            // 
            // DeleteButton
            // 
            DeleteButton.BackColor = Color.FromArgb(154, 51, 51);
            DeleteButton.Cursor = Cursors.Hand;
            DeleteButton.FlatStyle = FlatStyle.Flat;
            DeleteButton.Font = new Font("Segoe UI", 12F);
            DeleteButton.ForeColor = Color.White;
            DeleteButton.Location = new Point(106, 195);
            DeleteButton.Margin = new Padding(3, 4, 3, 4);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(281, 45);
            DeleteButton.TabIndex = 33;
            DeleteButton.Text = "Delete";
            DeleteButton.UseVisualStyleBackColor = false;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // CourseNameLabel
            // 
            CourseNameLabel.AutoSize = true;
            CourseNameLabel.Font = new Font("Segoe UI", 12F);
            CourseNameLabel.Location = new Point(120, 102);
            CourseNameLabel.Name = "CourseNameLabel";
            CourseNameLabel.Size = new Size(35, 28);
            CourseNameLabel.TabIndex = 32;
            CourseNameLabel.Text = "ID:";
            // 
            // DeleteBox
            // 
            DeleteBox.DropDownStyle = ComboBoxStyle.DropDownList;
            DeleteBox.FormattingEnabled = true;
            DeleteBox.Location = new Point(184, 104);
            DeleteBox.Name = "DeleteBox";
            DeleteBox.Size = new Size(184, 28);
            DeleteBox.TabIndex = 34;
            // 
            // DeleteStudent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(476, 306);
            Controls.Add(DeleteBox);
            Controls.Add(DeleteButton);
            Controls.Add(CourseNameLabel);
            MaximizeBox = false;
            Name = "DeleteStudent";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Delete Student";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button DeleteButton;
        private Label CourseNameLabel;
        private ComboBox DeleteBox;
    }
}