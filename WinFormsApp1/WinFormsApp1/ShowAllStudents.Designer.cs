using Microsoft.Data.SqlClient;
using Dapper;
using System.Data;

namespace WinFormsApp1
{
	partial class ShowAllStudents
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
            DepartmentBox = new ComboBox();
            CourseBox = new ComboBox();
            NewStudentButton = new Button();
            DeleteStudentButton = new Button();
            BackButton = new Button();
            CourseCheckBox = new CheckBox();
            DepartmentCheckBox = new CheckBox();
            UpdateStudentButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(16, 152);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(808, 424);
            dataGridView1.TabIndex = 0;
            // 
            // DepartmentBox
            // 
            DepartmentBox.AccessibleName = "";
            DepartmentBox.DropDownStyle = ComboBoxStyle.DropDownList;
            DepartmentBox.Font = new Font("Segoe UI", 12F);
            DepartmentBox.FormattingEnabled = true;
            DepartmentBox.Location = new Point(194, 24);
            DepartmentBox.Margin = new Padding(3, 4, 3, 4);
            DepartmentBox.Name = "DepartmentBox";
            DepartmentBox.Size = new Size(179, 36);
            DepartmentBox.TabIndex = 12;
            DepartmentBox.SelectedIndexChanged += ApplyFilters;
            // 
            // CourseBox
            // 
            CourseBox.AccessibleName = "";
            CourseBox.DropDownStyle = ComboBoxStyle.DropDownList;
            CourseBox.Font = new Font("Segoe UI", 12F);
            CourseBox.FormattingEnabled = true;
            CourseBox.Location = new Point(608, 24);
            CourseBox.Margin = new Padding(3, 4, 3, 4);
            CourseBox.Name = "CourseBox";
            CourseBox.Size = new Size(179, 36);
            CourseBox.TabIndex = 14;
            CourseBox.SelectedIndexChanged += ApplyFilters;
            // 
            // NewStudentButton
            // 
            NewStudentButton.BackColor = Color.FromArgb(154, 51, 51);
            NewStudentButton.Cursor = Cursors.Hand;
            NewStudentButton.FlatStyle = FlatStyle.Flat;
            NewStudentButton.ForeColor = Color.White;
            NewStudentButton.Location = new Point(48, 80);
            NewStudentButton.Margin = new Padding(3, 4, 3, 4);
            NewStudentButton.Name = "NewStudentButton";
            NewStudentButton.Size = new Size(208, 48);
            NewStudentButton.TabIndex = 15;
            NewStudentButton.Text = "New Student";
            NewStudentButton.UseVisualStyleBackColor = false;
            NewStudentButton.Click += NewStudentButton_Click;
            // 
            // DeleteStudentButton
            // 
            DeleteStudentButton.BackColor = Color.FromArgb(154, 51, 51);
            DeleteStudentButton.Cursor = Cursors.Hand;
            DeleteStudentButton.FlatStyle = FlatStyle.Flat;
            DeleteStudentButton.ForeColor = Color.White;
            DeleteStudentButton.Location = new Point(568, 80);
            DeleteStudentButton.Margin = new Padding(3, 4, 3, 4);
            DeleteStudentButton.Name = "DeleteStudentButton";
            DeleteStudentButton.Size = new Size(208, 48);
            DeleteStudentButton.TabIndex = 16;
            DeleteStudentButton.Text = "Delete Student";
            DeleteStudentButton.UseVisualStyleBackColor = false;
            DeleteStudentButton.Click += DeleteStudentButton_Click;
            // 
            // BackButton
            // 
            BackButton.BackColor = Color.FromArgb(154, 51, 51);
            BackButton.Cursor = Cursors.Hand;
            BackButton.FlatStyle = FlatStyle.Flat;
            BackButton.ForeColor = Color.White;
            BackButton.Location = new Point(648, 592);
            BackButton.Margin = new Padding(3, 4, 3, 4);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(144, 40);
            BackButton.TabIndex = 40;
            BackButton.Text = "Back";
            BackButton.UseVisualStyleBackColor = false;
            BackButton.Click += BackButton_Click;
            // 
            // CourseCheckBox
            // 
            CourseCheckBox.AutoSize = true;
            CourseCheckBox.Font = new Font("Segoe UI", 12F);
            CourseCheckBox.Location = new Point(504, 26);
            CourseCheckBox.Name = "CourseCheckBox";
            CourseCheckBox.Size = new Size(98, 32);
            CourseCheckBox.TabIndex = 41;
            CourseCheckBox.Text = "Course:";
            CourseCheckBox.UseVisualStyleBackColor = true;
            CourseCheckBox.CheckedChanged += ApplyFilters;
            // 
            // DepartmentCheckBox
            // 
            DepartmentCheckBox.AutoSize = true;
            DepartmentCheckBox.Font = new Font("Segoe UI", 12F);
            DepartmentCheckBox.Location = new Point(48, 26);
            DepartmentCheckBox.Name = "DepartmentCheckBox";
            DepartmentCheckBox.Size = new Size(143, 32);
            DepartmentCheckBox.TabIndex = 42;
            DepartmentCheckBox.Text = "Department:";
            DepartmentCheckBox.UseVisualStyleBackColor = true;
            DepartmentCheckBox.CheckedChanged += ApplyFilters;
            // 
            // UpdateStudentButton
            // 
            UpdateStudentButton.BackColor = Color.FromArgb(154, 51, 51);
            UpdateStudentButton.Cursor = Cursors.Hand;
            UpdateStudentButton.FlatStyle = FlatStyle.Flat;
            UpdateStudentButton.ForeColor = Color.White;
            UpdateStudentButton.Location = new Point(312, 80);
            UpdateStudentButton.Margin = new Padding(3, 4, 3, 4);
            UpdateStudentButton.Name = "UpdateStudentButton";
            UpdateStudentButton.Size = new Size(208, 48);
            UpdateStudentButton.TabIndex = 50;
            UpdateStudentButton.Text = "Update Student";
            UpdateStudentButton.UseVisualStyleBackColor = false;
            UpdateStudentButton.Click += UpdateStudentButton_Click;
            // 
            // ShowAllStudents
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(839, 660);
            Controls.Add(UpdateStudentButton);
            Controls.Add(DepartmentCheckBox);
            Controls.Add(CourseCheckBox);
            Controls.Add(BackButton);
            Controls.Add(DeleteStudentButton);
            Controls.Add(NewStudentButton);
            Controls.Add(CourseBox);
            Controls.Add(DepartmentBox);
            Controls.Add(dataGridView1);
            MaximizeBox = false;
            Name = "ShowAllStudents";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Students";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
		private ComboBox DepartmentBox;
		private ComboBox CourseBox;
		private Button NewStudentButton;
		private Button DeleteStudentButton;
		private Button BackButton;
        private CheckBox CourseCheckBox;
        private CheckBox DepartmentCheckBox;
        private Button UpdateStudentButton;
    }
}