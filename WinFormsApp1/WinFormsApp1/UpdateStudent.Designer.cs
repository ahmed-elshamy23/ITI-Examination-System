namespace WinFormsApp1
{
    partial class UpdateStudent
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
            UpdateBox = new ComboBox();
            CourseNameLabel = new Label();
            NameInput = new TextBox();
            NameLabel = new Label();
            AddressInput = new TextBox();
            AddressLabel = new Label();
            PhoneInput = new TextBox();
            PhoneLabel = new Label();
            EmailInput = new TextBox();
            EmailLabel = new Label();
            DepartmentLabel = new Label();
            DepartmentBox = new ComboBox();
            UpdateButton = new Button();
            SuspendLayout();
            // 
            // UpdateBox
            // 
            UpdateBox.DropDownStyle = ComboBoxStyle.DropDownList;
            UpdateBox.FormattingEnabled = true;
            UpdateBox.Location = new Point(160, 48);
            UpdateBox.Name = "UpdateBox";
            UpdateBox.Size = new Size(184, 28);
            UpdateBox.TabIndex = 42;
            UpdateBox.SelectedIndexChanged += UpdateBox_SelectedIndexChanged;
            // 
            // CourseNameLabel
            // 
            CourseNameLabel.AutoSize = true;
            CourseNameLabel.Font = new Font("Segoe UI", 12F);
            CourseNameLabel.Location = new Point(64, 46);
            CourseNameLabel.Name = "CourseNameLabel";
            CourseNameLabel.Size = new Size(35, 28);
            CourseNameLabel.TabIndex = 41;
            CourseNameLabel.Text = "ID:";
            // 
            // NameInput
            // 
            NameInput.BorderStyle = BorderStyle.None;
            NameInput.Font = new Font("Segoe UI", 12F);
            NameInput.Location = new Point(160, 117);
            NameInput.Margin = new Padding(3, 4, 3, 4);
            NameInput.Name = "NameInput";
            NameInput.ReadOnly = true;
            NameInput.Size = new Size(304, 27);
            NameInput.TabIndex = 44;
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Font = new Font("Segoe UI", 12F);
            NameLabel.Location = new Point(48, 119);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(68, 28);
            NameLabel.TabIndex = 43;
            NameLabel.Text = "Name:";
            // 
            // AddressInput
            // 
            AddressInput.Font = new Font("Segoe UI", 12F);
            AddressInput.Location = new Point(160, 200);
            AddressInput.Margin = new Padding(3, 4, 3, 4);
            AddressInput.Name = "AddressInput";
            AddressInput.Size = new Size(304, 34);
            AddressInput.TabIndex = 48;
            // 
            // AddressLabel
            // 
            AddressLabel.AutoSize = true;
            AddressLabel.Font = new Font("Segoe UI", 12F);
            AddressLabel.Location = new Point(40, 202);
            AddressLabel.Name = "AddressLabel";
            AddressLabel.Size = new Size(91, 28);
            AddressLabel.TabIndex = 47;
            AddressLabel.Text = "Address: ";
            // 
            // PhoneInput
            // 
            PhoneInput.Font = new Font("Segoe UI", 12F);
            PhoneInput.Location = new Point(160, 288);
            PhoneInput.Margin = new Padding(3, 4, 3, 4);
            PhoneInput.Name = "PhoneInput";
            PhoneInput.Size = new Size(304, 34);
            PhoneInput.TabIndex = 50;
            // 
            // PhoneLabel
            // 
            PhoneLabel.AutoSize = true;
            PhoneLabel.Font = new Font("Segoe UI", 12F);
            PhoneLabel.Location = new Point(48, 290);
            PhoneLabel.Name = "PhoneLabel";
            PhoneLabel.Size = new Size(71, 28);
            PhoneLabel.TabIndex = 49;
            PhoneLabel.Text = "Phone:";
            // 
            // EmailInput
            // 
            EmailInput.Font = new Font("Segoe UI", 12F);
            EmailInput.Location = new Point(160, 368);
            EmailInput.Margin = new Padding(3, 4, 3, 4);
            EmailInput.Name = "EmailInput";
            EmailInput.Size = new Size(304, 34);
            EmailInput.TabIndex = 52;
            // 
            // EmailLabel
            // 
            EmailLabel.AutoSize = true;
            EmailLabel.Font = new Font("Segoe UI", 12F);
            EmailLabel.Location = new Point(56, 370);
            EmailLabel.Name = "EmailLabel";
            EmailLabel.Size = new Size(63, 28);
            EmailLabel.TabIndex = 51;
            EmailLabel.Text = "Email:";
            // 
            // DepartmentLabel
            // 
            DepartmentLabel.AutoSize = true;
            DepartmentLabel.Font = new Font("Segoe UI", 12F);
            DepartmentLabel.Location = new Point(32, 455);
            DepartmentLabel.Name = "DepartmentLabel";
            DepartmentLabel.Size = new Size(117, 28);
            DepartmentLabel.TabIndex = 53;
            DepartmentLabel.Text = "Department";
            // 
            // DepartmentBox
            // 
            DepartmentBox.DropDownStyle = ComboBoxStyle.DropDownList;
            DepartmentBox.FormattingEnabled = true;
            DepartmentBox.Location = new Point(160, 456);
            DepartmentBox.Name = "DepartmentBox";
            DepartmentBox.Size = new Size(184, 28);
            DepartmentBox.TabIndex = 54;
            // 
            // UpdateButton
            // 
            UpdateButton.BackColor = Color.FromArgb(154, 51, 51);
            UpdateButton.Cursor = Cursors.Hand;
            UpdateButton.FlatStyle = FlatStyle.Flat;
            UpdateButton.Font = new Font("Segoe UI", 12F);
            UpdateButton.ForeColor = Color.White;
            UpdateButton.Location = new Point(120, 536);
            UpdateButton.Margin = new Padding(3, 4, 3, 4);
            UpdateButton.Name = "UpdateButton";
            UpdateButton.Size = new Size(281, 45);
            UpdateButton.TabIndex = 55;
            UpdateButton.Text = "Update";
            UpdateButton.UseVisualStyleBackColor = false;
            UpdateButton.Click += UpdateButton_Click;
            // 
            // UpdateStudent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(507, 623);
            Controls.Add(UpdateButton);
            Controls.Add(DepartmentBox);
            Controls.Add(DepartmentLabel);
            Controls.Add(EmailInput);
            Controls.Add(EmailLabel);
            Controls.Add(PhoneInput);
            Controls.Add(PhoneLabel);
            Controls.Add(AddressInput);
            Controls.Add(AddressLabel);
            Controls.Add(NameInput);
            Controls.Add(NameLabel);
            Controls.Add(UpdateBox);
            Controls.Add(CourseNameLabel);
            MaximizeBox = false;
            Name = "UpdateStudent";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Update Student";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox UpdateBox;
        private Label CourseNameLabel;
        private TextBox NameInput;
        private Label NameLabel;
        private TextBox AddressInput;
        private Label AddressLabel;
        private TextBox PhoneInput;
        private Label PhoneLabel;
        private TextBox EmailInput;
        private Label EmailLabel;
        private Label DepartmentLabel;
        private ComboBox DepartmentBox;
        private Button UpdateButton;
    }
}