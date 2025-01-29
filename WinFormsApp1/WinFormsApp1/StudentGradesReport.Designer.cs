namespace WinFormsApp1
{
    partial class StudentGradesReport
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
            GeneratePdfButton = new Button();
            StudentLabel = new Label();
            BackButton = new Button();
            StudentBox = new ComboBox();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // GeneratePdfButton
            // 
            GeneratePdfButton.BackColor = Color.FromArgb(154, 51, 51);
            GeneratePdfButton.Cursor = Cursors.Hand;
            GeneratePdfButton.FlatStyle = FlatStyle.Flat;
            GeneratePdfButton.ForeColor = Color.White;
            GeneratePdfButton.Location = new Point(584, 29);
            GeneratePdfButton.Margin = new Padding(3, 4, 3, 4);
            GeneratePdfButton.Name = "GeneratePdfButton";
            GeneratePdfButton.Size = new Size(208, 48);
            GeneratePdfButton.TabIndex = 53;
            GeneratePdfButton.Text = "Generate PDF";
            GeneratePdfButton.UseVisualStyleBackColor = false;
            GeneratePdfButton.Click += GeneratePdfButton_Click;
            // 
            // StudentLabel
            // 
            StudentLabel.AutoSize = true;
            StudentLabel.Font = new Font("Segoe UI", 12F);
            StudentLabel.Location = new Point(64, 37);
            StudentLabel.Name = "StudentLabel";
            StudentLabel.Size = new Size(84, 28);
            StudentLabel.TabIndex = 52;
            StudentLabel.Text = "Student:";
            // 
            // BackButton
            // 
            BackButton.BackColor = Color.FromArgb(154, 51, 51);
            BackButton.Cursor = Cursors.Hand;
            BackButton.FlatStyle = FlatStyle.Flat;
            BackButton.ForeColor = Color.White;
            BackButton.Location = new Point(647, 591);
            BackButton.Margin = new Padding(3, 4, 3, 4);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(144, 40);
            BackButton.TabIndex = 51;
            BackButton.Text = "Back";
            BackButton.UseVisualStyleBackColor = false;
            BackButton.Click += BackButton_Click;
            // 
            // StudentBox
            // 
            StudentBox.AccessibleName = "";
            StudentBox.DropDownStyle = ComboBoxStyle.DropDownList;
            StudentBox.Font = new Font("Segoe UI", 12F);
            StudentBox.FormattingEnabled = true;
            StudentBox.Location = new Point(160, 35);
            StudentBox.Margin = new Padding(3, 4, 3, 4);
            StudentBox.Name = "StudentBox";
            StudentBox.Size = new Size(179, 36);
            StudentBox.TabIndex = 50;
            StudentBox.SelectedIndexChanged += CourseBox_SelectedIndexChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(15, 109);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(808, 466);
            dataGridView1.TabIndex = 49;
            // 
            // StudentGradesReport
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(839, 660);
            Controls.Add(GeneratePdfButton);
            Controls.Add(StudentLabel);
            Controls.Add(BackButton);
            Controls.Add(StudentBox);
            Controls.Add(dataGridView1);
            MaximizeBox = false;
            Name = "StudentGradesReport";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Student Grades";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button GeneratePdfButton;
        private Label StudentLabel;
        private Button BackButton;
        private ComboBox StudentBox;
        private DataGridView dataGridView1;
    }
}