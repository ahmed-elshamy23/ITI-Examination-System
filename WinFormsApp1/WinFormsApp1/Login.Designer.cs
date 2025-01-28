namespace WinFormsApp1
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            UserName = new TextBox();
            UserNameLabel = new Label();
            PasswordLabel = new Label();
            LoginButton = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            Password = new TextBox();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // UserName
            // 
            UserName.Font = new Font("Segoe UI", 12F);
            UserName.Location = new Point(455, 212);
            UserName.Margin = new Padding(3, 4, 3, 4);
            UserName.Name = "UserName";
            UserName.Size = new Size(301, 34);
            UserName.TabIndex = 0;
            // 
            // UserNameLabel
            // 
            UserNameLabel.AutoSize = true;
            UserNameLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            UserNameLabel.ForeColor = Color.FromArgb(154, 51, 51);
            UserNameLabel.Location = new Point(455, 175);
            UserNameLabel.Name = "UserNameLabel";
            UserNameLabel.Size = new Size(81, 32);
            UserNameLabel.TabIndex = 1;
            UserNameLabel.Text = "Name";
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.BackColor = Color.Transparent;
            PasswordLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            PasswordLabel.ForeColor = Color.FromArgb(154, 51, 51);
            PasswordLabel.Location = new Point(455, 296);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(122, 32);
            PasswordLabel.TabIndex = 3;
            PasswordLabel.Text = "Password";
            // 
            // LoginButton
            // 
            LoginButton.BackColor = Color.FromArgb(154, 51, 51);
            LoginButton.Cursor = Cursors.Hand;
            LoginButton.FlatStyle = FlatStyle.Flat;
            LoginButton.Font = new Font("Segoe UI", 12F);
            LoginButton.ForeColor = Color.White;
            LoginButton.Location = new Point(520, 456);
            LoginButton.Margin = new Padding(3, 4, 3, 4);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(177, 51);
            LoginButton.TabIndex = 4;
            LoginButton.Text = "Login";
            LoginButton.UseVisualStyleBackColor = false;
            LoginButton.Click += LoginButton_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(154, 51, 51);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(343, 707);
            panel1.TabIndex = 7;
            // 
            // panel2
            // 
            panel2.Controls.Add(Password);
            panel2.Controls.Add(PasswordLabel);
            panel2.Controls.Add(LoginButton);
            panel2.Controls.Add(UserNameLabel);
            panel2.Controls.Add(UserName);
            panel2.ForeColor = Color.FromArgb(41, 128, 185);
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(857, 707);
            panel2.TabIndex = 0;
            panel2.Paint += panel2_Paint;
            // 
            // Password
            // 
            Password.Font = new Font("Segoe UI", 12F);
            Password.Location = new Point(455, 333);
            Password.Margin = new Padding(3, 4, 3, 4);
            Password.Name = "Password";
            Password.PasswordChar = '*';
            Password.Size = new Size(301, 34);
            Password.TabIndex = 2;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(857, 707);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ITI Examination System";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox UserName;
        private Label UserNameLabel;
        private Label PasswordLabel;
        private Button LoginButton;
        private Panel panel1;
        private Panel panel2;
		private TextBox Password;
	}
}
