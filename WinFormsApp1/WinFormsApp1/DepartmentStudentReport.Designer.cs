namespace WinFormsApp1
{
    partial class DepartmentStudentReport
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
            BackButton = new Button();
            DepartmentBox = new ComboBox();
            dataGridView1 = new DataGridView();
            DepartmentLabel = new Label();
            GeneratePdfButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // BackButton
            // 
            BackButton.BackColor = Color.FromArgb(154, 51, 51);
            BackButton.Cursor = Cursors.Hand;
            BackButton.FlatStyle = FlatStyle.Flat;
            BackButton.ForeColor = Color.White;
            BackButton.Location = new Point(647, 594);
            BackButton.Margin = new Padding(3, 4, 3, 4);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(144, 40);
            BackButton.TabIndex = 45;
            BackButton.Text = "Back";
            BackButton.UseVisualStyleBackColor = false;
            BackButton.Click += BackButton_Click;
            // 
            // DepartmentBox
            // 
            DepartmentBox.AccessibleName = "";
            DepartmentBox.DropDownStyle = ComboBoxStyle.DropDownList;
            DepartmentBox.Font = new Font("Segoe UI", 12F);
            DepartmentBox.FormattingEnabled = true;
            DepartmentBox.Location = new Point(185, 38);
            DepartmentBox.Margin = new Padding(3, 4, 3, 4);
            DepartmentBox.Name = "DepartmentBox";
            DepartmentBox.Size = new Size(179, 36);
            DepartmentBox.TabIndex = 44;
            DepartmentBox.SelectedIndexChanged += DepartmentBox_SelectedIndexChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(15, 112);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(808, 466);
            dataGridView1.TabIndex = 43;
            // 
            // DepartmentLabel
            // 
            DepartmentLabel.AutoSize = true;
            DepartmentLabel.Font = new Font("Segoe UI", 12F);
            DepartmentLabel.Location = new Point(48, 40);
            DepartmentLabel.Name = "DepartmentLabel";
            DepartmentLabel.Size = new Size(121, 28);
            DepartmentLabel.TabIndex = 47;
            DepartmentLabel.Text = "Department:";
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
            GeneratePdfButton.TabIndex = 48;
            GeneratePdfButton.Text = "Generate PDF";
            GeneratePdfButton.UseVisualStyleBackColor = false;
            GeneratePdfButton.Click += GeneratePdfButton_Click;
            // 
            // DepartmentStudentReport
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(839, 660);
            Controls.Add(GeneratePdfButton);
            Controls.Add(DepartmentLabel);
            Controls.Add(BackButton);
            Controls.Add(DepartmentBox);
            Controls.Add(dataGridView1);
            MaximizeBox = false;
            Name = "DepartmentStudentReport";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Show Students by Department";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button BackButton;
        private ComboBox DepartmentBox;
        private DataGridView dataGridView1;
        private Label DepartmentLabel;
        private Button GeneratePdfButton;
    }
}