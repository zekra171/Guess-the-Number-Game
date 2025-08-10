namespace Guess_the_Number_Game
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.feedbackLabel = new System.Windows.Forms.Label();
            this.guessTextBox = new System.Windows.Forms.TextBox();
            this.guessButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tempus Sans ITC", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(12, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(476, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Guess a number between 1 and 100:";
            // 
            // feedbackLabel
            // 
            this.feedbackLabel.AutoSize = true;
            this.feedbackLabel.Font = new System.Drawing.Font("Viner Hand ITC", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feedbackLabel.Location = new System.Drawing.Point(488, 101);
            this.feedbackLabel.Name = "feedbackLabel";
            this.feedbackLabel.Size = new System.Drawing.Size(70, 27);
            this.feedbackLabel.TabIndex = 1;
            this.feedbackLabel.Text = "label2";
            // 
            // guessTextBox
            // 
            this.guessTextBox.Location = new System.Drawing.Point(494, 62);
            this.guessTextBox.Name = "guessTextBox";
            this.guessTextBox.Size = new System.Drawing.Size(207, 24);
            this.guessTextBox.TabIndex = 2;
            // 
            // guessButton
            // 
            this.guessButton.Location = new System.Drawing.Point(508, 101);
            this.guessButton.Name = "guessButton";
            this.guessButton.Size = new System.Drawing.Size(172, 29);
            this.guessButton.TabIndex = 3;
            this.guessButton.Text = "guess";
            this.guessButton.UseVisualStyleBackColor = true;
            this.guessButton.Click += new System.EventHandler(this.guessButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(543, 177);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(96, 28);
            this.resetButton.TabIndex = 4;
            this.resetButton.Text = "reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 450);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.guessButton);
            this.Controls.Add(this.guessTextBox);
            this.Controls.Add(this.feedbackLabel);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label feedbackLabel;
        private System.Windows.Forms.TextBox guessTextBox;
        private System.Windows.Forms.Button guessButton;
        private System.Windows.Forms.Button resetButton;
    }
}

