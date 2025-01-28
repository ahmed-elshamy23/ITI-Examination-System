using Dapper;
using Microsoft.Data.SqlClient;
using System.Data;

namespace WinFormsApp1
{
	partial class ShowAllCourses
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
            DeleteCourseButton = new Button();
            NewCourseButton = new Button();
            dataGridView1 = new DataGridView();
            connection = new SqlConnection();
            UpdateCourseButton = new Button();
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
            BackButton.TabIndex = 48;
            BackButton.Text = "Back";
            BackButton.UseVisualStyleBackColor = false;
            BackButton.Click += BackButton_Click;
            // 
            // DeleteCourseButton
            // 
            DeleteCourseButton.BackColor = Color.FromArgb(154, 51, 51);
            DeleteCourseButton.Cursor = Cursors.Hand;
            DeleteCourseButton.FlatStyle = FlatStyle.Flat;
            DeleteCourseButton.ForeColor = Color.White;
            DeleteCourseButton.Location = new Point(568, 48);
            DeleteCourseButton.Margin = new Padding(3, 4, 3, 4);
            DeleteCourseButton.Name = "DeleteCourseButton";
            DeleteCourseButton.Size = new Size(208, 48);
            DeleteCourseButton.TabIndex = 47;
            DeleteCourseButton.Text = "Delete Course";
            DeleteCourseButton.UseVisualStyleBackColor = false;
            DeleteCourseButton.Click += DeleteCourseButton_Click;
            // 
            // NewCourseButton
            // 
            NewCourseButton.BackColor = Color.FromArgb(154, 51, 51);
            NewCourseButton.Cursor = Cursors.Hand;
            NewCourseButton.FlatStyle = FlatStyle.Flat;
            NewCourseButton.ForeColor = Color.White;
            NewCourseButton.Location = new Point(48, 48);
            NewCourseButton.Margin = new Padding(3, 4, 3, 4);
            NewCourseButton.Name = "NewCourseButton";
            NewCourseButton.Size = new Size(208, 48);
            NewCourseButton.TabIndex = 46;
            NewCourseButton.Text = "New Course";
            NewCourseButton.UseVisualStyleBackColor = false;
            NewCourseButton.Click += NewCourseButton_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(15, 136);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(808, 424);
            dataGridView1.TabIndex = 41;
            // 
            // connection
            // 
            connection.AccessTokenCallback = null;
            connection.FireInfoMessageEventOnUserErrors = false;
            // 
            // UpdateCourseButton
            // 
            UpdateCourseButton.BackColor = Color.FromArgb(154, 51, 51);
            UpdateCourseButton.Cursor = Cursors.Hand;
            UpdateCourseButton.FlatStyle = FlatStyle.Flat;
            UpdateCourseButton.ForeColor = Color.White;
            UpdateCourseButton.Location = new Point(312, 48);
            UpdateCourseButton.Margin = new Padding(3, 4, 3, 4);
            UpdateCourseButton.Name = "UpdateCourseButton";
            UpdateCourseButton.Size = new Size(208, 48);
            UpdateCourseButton.TabIndex = 49;
            UpdateCourseButton.Text = "Update Course";
            UpdateCourseButton.UseVisualStyleBackColor = false;
            UpdateCourseButton.Click += UpdateCourseButton_Click;
            // 
            // ShowAllCourses
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(839, 660);
            Controls.Add(UpdateCourseButton);
            Controls.Add(BackButton);
            Controls.Add(DeleteCourseButton);
            Controls.Add(NewCourseButton);
            Controls.Add(dataGridView1);
            MaximizeBox = false;
            Name = "ShowAllCourses";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Courses";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button BackButton;
		private Button DeleteCourseButton;
		private Button NewCourseButton;
		private DataGridView dataGridView1;
		private SqlConnection connection;
        private Button UpdateCourseButton;
    }
}