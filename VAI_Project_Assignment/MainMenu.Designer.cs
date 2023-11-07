namespace VAI_Project_Assignment
{
    partial class MainMenu
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
            userProfilePicture = new PictureBox();
            welcomeMsgLbl = new Label();
            searchText = new TextBox();
            entryViewPanel = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)userProfilePicture).BeginInit();
            SuspendLayout();
            // 
            // userProfilePicture
            // 
            userProfilePicture.Location = new Point(12, 14);
            userProfilePicture.Name = "userProfilePicture";
            userProfilePicture.Size = new Size(50, 50);
            userProfilePicture.TabIndex = 0;
            userProfilePicture.TabStop = false;
            // 
            // welcomeMsgLbl
            // 
            welcomeMsgLbl.AutoSize = true;
            welcomeMsgLbl.Location = new Point(68, 26);
            welcomeMsgLbl.Name = "welcomeMsgLbl";
            welcomeMsgLbl.Size = new Size(63, 25);
            welcomeMsgLbl.TabIndex = 1;
            welcomeMsgLbl.Text = "label1";
            // 
            // searchText
            // 
            searchText.Location = new Point(12, 80);
            searchText.Name = "searchText";
            searchText.Size = new Size(263, 33);
            searchText.TabIndex = 2;
            // 
            // entryViewPanel
            // 
            entryViewPanel.Dock = DockStyle.Bottom;
            entryViewPanel.Location = new Point(0, 131);
            entryViewPanel.Name = "entryViewPanel";
            entryViewPanel.Size = new Size(1264, 550);
            entryViewPanel.TabIndex = 3;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 681);
            Controls.Add(entryViewPanel);
            Controls.Add(searchText);
            Controls.Add(welcomeMsgLbl);
            Controls.Add(userProfilePicture);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5);
            Name = "MainMenu";
            Text = "Vendor Application Program - Main";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)userProfilePicture).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox userProfilePicture;
        private Label welcomeMsgLbl;
        private TextBox searchText;
        private FlowLayoutPanel entryViewPanel;
    }
}