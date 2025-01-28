namespace WinFormsApp1
{
	partial class NewMcq
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
            InsertButton = new Button();
            QuestioonBodyLabel = new Label();
            QuestionBodyInput = new TextBox();
            Option1Input = new TextBox();
            Option1Label = new Label();
            Option2Input = new TextBox();
            Option2Label = new Label();
            Option3Input = new TextBox();
            Option3Label = new Label();
            Option4Input = new TextBox();
            Option4Label = new Label();
            MarkLabel = new Label();
            MarkInput = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)MarkInput).BeginInit();
            SuspendLayout();
            // 
            // CourseNameLabel
            // 
            CourseNameLabel.AutoSize = true;
            CourseNameLabel.Font = new Font("Segoe UI", 12F);
            CourseNameLabel.Location = new Point(32, 44);
            CourseNameLabel.Name = "CourseNameLabel";
            CourseNameLabel.Size = new Size(76, 28);
            CourseNameLabel.TabIndex = 51;
            CourseNameLabel.Text = "Course:";
            // 
            // CourseBox
            // 
            CourseBox.AccessibleName = "";
            CourseBox.DropDownStyle = ComboBoxStyle.DropDownList;
            CourseBox.Font = new Font("Segoe UI", 12F);
            CourseBox.FormattingEnabled = true;
            CourseBox.Location = new Point(120, 40);
            CourseBox.Margin = new Padding(3, 4, 3, 4);
            CourseBox.Name = "CourseBox";
            CourseBox.Size = new Size(179, 36);
            CourseBox.TabIndex = 50;
            // 
            // InsertButton
            // 
            InsertButton.BackColor = Color.FromArgb(154, 51, 51);
            InsertButton.Cursor = Cursors.Hand;
            InsertButton.FlatStyle = FlatStyle.Flat;
            InsertButton.Font = new Font("Segoe UI", 12F);
            InsertButton.ForeColor = Color.White;
            InsertButton.Location = new Point(784, 40);
            InsertButton.Margin = new Padding(3, 4, 3, 4);
            InsertButton.Name = "InsertButton";
            InsertButton.Size = new Size(153, 48);
            InsertButton.TabIndex = 52;
            InsertButton.Text = "Insert";
            InsertButton.UseVisualStyleBackColor = false;
            InsertButton.Click += InsertButton_Click;
            // 
            // QuestioonBodyLabel
            // 
            QuestioonBodyLabel.AutoSize = true;
            QuestioonBodyLabel.Font = new Font("Segoe UI", 12F);
            QuestioonBodyLabel.Location = new Point(32, 104);
            QuestioonBodyLabel.Name = "QuestioonBodyLabel";
            QuestioonBodyLabel.Size = new Size(145, 28);
            QuestioonBodyLabel.TabIndex = 55;
            QuestioonBodyLabel.Text = "Question Body:";
            // 
            // QuestionBodyInput
            // 
            QuestionBodyInput.Location = new Point(40, 144);
            QuestionBodyInput.Multiline = true;
            QuestionBodyInput.Name = "QuestionBodyInput";
            QuestionBodyInput.Size = new Size(896, 88);
            QuestionBodyInput.TabIndex = 56;
            // 
            // Option1Input
            // 
            Option1Input.Location = new Point(40, 296);
            Option1Input.Multiline = true;
            Option1Input.Name = "Option1Input";
            Option1Input.Size = new Size(896, 48);
            Option1Input.TabIndex = 58;
            // 
            // Option1Label
            // 
            Option1Label.AutoSize = true;
            Option1Label.Font = new Font("Segoe UI", 12F);
            Option1Label.Location = new Point(32, 256);
            Option1Label.Name = "Option1Label";
            Option1Label.Size = new Size(242, 28);
            Option1Label.TabIndex = 57;
            Option1Label.Text = "Option 1 (Correct Option):";
            // 
            // Option2Input
            // 
            Option2Input.Location = new Point(40, 408);
            Option2Input.Multiline = true;
            Option2Input.Name = "Option2Input";
            Option2Input.Size = new Size(896, 48);
            Option2Input.TabIndex = 60;
            // 
            // Option2Label
            // 
            Option2Label.AutoSize = true;
            Option2Label.Font = new Font("Segoe UI", 12F);
            Option2Label.Location = new Point(32, 368);
            Option2Label.Name = "Option2Label";
            Option2Label.Size = new Size(94, 28);
            Option2Label.TabIndex = 59;
            Option2Label.Text = "Option 2:";
            // 
            // Option3Input
            // 
            Option3Input.Location = new Point(40, 520);
            Option3Input.Multiline = true;
            Option3Input.Name = "Option3Input";
            Option3Input.Size = new Size(896, 48);
            Option3Input.TabIndex = 62;
            // 
            // Option3Label
            // 
            Option3Label.AutoSize = true;
            Option3Label.Font = new Font("Segoe UI", 12F);
            Option3Label.Location = new Point(32, 480);
            Option3Label.Name = "Option3Label";
            Option3Label.Size = new Size(94, 28);
            Option3Label.TabIndex = 61;
            Option3Label.Text = "Option 3:";
            // 
            // Option4Input
            // 
            Option4Input.Location = new Point(40, 632);
            Option4Input.Multiline = true;
            Option4Input.Name = "Option4Input";
            Option4Input.Size = new Size(896, 48);
            Option4Input.TabIndex = 64;
            // 
            // Option4Label
            // 
            Option4Label.AutoSize = true;
            Option4Label.Font = new Font("Segoe UI", 12F);
            Option4Label.Location = new Point(32, 592);
            Option4Label.Name = "Option4Label";
            Option4Label.Size = new Size(94, 28);
            Option4Label.TabIndex = 63;
            Option4Label.Text = "Option 4:";
            // 
            // MarkLabel
            // 
            MarkLabel.AutoSize = true;
            MarkLabel.Font = new Font("Segoe UI", 12F);
            MarkLabel.Location = new Point(432, 44);
            MarkLabel.Name = "MarkLabel";
            MarkLabel.Size = new Size(61, 28);
            MarkLabel.TabIndex = 65;
            MarkLabel.Text = "Mark:";
            // 
            // MarkInput
            // 
            MarkInput.Location = new Point(504, 48);
            MarkInput.Name = "MarkInput";
            MarkInput.Size = new Size(130, 27);
            MarkInput.TabIndex = 66;
            // 
            // NewMcq
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(977, 722);
            Controls.Add(MarkInput);
            Controls.Add(MarkLabel);
            Controls.Add(Option4Input);
            Controls.Add(Option4Label);
            Controls.Add(Option3Input);
            Controls.Add(Option3Label);
            Controls.Add(Option2Input);
            Controls.Add(Option2Label);
            Controls.Add(Option1Input);
            Controls.Add(Option1Label);
            Controls.Add(QuestionBodyInput);
            Controls.Add(QuestioonBodyLabel);
            Controls.Add(InsertButton);
            Controls.Add(CourseNameLabel);
            Controls.Add(CourseBox);
            MaximizeBox = false;
            Name = "NewMcq";
            StartPosition = FormStartPosition.CenterParent;
            Text = "New MCQ";
            ((System.ComponentModel.ISupportInitialize)MarkInput).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label CourseNameLabel;
		private ComboBox CourseBox;
		private Button InsertButton;
		private Label TypeLabel;
		private ComboBox TypeBox;
		private Label QuestioonBodyLabel;
		private TextBox QuestionBodyInput;
		private Label Option1Label;
		private TextBox Option1Input;
		private TextBox Option2Input;
		private Label Option2Label;
		private TextBox Option3Input;
		private Label Option3Label;
		private TextBox Option4Input;
		private Label Option4Label;
		private Label MarkLabel;
		private NumericUpDown MarkInput;
	}
}