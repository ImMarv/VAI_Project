namespace VAI_Project_Assignment
{
    partial class PasswordResetForm
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
            txtNewPassword = new TextBox();
            txtConfirmNewPassword = new TextBox();
            btnResetPassword = new Button();
            lblNewPassword = new Label();
            lblConfirmNewPassword = new Label();
            SuspendLayout();
            // 
            // txtNewPassword
            // 
            txtNewPassword.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtNewPassword.Location = new Point(48, 121);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.PasswordChar = '*';
            txtNewPassword.Size = new Size(250, 31);
            txtNewPassword.TabIndex = 0;
            // 
            // txtConfirmNewPassword
            // 
            txtConfirmNewPassword.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtConfirmNewPassword.Location = new Point(48, 183);
            txtConfirmNewPassword.Name = "txtConfirmNewPassword";
            txtConfirmNewPassword.PasswordChar = '*';
            txtConfirmNewPassword.Size = new Size(250, 31);
            txtConfirmNewPassword.TabIndex = 1;
            // 
            // btnResetPassword
            // 
            btnResetPassword.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnResetPassword.Location = new Point(48, 230);
            btnResetPassword.Name = "btnResetPassword";
            btnResetPassword.Size = new Size(115, 35);
            btnResetPassword.TabIndex = 2;
            btnResetPassword.Text = "Reset Password";
            btnResetPassword.UseVisualStyleBackColor = true;
            btnResetPassword.Click += btnResetPassword_Click;
            // 
            // lblNewPassword
            // 
            lblNewPassword.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblNewPassword.AutoSize = true;
            lblNewPassword.Location = new Point(48, 93);
            lblNewPassword.Name = "lblNewPassword";
            lblNewPassword.Size = new Size(127, 25);
            lblNewPassword.TabIndex = 3;
            lblNewPassword.Text = "New Password";
            // 
            // lblConfirmNewPassword
            // 
            lblConfirmNewPassword.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblConfirmNewPassword.AutoSize = true;
            lblConfirmNewPassword.Location = new Point(48, 155);
            lblConfirmNewPassword.Name = "lblConfirmNewPassword";
            lblConfirmNewPassword.Size = new Size(196, 25);
            lblConfirmNewPassword.TabIndex = 4;
            lblConfirmNewPassword.Text = "Confirm New Password";
            // 
            // PasswordResetForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(363, 359);
            Controls.Add(lblConfirmNewPassword);
            Controls.Add(lblNewPassword);
            Controls.Add(btnResetPassword);
            Controls.Add(txtConfirmNewPassword);
            Controls.Add(txtNewPassword);
            Name = "PasswordResetForm";
            Text = "PasswordResetForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNewPassword;
        private TextBox txtConfirmNewPassword;
        private Button btnResetPassword;
        private Label lblNewPassword;
        private Label lblConfirmNewPassword;
    }
}