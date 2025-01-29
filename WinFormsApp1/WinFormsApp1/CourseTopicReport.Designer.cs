namespace WinFormsApp1
{
    partial class CourseTopicReport
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
            CourseNameLabel = new Label();
            CourseBox = new ComboBox();
            GeneratePdfButton = new Button();
            BackButton = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // CourseNameLabel
            // 
            CourseNameLabel.AutoSize = true;
            CourseNameLabel.Font = new Font("Segoe UI", 12F);
            CourseNameLabel.Location = new Point(40, 40);
            CourseNameLabel.Name = "CourseNameLabel";
            CourseNameLabel.Size = new Size(72, 28);
            CourseNameLabel.TabIndex = 53;
            CourseNameLabel.Text = "Course";
            // 
            // CourseBox
            // 
            CourseBox.AccessibleName = "";
            CourseBox.DropDownStyle = ComboBoxStyle.DropDownList;
            CourseBox.Font = new Font("Segoe UI", 12F);
            CourseBox.FormattingEnabled = true;
            CourseBox.Location = new Point(128, 36);
            CourseBox.Margin = new Padding(3, 4, 3, 4);
            CourseBox.Name = "CourseBox";
            CourseBox.Size = new Size(179, 36);
            CourseBox.TabIndex = 52;
            CourseBox.SelectedIndexChanged += CourseBox_SelectedIndexChanged;
            // 
            // GeneratePdfButton
            // 
            GeneratePdfButton.BackColor = Color.FromArgb(154, 51, 51);
            GeneratePdfButton.Cursor = Cursors.Hand;
            GeneratePdfButton.FlatStyle = FlatStyle.Flat;
            GeneratePdfButton.ForeColor = Color.White;
            GeneratePdfButton.Location = new Point(584, 32);
            GeneratePdfButton.Margin = new Padding(3, 4, 3, 4);
            GeneratePdfButton.Name = "GeneratePdfButton";
            GeneratePdfButton.Size = new Size(208, 48);
            GeneratePdfButton.TabIndex = 51;
            GeneratePdfButton.Text = "Generate PDF";
            GeneratePdfButton.UseVisualStyleBackColor = false;
            GeneratePdfButton.Click += GeneratePdfButton_Click;
            // 
            // BackButton
            // 
            BackButton.BackColor = Color.FromArgb(154, 51, 51);
            BackButton.Cursor = Cursors.Hand;
            BackButton.FlatStyle = FlatStyle.Flat;
            BackButton.ForeColor = Color.White;
            BackButton.Location = new Point(656, 600);
            BackButton.Margin = new Padding(3, 4, 3, 4);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(144, 40);
            BackButton.TabIndex = 41;
            BackButton.Text = "Back";
            BackButton.UseVisualStyleBackColor = false;
            BackButton.Click += BackButton_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(15, 104);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(808, 466);
            dataGridView1.TabIndex = 54;
            // 
            // CourseTopicReport
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(839, 660);
            Controls.Add(dataGridView1);
            Controls.Add(BackButton);
            Controls.Add(CourseNameLabel);
            Controls.Add(CourseBox);
            Controls.Add(GeneratePdfButton);
            MaximizeBox = false;
            Name = "CourseTopicReport";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Course Topics";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label CourseNameLabel;
        private ComboBox CourseBox;
        private Button GeneratePdfButton;
        private Button BackButton;
        private DataGridView dataGridView1;
    }
}