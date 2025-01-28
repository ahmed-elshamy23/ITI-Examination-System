namespace WinFormsApp1
{
    partial class NewExam
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
            McqsInput = new NumericUpDown();
            McqsLabel = new Label();
            GenerateButton = new Button();
            CourseNameLabel = new Label();
            CourseBox = new ComboBox();
            TfInput = new NumericUpDown();
            TfLabel = new Label();
            MinutesInput = new NumericUpDown();
            MinutesLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)McqsInput).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TfInput).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MinutesInput).BeginInit();
            SuspendLayout();
            // 
            // McqsInput
            // 
            McqsInput.Location = new Point(160, 149);
            McqsInput.Name = "McqsInput";
            McqsInput.Size = new Size(130, 27);
            McqsInput.TabIndex = 82;
            // 
            // McqsLabel
            // 
            McqsLabel.AutoSize = true;
            McqsLabel.Font = new Font("Segoe UI", 12F);
            McqsLabel.Location = new Point(56, 147);
            McqsLabel.Name = "McqsLabel";
            McqsLabel.Size = new Size(61, 28);
            McqsLabel.TabIndex = 81;
            McqsLabel.Text = "MCQ:";
            // 
            // GenerateButton
            // 
            GenerateButton.BackColor = Color.FromArgb(154, 51, 51);
            GenerateButton.Cursor = Cursors.Hand;
            GenerateButton.FlatStyle = FlatStyle.Flat;
            GenerateButton.Font = new Font("Segoe UI", 12F);
            GenerateButton.ForeColor = Color.White;
            GenerateButton.Location = new Point(96, 360);
            GenerateButton.Margin = new Padding(3, 4, 3, 4);
            GenerateButton.Name = "GenerateButton";
            GenerateButton.Size = new Size(153, 48);
            GenerateButton.TabIndex = 78;
            GenerateButton.Text = "Generate";
            GenerateButton.UseVisualStyleBackColor = false;
            GenerateButton.Click += GenerateButton_Click;
            // 
            // CourseNameLabel
            // 
            CourseNameLabel.AutoSize = true;
            CourseNameLabel.Font = new Font("Segoe UI", 12F);
            CourseNameLabel.Location = new Point(48, 72);
            CourseNameLabel.Name = "CourseNameLabel";
            CourseNameLabel.Size = new Size(76, 28);
            CourseNameLabel.TabIndex = 77;
            CourseNameLabel.Text = "Course:";
            // 
            // CourseBox
            // 
            CourseBox.AccessibleName = "";
            CourseBox.DropDownStyle = ComboBoxStyle.DropDownList;
            CourseBox.Font = new Font("Segoe UI", 12F);
            CourseBox.FormattingEnabled = true;
            CourseBox.Location = new Point(136, 68);
            CourseBox.Margin = new Padding(3, 4, 3, 4);
            CourseBox.Name = "CourseBox";
            CourseBox.Size = new Size(179, 36);
            CourseBox.TabIndex = 76;
            // 
            // TfInput
            // 
            TfInput.Location = new Point(160, 216);
            TfInput.Name = "TfInput";
            TfInput.Size = new Size(130, 27);
            TfInput.TabIndex = 84;
            // 
            // TfLabel
            // 
            TfLabel.AutoSize = true;
            TfLabel.Font = new Font("Segoe UI", 12F);
            TfLabel.Location = new Point(40, 214);
            TfLabel.Name = "TfLabel";
            TfLabel.Size = new Size(102, 28);
            TfLabel.TabIndex = 83;
            TfLabel.Text = "True/False:";
            // 
            // MinutesInput
            // 
            MinutesInput.Location = new Point(160, 288);
            MinutesInput.Name = "MinutesInput";
            MinutesInput.Size = new Size(130, 27);
            MinutesInput.TabIndex = 86;
            // 
            // MinutesLabel
            // 
            MinutesLabel.AutoSize = true;
            MinutesLabel.Font = new Font("Segoe UI", 12F);
            MinutesLabel.Location = new Point(48, 286);
            MinutesLabel.Name = "MinutesLabel";
            MinutesLabel.Size = new Size(86, 28);
            MinutesLabel.TabIndex = 85;
            MinutesLabel.Text = "Minutes:";
            // 
            // NewExam
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(355, 460);
            Controls.Add(MinutesInput);
            Controls.Add(MinutesLabel);
            Controls.Add(TfInput);
            Controls.Add(TfLabel);
            Controls.Add(McqsInput);
            Controls.Add(McqsLabel);
            Controls.Add(GenerateButton);
            Controls.Add(CourseNameLabel);
            Controls.Add(CourseBox);
            MaximizeBox = false;
            Name = "NewExam";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "New Exam";
            ((System.ComponentModel.ISupportInitialize)McqsInput).EndInit();
            ((System.ComponentModel.ISupportInitialize)TfInput).EndInit();
            ((System.ComponentModel.ISupportInitialize)MinutesInput).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown McqsInput;
        private Label McqsLabel;
        private Button GenerateButton;
        private Label CourseNameLabel;
        private ComboBox CourseBox;
        private NumericUpDown TfInput;
        private Label TfLabel;
        private NumericUpDown MinutesInput;
        private Label MinutesLabel;
    }
}