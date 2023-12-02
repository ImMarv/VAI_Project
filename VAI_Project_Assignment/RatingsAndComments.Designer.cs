namespace VAI_Project_Assignment
{
    partial class RatingsAndComments
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
            this.SubmitButton = new System.Windows.Forms.Button();
            this.CommentInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Rating = new System.Windows.Forms.Label();
            this.OneStar = new System.Windows.Forms.Button();
            this.TwoStars = new System.Windows.Forms.Button();
            this.ThreeStars = new System.Windows.Forms.Button();
            this.FourStars = new System.Windows.Forms.Button();
            this.FiveStars = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(620, 390);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(75, 23);
            this.SubmitButton.TabIndex = 0;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            // 
            // CommentInput
            // 
            this.CommentInput.Location = new System.Drawing.Point(83, 170);
            this.CommentInput.Multiline = true;
            this.CommentInput.Name = "CommentInput";
            this.CommentInput.Size = new System.Drawing.Size(632, 205);
            this.CommentInput.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(396, 149);
            this.label1.TabIndex = 2;
            this.label1.Text = "Reviews";
            this.label1.UseCompatibleTextRendering = true;
            // 
            // Rating
            // 
            this.Rating.AutoSize = true;
            this.Rating.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Rating.Location = new System.Drawing.Point(495, 131);
            this.Rating.Name = "Rating";
            this.Rating.Size = new System.Drawing.Size(72, 25);
            this.Rating.TabIndex = 3;
            this.Rating.Text = "Rating :";
            this.Rating.Click += new System.EventHandler(this.Rating_Click);
            // 
            // OneStar
            // 
            this.OneStar.Location = new System.Drawing.Point(562, 132);
            this.OneStar.Name = "OneStar";
            this.OneStar.Size = new System.Drawing.Size(21, 26);
            this.OneStar.TabIndex = 4;
            this.OneStar.Text = "★";
            this.OneStar.UseVisualStyleBackColor = true;
            this.OneStar.Click += new System.EventHandler(this.button1_Click);
            // 
            // TwoStars
            // 
            this.TwoStars.Location = new System.Drawing.Point(586, 132);
            this.TwoStars.Name = "TwoStars";
            this.TwoStars.Size = new System.Drawing.Size(21, 26);
            this.TwoStars.TabIndex = 5;
            this.TwoStars.Text = "★";
            this.TwoStars.UseVisualStyleBackColor = true;
            // 
            // ThreeStars
            // 
            this.ThreeStars.Location = new System.Drawing.Point(609, 132);
            this.ThreeStars.Name = "ThreeStars";
            this.ThreeStars.Size = new System.Drawing.Size(21, 26);
            this.ThreeStars.TabIndex = 6;
            this.ThreeStars.Text = "★";
            this.ThreeStars.UseVisualStyleBackColor = true;
            // 
            // FourStars
            // 
            this.FourStars.Location = new System.Drawing.Point(632, 132);
            this.FourStars.Name = "FourStars";
            this.FourStars.Size = new System.Drawing.Size(21, 26);
            this.FourStars.TabIndex = 7;
            this.FourStars.Text = "★";
            this.FourStars.UseVisualStyleBackColor = true;
            // 
            // FiveStars
            // 
            this.FiveStars.Location = new System.Drawing.Point(655, 132);
            this.FiveStars.Name = "FiveStars";
            this.FiveStars.Size = new System.Drawing.Size(21, 26);
            this.FiveStars.TabIndex = 8;
            this.FiveStars.Text = "★";
            this.FiveStars.UseVisualStyleBackColor = true;
            // 
            // RatingsAndComments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.FiveStars);
            this.Controls.Add(this.FourStars);
            this.Controls.Add(this.ThreeStars);
            this.Controls.Add(this.TwoStars);
            this.Controls.Add(this.OneStar);
            this.Controls.Add(this.Rating);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CommentInput);
            this.Controls.Add(this.SubmitButton);
            this.Name = "RatingsAndComments";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button SubmitButton;
        private TextBox CommentInput;
        private Label label1;
        private Label Rating;
        private Button OneStar;
        private Button TwoStars;
        private Button ThreeStars;
        private Button FourStars;
        private Button FiveStars;
    }
}