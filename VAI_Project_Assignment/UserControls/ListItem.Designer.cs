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
            entryDescriptionLabel = new Label();
            iconPanel = new Panel();
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
            entryTitleLabel.Location = new Point(106, 0);
            entryTitleLabel.Name = "entryTitleLabel";
            entryTitleLabel.Size = new Size(634, 37);
            entryTitleLabel.TabIndex = 1;
            entryTitleLabel.Text = "[Entry Title]";
            // 
            // entrySubtitleLabel
            // 
            entrySubtitleLabel.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            entrySubtitleLabel.Location = new Point(112, 37);
            entrySubtitleLabel.Name = "entrySubtitleLabel";
            entrySubtitleLabel.Size = new Size(628, 25);
            entrySubtitleLabel.TabIndex = 2;
            entrySubtitleLabel.Text = "[Entry Subtitle]";
            // 
            // entryDescriptionLabel
            // 
            entryDescriptionLabel.Location = new Point(112, 62);
            entryDescriptionLabel.Name = "entryDescriptionLabel";
            entryDescriptionLabel.Size = new Size(628, 26);
            entryDescriptionLabel.TabIndex = 3;
            entryDescriptionLabel.Text = "[Entry Description]";
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
            // ListItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(iconPanel);
            Controls.Add(entryDescriptionLabel);
            Controls.Add(entrySubtitleLabel);
            Controls.Add(entryTitleLabel);
            Name = "ListItem";
            Size = new Size(807, 100);
            ((System.ComponentModel.ISupportInitialize)entryLogoPicture).EndInit();
            iconPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox entryLogoPicture;
        private Label entryTitleLabel;
        private Label entrySubtitleLabel;
        private Label entryDescriptionLabel;
        private Panel iconPanel;
    }
}
