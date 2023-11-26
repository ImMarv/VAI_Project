namespace VAI_Project_Assignment
{
    partial class ListItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            entryLogoPicture = new PictureBox();
            entryTitleLabel = new Label();
            entrySubtitleLabel = new Label();
            iconPanel = new Panel();
            viewEntryButton = new Button();
            reviewDateLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)entryLogoPicture).BeginInit();
            iconPanel.SuspendLayout();
            SuspendLayout();
            // 
            // entryLogoPicture
            // 
            entryLogoPicture.Location = new Point(24, 24);
            entryLogoPicture.Name = "entryLogoPicture";
            entryLogoPicture.Size = new Size(50, 50);
            entryLogoPicture.TabIndex = 0;
            entryLogoPicture.TabStop = false;
            // 
            // entryTitleLabel
            // 
            entryTitleLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            entryTitleLabel.Location = new Point(106, 15);
            entryTitleLabel.Name = "entryTitleLabel";
            entryTitleLabel.Size = new Size(239, 37);
            entryTitleLabel.TabIndex = 1;
            entryTitleLabel.Text = "[Entry Title]";
            // 
            // entrySubtitleLabel
            // 
            entrySubtitleLabel.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            entrySubtitleLabel.Location = new Point(106, 52);
            entrySubtitleLabel.Name = "entrySubtitleLabel";
            entrySubtitleLabel.Size = new Size(233, 25);
            entrySubtitleLabel.TabIndex = 2;
            entrySubtitleLabel.Text = "[Entry Subtitle]";
            // 
            // iconPanel
            // 
            iconPanel.BackColor = Color.LightBlue;
            iconPanel.Controls.Add(entryLogoPicture);
            iconPanel.Location = new Point(0, 0);
            iconPanel.Name = "iconPanel";
            iconPanel.Size = new Size(100, 100);
            iconPanel.TabIndex = 4;
            // 
            // viewEntryButton
            // 
            viewEntryButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            viewEntryButton.Location = new Point(665, 24);
            viewEntryButton.Name = "viewEntryButton";
            viewEntryButton.Size = new Size(144, 50);
            viewEntryButton.TabIndex = 5;
            viewEntryButton.Text = "View Entry";
            viewEntryButton.UseVisualStyleBackColor = true;
            viewEntryButton.MouseEnter += viewEntryButton_MouseEnter;
            viewEntryButton.MouseLeave += viewEntryButton_MouseLeave;
            // 
            // reviewDateLabel
            // 
            reviewDateLabel.AutoSize = true;
            reviewDateLabel.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            reviewDateLabel.Location = new Point(106, 87);
            reviewDateLabel.Name = "reviewDateLabel";
            reviewDateLabel.Size = new Size(67, 13);
            reviewDateLabel.TabIndex = 6;
            reviewDateLabel.Text = "ReviewDate";
            reviewDateLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ListItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(reviewDateLabel);
            Controls.Add(viewEntryButton);
            Controls.Add(iconPanel);
            Controls.Add(entrySubtitleLabel);
            Controls.Add(entryTitleLabel);
            Name = "ListItem";
            Size = new Size(840, 100);
            ((System.ComponentModel.ISupportInitialize)entryLogoPicture).EndInit();
            iconPanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox entryLogoPicture;
        private Label entryTitleLabel;
        private Label entrySubtitleLabel;
        private Panel iconPanel;
        private Button viewEntryButton;
        private Label reviewDateLabel;
    }
}
