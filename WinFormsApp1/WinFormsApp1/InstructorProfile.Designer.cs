namespace WinFormsApp1
{
    partial class InstructorProfile
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
            UpdateButton = new Button();
            DepartmentLabel = new Label();
            EmailInput = new TextBox();
            EmailLabel = new Label();
            PhoneInput = new TextBox();
            PhoneLabel = new Label();
            AddressInput = new TextBox();
            AddressLabel = new Label();
            NameInput = new TextBox();
            NameLabel = new Label();
            CourseNameLabel = new Label();
            DepartmentInput = new TextBox();
            SalaryInput = new TextBox();
            SalaryLabel = new Label();
            IdInput = new TextBox();
            SuspendLayout();
            // 
            // UpdateButton
            // 
            UpdateButton.BackColor = Color.FromArgb(154, 51, 51);
            UpdateButton.Cursor = Cursors.Hand;
            UpdateButton.FlatStyle = FlatStyle.Flat;
            UpdateButton.Font = new Font("Segoe UI", 12F);
            UpdateButton.ForeColor = Color.White;
            UpdateButton.Location = new Point(120, 592);
            UpdateButton.Margin = new Padding(3, 4, 3, 4);
            UpdateButton.Name = "UpdateButton";
            UpdateButton.Size = new Size(281, 45);
            UpdateButton.TabIndex = 68;
            UpdateButton.Text = "Update";
            UpdateButton.UseVisualStyleBackColor = false;
            UpdateButton.Click += UpdateButton_Click;
            // 
            // DepartmentLabel
            // 
            DepartmentLabel.AutoSize = true;
            DepartmentLabel.Font = new Font("Segoe UI", 12F);
            DepartmentLabel.Location = new Point(37, 510);
            DepartmentLabel.Name = "DepartmentLabel";
            DepartmentLabel.Size = new Size(121, 28);
            DepartmentLabel.TabIndex = 66;
            DepartmentLabel.Text = "Department:";
            // 
            // EmailInput
            // 
            EmailInput.Font = new Font("Segoe UI", 12F);
            EmailInput.Location = new Point(165, 423);
            EmailInput.Margin = new Padding(3, 4, 3, 4);
            EmailInput.Name = "EmailInput";
            EmailInput.Size = new Size(304, 34);
            EmailInput.TabIndex = 65;
            // 
            // EmailLabel
            // 
            EmailLabel.AutoSize = true;
            EmailLabel.Font = new Font("Segoe UI", 12F);
            EmailLabel.Location = new Point(61, 425);
            EmailLabel.Name = "EmailLabel";
            EmailLabel.Size = new Size(63, 28);
            EmailLabel.TabIndex = 64;
            EmailLabel.Text = "Email:";
            // 
            // PhoneInput
            // 
            PhoneInput.Font = new Font("Segoe UI", 12F);
            PhoneInput.Location = new Point(165, 343);
            PhoneInput.Margin = new Padding(3, 4, 3, 4);
            PhoneInput.Name = "PhoneInput";
            PhoneInput.Size = new Size(304, 34);
            PhoneInput.TabIndex = 63;
            // 
            // PhoneLabel
            // 
            PhoneLabel.AutoSize = true;
            PhoneLabel.Font = new Font("Segoe UI", 12F);
            PhoneLabel.Location = new Point(53, 345);
            PhoneLabel.Name = "PhoneLabel";
            PhoneLabel.Size = new Size(71, 28);
            PhoneLabel.TabIndex = 62;
            PhoneLabel.Text = "Phone:";
            // 
            // AddressInput
            // 
            AddressInput.Font = new Font("Segoe UI", 12F);
            AddressInput.Location = new Point(165, 255);
            AddressInput.Margin = new Padding(3, 4, 3, 4);
            AddressInput.Name = "AddressInput";
            AddressInput.Size = new Size(304, 34);
            AddressInput.TabIndex = 61;
            // 
            // AddressLabel
            // 
            AddressLabel.AutoSize = true;
            AddressLabel.Font = new Font("Segoe UI", 12F);
            AddressLabel.Location = new Point(45, 257);
            AddressLabel.Name = "AddressLabel";
            AddressLabel.Size = new Size(91, 28);
            AddressLabel.TabIndex = 60;
            AddressLabel.Text = "Address: ";
            // 
            // NameInput
            // 
            NameInput.BorderStyle = BorderStyle.None;
            NameInput.Font = new Font("Segoe UI", 12F);
            NameInput.Location = new Point(165, 118);
            NameInput.Margin = new Padding(3, 4, 3, 4);
            NameInput.Name = "NameInput";
            NameInput.ReadOnly = true;
            NameInput.Size = new Size(304, 27);
            NameInput.TabIndex = 59;
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Font = new Font("Segoe UI", 12F);
            NameLabel.Location = new Point(53, 117);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(68, 28);
            NameLabel.TabIndex = 58;
            NameLabel.Text = "Name:";
            // 
            // CourseNameLabel
            // 
            CourseNameLabel.AutoSize = true;
            CourseNameLabel.Font = new Font("Segoe UI", 12F);
            CourseNameLabel.Location = new Point(69, 44);
            CourseNameLabel.Name = "CourseNameLabel";
            CourseNameLabel.Size = new Size(35, 28);
            CourseNameLabel.TabIndex = 56;
            CourseNameLabel.Text = "ID:";
            // 
            // DepartmentInput
            // 
            DepartmentInput.BorderStyle = BorderStyle.None;
            DepartmentInput.Font = new Font("Segoe UI", 12F);
            DepartmentInput.Location = new Point(168, 510);
            DepartmentInput.Margin = new Padding(3, 4, 3, 4);
            DepartmentInput.Name = "DepartmentInput";
            DepartmentInput.ReadOnly = true;
            DepartmentInput.Size = new Size(304, 27);
            DepartmentInput.TabIndex = 69;
            // 
            // SalaryInput
            // 
            SalaryInput.BorderStyle = BorderStyle.None;
            SalaryInput.Font = new Font("Segoe UI", 12F);
            SalaryInput.Location = new Point(168, 186);
            SalaryInput.Margin = new Padding(3, 4, 3, 4);
            SalaryInput.Name = "SalaryInput";
            SalaryInput.ReadOnly = true;
            SalaryInput.Size = new Size(304, 27);
            SalaryInput.TabIndex = 71;
            // 
            // SalaryLabel
            // 
            SalaryLabel.AutoSize = true;
            SalaryLabel.Font = new Font("Segoe UI", 12F);
            SalaryLabel.Location = new Point(56, 186);
            SalaryLabel.Name = "SalaryLabel";
            SalaryLabel.Size = new Size(69, 28);
            SalaryLabel.TabIndex = 70;
            SalaryLabel.Text = "Salary:";
            // 
            // IdInput
            // 
            IdInput.BorderStyle = BorderStyle.None;
            IdInput.Font = new Font("Segoe UI", 12F);
            IdInput.Location = new Point(160, 45);
            IdInput.Margin = new Padding(3, 4, 3, 4);
            IdInput.Name = "IdInput";
            IdInput.ReadOnly = true;
            IdInput.Size = new Size(304, 27);
            IdInput.TabIndex = 72;
            // 
            // InstructorProfile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(507, 680);
            Controls.Add(IdInput);
            Controls.Add(SalaryInput);
            Controls.Add(SalaryLabel);
            Controls.Add(DepartmentInput);
            Controls.Add(UpdateButton);
            Controls.Add(DepartmentLabel);
            Controls.Add(EmailInput);
            Controls.Add(EmailLabel);
            Controls.Add(PhoneInput);
            Controls.Add(PhoneLabel);
            Controls.Add(AddressInput);
            Controls.Add(AddressLabel);
            Controls.Add(NameInput);
            Controls.Add(NameLabel);
            Controls.Add(CourseNameLabel);
            MaximizeBox = false;
            Name = "InstructorProfile";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "My Profile";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button UpdateButton;
        private Label DepartmentLabel;
        private TextBox EmailInput;
        private Label EmailLabel;
        private TextBox PhoneInput;
        private Label PhoneLabel;
        private TextBox AddressInput;
        private Label AddressLabel;
        private TextBox NameInput;
        private Label NameLabel;
        private Label CourseNameLabel;
        private TextBox DepartmentInput;
        private TextBox SalaryInput;
        private Label SalaryLabel;
        private TextBox IdInput;
    }
}