namespace WinFormsApp1
{
    partial class NewStudent
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
            btn_insert = new Button();
            DeptInput = new ComboBox();
            DeptLabel = new Label();
            DateOfBirthLabel = new Label();
            AddressInput = new TextBox();
            AddressLabel = new Label();
            LastNameInput = new TextBox();
            LastNameLabel = new Label();
            FirstNameInput = new TextBox();
            FirstNameLabel = new Label();
            DobInput = new DateTimePicker();
            EmailInput = new TextBox();
            EmailLabel = new Label();
            PhoneInput = new TextBox();
            PhoneLabel = new Label();
            SuspendLayout();
            // 
            // btn_insert
            // 
            btn_insert.BackColor = Color.FromArgb(154, 51, 51);
            btn_insert.Cursor = Cursors.Hand;
            btn_insert.FlatStyle = FlatStyle.Flat;
            btn_insert.Font = new Font("Segoe UI", 12F);
            btn_insert.ForeColor = Color.White;
            btn_insert.Location = new Point(104, 536);
            btn_insert.Margin = new Padding(3, 4, 3, 4);
            btn_insert.Name = "btn_insert";
            btn_insert.Size = new Size(281, 45);
            btn_insert.TabIndex = 32;
            btn_insert.Text = "Insert";
            btn_insert.UseVisualStyleBackColor = false;
            btn_insert.Click += btn_insert_Click;
            // 
            // DeptInput
            // 
            DeptInput.AccessibleName = "";
            DeptInput.DropDownStyle = ComboBoxStyle.DropDownList;
            DeptInput.Font = new Font("Segoe UI", 12F);
            DeptInput.FormattingEnabled = true;
            DeptInput.Location = new Point(208, 456);
            DeptInput.Margin = new Padding(3, 4, 3, 4);
            DeptInput.Name = "DeptInput";
            DeptInput.Size = new Size(179, 36);
            DeptInput.TabIndex = 30;
            // 
            // DeptLabel
            // 
            DeptLabel.AutoSize = true;
            DeptLabel.Font = new Font("Segoe UI", 12F);
            DeptLabel.Location = new Point(72, 460);
            DeptLabel.Name = "DeptLabel";
            DeptLabel.Size = new Size(126, 28);
            DeptLabel.TabIndex = 23;
            DeptLabel.Text = "Department :";
            // 
            // DateOfBirthLabel
            // 
            DateOfBirthLabel.AutoSize = true;
            DateOfBirthLabel.Font = new Font("Segoe UI", 12F);
            DateOfBirthLabel.Location = new Point(72, 283);
            DateOfBirthLabel.Name = "DateOfBirthLabel";
            DateOfBirthLabel.Size = new Size(126, 28);
            DateOfBirthLabel.TabIndex = 21;
            DateOfBirthLabel.Text = "Date of Birth:";
            // 
            // AddressInput
            // 
            AddressInput.Font = new Font("Segoe UI", 12F);
            AddressInput.Location = new Point(210, 211);
            AddressInput.Margin = new Padding(3, 4, 3, 4);
            AddressInput.Name = "AddressInput";
            AddressInput.Size = new Size(179, 34);
            AddressInput.TabIndex = 20;
            // 
            // AddressLabel
            // 
            AddressLabel.AutoSize = true;
            AddressLabel.Font = new Font("Segoe UI", 12F);
            AddressLabel.Location = new Point(88, 215);
            AddressLabel.Name = "AddressLabel";
            AddressLabel.Size = new Size(86, 28);
            AddressLabel.TabIndex = 19;
            AddressLabel.Text = "Address:";
            // 
            // LastNameInput
            // 
            LastNameInput.Font = new Font("Segoe UI", 12F);
            LastNameInput.Location = new Point(210, 143);
            LastNameInput.Margin = new Padding(3, 4, 3, 4);
            LastNameInput.Name = "LastNameInput";
            LastNameInput.Size = new Size(179, 34);
            LastNameInput.TabIndex = 18;
            // 
            // LastNameLabel
            // 
            LastNameLabel.AutoSize = true;
            LastNameLabel.Font = new Font("Segoe UI", 12F);
            LastNameLabel.Location = new Point(82, 147);
            LastNameLabel.Name = "LastNameLabel";
            LastNameLabel.Size = new Size(107, 28);
            LastNameLabel.TabIndex = 17;
            LastNameLabel.Text = "Last Name:";
            // 
            // FirstNameInput
            // 
            FirstNameInput.Font = new Font("Segoe UI", 12F);
            FirstNameInput.Location = new Point(210, 76);
            FirstNameInput.Margin = new Padding(3, 4, 3, 4);
            FirstNameInput.Name = "FirstNameInput";
            FirstNameInput.Size = new Size(179, 34);
            FirstNameInput.TabIndex = 16;
            // 
            // FirstNameLabel
            // 
            FirstNameLabel.AutoSize = true;
            FirstNameLabel.Font = new Font("Segoe UI", 12F);
            FirstNameLabel.Location = new Point(80, 80);
            FirstNameLabel.Name = "FirstNameLabel";
            FirstNameLabel.Size = new Size(110, 28);
            FirstNameLabel.TabIndex = 15;
            FirstNameLabel.Text = "First Name:";
            // 
            // DobInput
            // 
            DobInput.Location = new Point(208, 284);
            DobInput.Name = "DobInput";
            DobInput.Size = new Size(179, 27);
            DobInput.TabIndex = 24;
            // 
            // EmailInput
            // 
            EmailInput.Font = new Font("Segoe UI", 12F);
            EmailInput.Location = new Point(208, 400);
            EmailInput.Margin = new Padding(3, 4, 3, 4);
            EmailInput.Name = "EmailInput";
            EmailInput.Size = new Size(179, 34);
            EmailInput.TabIndex = 28;
            // 
            // EmailLabel
            // 
            EmailLabel.AutoSize = true;
            EmailLabel.Font = new Font("Segoe UI", 12F);
            EmailLabel.Location = new Point(100, 404);
            EmailLabel.Name = "EmailLabel";
            EmailLabel.Size = new Size(63, 28);
            EmailLabel.TabIndex = 29;
            EmailLabel.Text = "Email:";
            // 
            // PhoneInput
            // 
            PhoneInput.Font = new Font("Segoe UI", 12F);
            PhoneInput.Location = new Point(208, 340);
            PhoneInput.Margin = new Padding(3, 4, 3, 4);
            PhoneInput.Name = "PhoneInput";
            PhoneInput.Size = new Size(179, 34);
            PhoneInput.TabIndex = 26;
            // 
            // PhoneLabel
            // 
            PhoneLabel.AutoSize = true;
            PhoneLabel.Font = new Font("Segoe UI", 12F);
            PhoneLabel.Location = new Point(96, 344);
            PhoneLabel.Name = "PhoneLabel";
            PhoneLabel.Size = new Size(71, 28);
            PhoneLabel.TabIndex = 27;
            PhoneLabel.Text = "Phone:";
            // 
            // NewStudent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(467, 640);
            Controls.Add(EmailInput);
            Controls.Add(EmailLabel);
            Controls.Add(PhoneInput);
            Controls.Add(PhoneLabel);
            Controls.Add(DobInput);
            Controls.Add(btn_insert);
            Controls.Add(DeptInput);
            Controls.Add(DeptLabel);
            Controls.Add(DateOfBirthLabel);
            Controls.Add(AddressInput);
            Controls.Add(AddressLabel);
            Controls.Add(LastNameInput);
            Controls.Add(LastNameLabel);
            Controls.Add(FirstNameInput);
            Controls.Add(FirstNameLabel);
            MaximizeBox = false;
            Name = "NewStudent";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "New Student";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_insert;
        private ComboBox DeptInput;
        private Label DeptLabel;
        private Label DateOfBirthLabel;
        private TextBox AddressInput;
        private Label AddressLabel;
        private TextBox LastNameInput;
        private Label LastNameLabel;
        private TextBox FirstNameInput;
        private Label FirstNameLabel;
        private DateTimePicker DobInput;
        private TextBox EmailInput;
        private Label EmailLabel;
        private TextBox PhoneInput;
        private Label PhoneLabel;
    }
}