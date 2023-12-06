using VAI_Project_Assignment.Properties;

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
            entryViewPanel = new FlowLayoutPanel();
            adminToolsPanel = new Panel();
            searchTextBox = new TextBox();
            userProfilePicture = new PictureBox();
            userProfilePanel = new Panel();
            logoutButton = new Button();
            searchBoxPanel = new Panel();
            adminToolbox = new ComboBox();
            label1 = new Label();
            entryViewPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)userProfilePicture).BeginInit();
            userProfilePanel.SuspendLayout();
            searchBoxPanel.SuspendLayout();
            SuspendLayout();
            // 
            // entryViewPanel
            // 
            entryViewPanel.AutoScroll = true;
            entryViewPanel.BackColor = SystemColors.ControlLightLight;
            entryViewPanel.BorderStyle = BorderStyle.Fixed3D;
            entryViewPanel.Controls.Add(adminToolsPanel);
            entryViewPanel.Dock = DockStyle.Bottom;
            entryViewPanel.Location = new Point(0, 133);
            entryViewPanel.Name = "entryViewPanel";
            entryViewPanel.Size = new Size(1264, 548);
            entryViewPanel.TabIndex = 3;
            // 
            // adminToolsPanel
            // 
            adminToolsPanel.Location = new Point(3, 3);
            adminToolsPanel.Name = "adminToolsPanel";
            adminToolsPanel.Size = new Size(200, 0);
            adminToolsPanel.TabIndex = 0;
            // 
            // searchTextBox
            // 
            searchTextBox.Location = new Point(12, 9);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(257, 37);
            searchTextBox.TabIndex = 6;
            searchTextBox.TextChanged += searchTextBox_TextChanged;
            // 
            // userProfilePicture
            // 
            userProfilePicture.Image = (Image)resources("userProfilePicture.Image");
            userProfilePicture.Location = new Point(11, 12);
            userProfilePicture.Name = "userProfilePicture";
            userProfilePicture.Size = new Size(50, 50);
            userProfilePicture.SizeMode = PictureBoxSizeMode.StretchImage;
            userProfilePicture.TabIndex = 7;
            userProfilePicture.TabStop = false;
            // 
            // userProfilePanel
            // 
            userProfilePanel.AutoSize = true;
            userProfilePanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            userProfilePanel.BackColor = SystemColors.ControlDarkDark;
            userProfilePanel.Controls.Add(logoutButton);
            userProfilePanel.Controls.Add(searchBoxPanel);
            userProfilePanel.Controls.Add(label1);
            userProfilePanel.Controls.Add(userProfilePicture);
            userProfilePanel.Dock = DockStyle.Top;
            userProfilePanel.Location = new Point(0, 0);
            userProfilePanel.Name = "userProfilePanel";
            userProfilePanel.Size = new Size(1264, 130);
            userProfilePanel.TabIndex = 8;
        
            // 
            // logoutButton
            // 
            logoutButton.Location = new Point(1177, 19);
            logoutButton.Name = "logoutButton";
            logoutButton.Size = new Size(75, 37);
            logoutButton.TabIndex = 10;
            logoutButton.Text = "Log Out";
            logoutButton.UseVisualStyleBackColor = true;
            logoutButton.Click += logoutButton_Click;
            // 
            // searchBoxPanel
            // 
            searchBoxPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            searchBoxPanel.BackColor = SystemColors.ControlLight;
            searchBoxPanel.Controls.Add(adminToolbox);
            searchBoxPanel.Controls.Add(searchTextBox);
            searchBoxPanel.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            searchBoxPanel.Location = new Point(0, 80);
            searchBoxPanel.Name = "searchBoxPanel";
            searchBoxPanel.Size = new Size(1263, 47);
            searchBoxPanel.TabIndex = 9;
            // 
            // adminToolbox
            // 
            adminToolbox.FormattingEnabled = true;
            adminToolbox.Location = new Point(1131, 9);
            adminToolbox.Name = "adminToolbox";
            adminToolbox.Size = new Size(121, 38);
            adminToolbox.TabIndex = 7;
            adminToolbox.Text = "Admin";
            adminToolbox.SelectedIndexChanged += adminToolbox_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(67, 27);
            label1.Name = "label1";
            label1.Size = new Size(71, 30);
            label1.TabIndex = 8;
            label1.Text = "label1";
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(144F, 144F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1264, 681);
            Controls.Add(userProfilePanel);
            Controls.Add(entryViewPanel);
            Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5);
            MaximizeBox = false;
            Name = "MainMenu";
            Text = "Vendor Application Program - Main";
            Load += Form1_Load;
            entryViewPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)userProfilePicture).EndInit();
            userProfilePanel.ResumeLayout(false);
            userProfilePanel.PerformLayout();
            searchBoxPanel.ResumeLayout(false);
            searchBoxPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private FlowLayoutPanel entryViewPanel;
        private TextBox searchTextBox;
        private PictureBox userProfilePicture;
        private Panel userProfilePanel;
        private Panel searchBoxPanel;
        private Label label1;
        private Button logoutButton;
        private Panel adminToolsPanel;
        private ComboBox adminToolbox;
    }
}