namespace WinFormsApp1
{
    partial class NewQuestion
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
            NewMcqButton = new Button();
            NewTfButton = new Button();
            SuspendLayout();
            // 
            // NewMcqButton
            // 
            NewMcqButton.BackColor = Color.FromArgb(154, 51, 51);
            NewMcqButton.Cursor = Cursors.Hand;
            NewMcqButton.FlatStyle = FlatStyle.Flat;
            NewMcqButton.ForeColor = Color.White;
            NewMcqButton.Location = new Point(64, 120);
            NewMcqButton.Margin = new Padding(3, 4, 3, 4);
            NewMcqButton.Name = "NewMcqButton";
            NewMcqButton.Size = new Size(208, 48);
            NewMcqButton.TabIndex = 48;
            NewMcqButton.Text = "MCQ";
            NewMcqButton.UseVisualStyleBackColor = false;
            NewMcqButton.Click += NewMcqButton_Click;
            // 
            // NewTfButton
            // 
            NewTfButton.BackColor = Color.FromArgb(154, 51, 51);
            NewTfButton.Cursor = Cursors.Hand;
            NewTfButton.FlatStyle = FlatStyle.Flat;
            NewTfButton.ForeColor = Color.White;
            NewTfButton.Location = new Point(352, 120);
            NewTfButton.Margin = new Padding(3, 4, 3, 4);
            NewTfButton.Name = "NewTfButton";
            NewTfButton.Size = new Size(208, 48);
            NewTfButton.TabIndex = 49;
            NewTfButton.Text = "True or False";
            NewTfButton.UseVisualStyleBackColor = false;
            NewTfButton.Click += NewTfButton_Click;
            // 
            // NewQuestion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(618, 299);
            Controls.Add(NewTfButton);
            Controls.Add(NewMcqButton);
            MaximizeBox = false;
            Name = "NewQuestion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "New Question";
            ResumeLayout(false);
        }

        #endregion

        private Button NewMcqButton;
        private Button NewTfButton;
    }
}