namespace VAI_Project_Assignment
{
    partial class UserProfileForm
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
            listView1 = new ListView();
            listView2 = new ListView();
            btnLogout = new Button();
            lblEmailAddress = new Label();
            lblUsername = new Label();
            lblPhoneNumber = new Label();
            lblName = new Label();
            btnDeleteAccount = new Button();
            btnResetPassword = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            panel1 = new Panel();
            btnMainMenu = new Button();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            listBox3 = new ListBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Location = new Point(412, 408);
            listView1.Name = "listView1";
            listView1.Size = new Size(607, 138);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // listView2
            // 
            listView2.Location = new Point(412, 183);
            listView2.Name = "listView2";
            listView2.Size = new Size(614, 169);
            listView2.TabIndex = 1;
            listView2.UseCompatibleStateImageBehavior = false;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(20, 512);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(112, 34);
            btnLogout.TabIndex = 2;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // lblEmailAddress
            // 
            lblEmailAddress.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblEmailAddress.Location = new Point(22, 408);
            lblEmailAddress.Name = "lblEmailAddress";
            lblEmailAddress.Size = new Size(334, 68);
            lblEmailAddress.TabIndex = 3;
            lblEmailAddress.Text = "Email Address";
            // 
            // lblUsername
            // 
            lblUsername.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblUsername.Location = new Point(22, 278);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(301, 34);
            lblUsername.TabIndex = 4;
            lblUsername.Text = "Username";
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblPhoneNumber.Location = new Point(22, 340);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(334, 28);
            lblPhoneNumber.TabIndex = 5;
            lblPhoneNumber.Text = "Phone Number";
            // 
            // lblName
            // 
            lblName.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblName.Location = new Point(22, 211);
            lblName.Name = "lblName";
            lblName.Size = new Size(301, 28);
            lblName.TabIndex = 6;
            lblName.Text = "Name";
            // 
            // btnDeleteAccount
            // 
            btnDeleteAccount.Location = new Point(201, 562);
            btnDeleteAccount.Name = "btnDeleteAccount";
            btnDeleteAccount.Size = new Size(155, 33);
            btnDeleteAccount.TabIndex = 7;
            btnDeleteAccount.Text = "Delete Account";
            btnDeleteAccount.UseVisualStyleBackColor = true;
            btnDeleteAccount.Click += btnDeleteAccount_Click;
            // 
            // btnResetPassword
            // 
            btnResetPassword.Location = new Point(20, 561);
            btnResetPassword.Name = "btnResetPassword";
            btnResetPassword.Size = new Size(155, 34);
            btnResetPassword.TabIndex = 8;
            btnResetPassword.Text = "Reset Password";
            btnResetPassword.UseVisualStyleBackColor = true;
            btnResetPassword.Click += btnResetPassword_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(20, 183);
            label1.Name = "label1";
            label1.Size = new Size(68, 28);
            label1.TabIndex = 9;
            label1.Text = "Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(20, 312);
            label2.Name = "label2";
            label2.Size = new Size(148, 28);
            label2.TabIndex = 10;
            label2.Text = "Phone Number:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(20, 250);
            label3.Name = "label3";
            label3.Size = new Size(103, 28);
            label3.TabIndex = 11;
            label3.Text = "Username:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(20, 380);
            label4.Name = "label4";
            label4.Size = new Size(138, 28);
            label4.TabIndex = 12;
            label4.Text = "Email Address:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(20, 43);
            label5.Name = "label5";
            label5.Size = new Size(209, 45);
            label5.TabIndex = 13;
            label5.Text = "Your Account";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDarkDark;
            panel1.Controls.Add(btnMainMenu);
            panel1.Controls.Add(label5);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1295, 131);
            panel1.TabIndex = 14;
            // 
            // btnMainMenu
            // 
            btnMainMenu.BackColor = SystemColors.ControlDarkDark;
            btnMainMenu.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnMainMenu.ForeColor = SystemColors.ButtonHighlight;
            btnMainMenu.Location = new Point(1051, 29);
            btnMainMenu.Name = "btnMainMenu";
            btnMainMenu.Size = new Size(218, 85);
            btnMainMenu.TabIndex = 14;
            btnMainMenu.Text = "Main Menu";
            btnMainMenu.UseVisualStyleBackColor = false;
            btnMainMenu.Click += btnMainMenu_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(412, 152);
            label6.Name = "label6";
            label6.Size = new Size(144, 28);
            label6.TabIndex = 15;
            label6.Text = "Liked Products:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(412, 377);
            label7.Name = "label7";
            label7.Size = new Size(192, 28);
            label7.TabIndex = 16;
            label7.Text = "Ratings and Reviews:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(1051, 152);
            label8.Name = "label8";
            label8.Size = new Size(139, 28);
            label8.TabIndex = 17;
            label8.Text = "Reccomended:";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(1051, 183);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(219, 104);
            listBox1.TabIndex = 18;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 25;
            listBox2.Location = new Point(1051, 312);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(219, 104);
            listBox2.TabIndex = 19;
            // 
            // listBox3
            // 
            listBox3.FormattingEnabled = true;
            listBox3.ItemHeight = 25;
            listBox3.Location = new Point(1052, 442);
            listBox3.Name = "listBox3";
            listBox3.Size = new Size(218, 104);
            listBox3.TabIndex = 20;
            // 
            // UserProfileForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(1295, 607);
            Controls.Add(listBox3);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnResetPassword);
            Controls.Add(btnDeleteAccount);
            Controls.Add(lblName);
            Controls.Add(lblPhoneNumber);
            Controls.Add(lblUsername);
            Controls.Add(lblEmailAddress);
            Controls.Add(btnLogout);
            Controls.Add(listView2);
            Controls.Add(listView1);
            Controls.Add(panel1);
            Name = "UserProfileForm";
            Text = "UserProfileForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ListView listView1;
        private ListView listView2;
        private Button btnLogout;
        private Button btnDeleteAccount;
        private Button btnResetPassword;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Panel panel1;
        private Label label6;
        private Label label7;
        private Button btnMainMenu;
        private Label label8;
        private ListBox listBox1;
        private ListBox listBox2;
        private ListBox listBox3;
    }
}