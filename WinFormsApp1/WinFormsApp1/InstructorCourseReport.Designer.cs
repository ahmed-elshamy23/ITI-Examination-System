namespace WinFormsApp1
{
    partial class InstructorCourseReport
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
            dataGridView1 = new DataGridView();
            BackButton = new Button();
            InstructorLabel = new Label();
            InstructorBox = new ComboBox();
            GeneratePdfButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(15, 98);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(808, 466);
            dataGridView1.TabIndex = 59;
            // 
            // BackButton
            // 
            BackButton.BackColor = Color.FromArgb(154, 51, 51);
            BackButton.Cursor = Cursors.Hand;
            BackButton.FlatStyle = FlatStyle.Flat;
            BackButton.ForeColor = Color.White;
            BackButton.Location = new Point(656, 594);
            BackButton.Margin = new Padding(3, 4, 3, 4);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(144, 40);
            BackButton.TabIndex = 55;
            BackButton.Text = "Back";
            BackButton.UseVisualStyleBackColor = false;
            BackButton.Click += BackButton_Click;
            // 
            // InstructorLabel
            // 
            InstructorLabel.AutoSize = true;
            InstructorLabel.Font = new Font("Segoe UI", 12F);
            InstructorLabel.Location = new Point(40, 34);
            InstructorLabel.Name = "InstructorLabel";
            InstructorLabel.Size = new Size(100, 28);
            InstructorLabel.TabIndex = 58;
            InstructorLabel.Text = "Instructor:";
            // 
            // InstructorBox
            // 
            InstructorBox.AccessibleName = "";
            InstructorBox.DropDownStyle = ComboBoxStyle.DropDownList;
            InstructorBox.Font = new Font("Segoe UI", 12F);
            InstructorBox.FormattingEnabled = true;
            InstructorBox.Location = new Point(144, 30);
            InstructorBox.Margin = new Padding(3, 4, 3, 4);
            InstructorBox.Name = "InstructorBox";
            InstructorBox.Size = new Size(179, 36);
            InstructorBox.TabIndex = 57;
            InstructorBox.SelectedIndexChanged += InstructorBox_SelectedIndexChanged;
            // 
            // GeneratePdfButton
            // 
            GeneratePdfButton.BackColor = Color.FromArgb(154, 51, 51);
            GeneratePdfButton.Cursor = Cursors.Hand;
            GeneratePdfButton.FlatStyle = FlatStyle.Flat;
            GeneratePdfButton.ForeColor = Color.White;
            GeneratePdfButton.Location = new Point(584, 26);
            GeneratePdfButton.Margin = new Padding(3, 4, 3, 4);
            GeneratePdfButton.Name = "GeneratePdfButton";
            GeneratePdfButton.Size = new Size(208, 48);
            GeneratePdfButton.TabIndex = 56;
            GeneratePdfButton.Text = "Generate PDF";
            GeneratePdfButton.UseVisualStyleBackColor = false;
            GeneratePdfButton.Click += GeneratePdfButton_Click;
            // 
            // InstructorCourseReport
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(839, 660);
            Controls.Add(dataGridView1);
            Controls.Add(BackButton);
            Controls.Add(InstructorLabel);
            Controls.Add(InstructorBox);
            Controls.Add(GeneratePdfButton);
            MaximizeBox = false;
            Name = "InstructorCourseReport";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Instructor Courses";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button BackButton;
        private Label InstructorLabel;
        private ComboBox InstructorBox;
        private Button GeneratePdfButton;
    }
}