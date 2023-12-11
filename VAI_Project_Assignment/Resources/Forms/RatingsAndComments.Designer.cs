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
            this.RatingBox = new System.Windows.Forms.ComboBox();
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
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
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
            this.label1.Location = new System.Drawing.Point(47, 7);
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
            // 
            // RatingBox
            // 
            this.RatingBox.FormattingEnabled = true;
            this.RatingBox.Items.AddRange(new object[] {
            "★",
            "★★",
            "★★★",
            "★★★★",
            "★★★★★"});
            this.RatingBox.Location = new System.Drawing.Point(573, 135);
            this.RatingBox.Name = "RatingBox";
            this.RatingBox.Size = new System.Drawing.Size(121, 23);
            this.RatingBox.TabIndex = 4;
            // 
            // RatingsAndComments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RatingBox);
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
        private ComboBox RatingBox;
    }
}