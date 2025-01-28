namespace WinFormsApp1
{
    partial class StartExam
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
            components = new System.ComponentModel.Container();
            PanelQuestion = new Panel();
            SubmitButton = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            timeLabel = new Label();
            Back = new Button();
            SuspendLayout();
            // 
            // PanelQuestion
            // 
            PanelQuestion.Location = new Point(21, 80);
            PanelQuestion.Name = "PanelQuestion";
            PanelQuestion.Size = new Size(1236, 512);
            PanelQuestion.TabIndex = 51;
            // 
            // SubmitButton
            // 
            SubmitButton.BackColor = Color.FromArgb(154, 51, 51);
            SubmitButton.Cursor = Cursors.Hand;
            SubmitButton.FlatStyle = FlatStyle.Flat;
            SubmitButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SubmitButton.ForeColor = Color.White;
            SubmitButton.Location = new Point(1104, 624);
            SubmitButton.Margin = new Padding(3, 4, 3, 4);
            SubmitButton.Name = "SubmitButton";
            SubmitButton.Size = new Size(125, 49);
            SubmitButton.TabIndex = 53;
            SubmitButton.Text = "Submit";
            SubmitButton.UseVisualStyleBackColor = false;
            SubmitButton.Click += SubmitButton_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // timeLabel
            // 
            timeLabel.AutoSize = true;
            timeLabel.Font = new Font("Segoe UI", 18F);
            timeLabel.Location = new Point(600, 16);
            timeLabel.Name = "timeLabel";
            timeLabel.Size = new Size(73, 41);
            timeLabel.TabIndex = 54;
            timeLabel.Text = "--:--";
            // 
            // Back
            // 
            Back.BackColor = Color.FromArgb(154, 51, 51);
            Back.Cursor = Cursors.Hand;
            Back.FlatStyle = FlatStyle.Flat;
            Back.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Back.ForeColor = Color.White;
            Back.Location = new Point(24, 24);
            Back.Margin = new Padding(3, 4, 3, 4);
            Back.Name = "Back";
            Back.Size = new Size(80, 33);
            Back.TabIndex = 55;
            Back.Text = "BACK";
            Back.UseVisualStyleBackColor = false;
            Back.Click += Back_Click;
            // 
            // StartExam
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1279, 704);
            Controls.Add(Back);
            Controls.Add(timeLabel);
            Controls.Add(SubmitButton);
            Controls.Add(PanelQuestion);
            MaximizeBox = false;
            Name = "StartExam";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Exam";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private int timeLeft;
        private Panel PanelQuestion;
        private Button SubmitButton;
        private System.Windows.Forms.Timer timer1;
        private Label timeLabel;
        private Button Back;
    }
}