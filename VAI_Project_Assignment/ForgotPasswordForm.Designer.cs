namespace VAI_Project_Assignment
{
    partial class ForgotPasswordForm
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
            txtEmailAddress = new TextBox();
            btnEmailVerificationCode = new Button();
            txtVerifyCode = new TextBox();
            btnConfirmEmailVerificationCode = new Button();
            lblEmailAddress = new Label();
            lblVerficationCode = new Label();
            SuspendLayout();
            // 
            // txtEmailAddress
            // 
            txtEmailAddress.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtEmailAddress.Location = new Point(38, 81);
            txtEmailAddress.Name = "txtEmailAddress";
            txtEmailAddress.Size = new Size(250, 31);
            txtEmailAddress.TabIndex = 0;
            txtEmailAddress.TextChanged += txtEmailAddress_TextChanged;
            // 
            // btnEmailVerificationCode
            // 
            btnEmailVerificationCode.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnEmailVerificationCode.BackColor = SystemColors.Control;
            btnEmailVerificationCode.ForeColor = Color.Black;
            btnEmailVerificationCode.Location = new Point(38, 127);
            btnEmailVerificationCode.Name = "btnEmailVerificationCode";
            btnEmailVerificationCode.Size = new Size(115, 35);
            btnEmailVerificationCode.TabIndex = 1;
            btnEmailVerificationCode.Text = "Verify Email";
            btnEmailVerificationCode.UseVisualStyleBackColor = false;
            btnEmailVerificationCode.Click += btnEmailVerificationCode_Click;
            // 
            // txtVerifyCode
            // 
            txtVerifyCode.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtVerifyCode.Location = new Point(38, 221);
            txtVerifyCode.Name = "txtVerifyCode";
            txtVerifyCode.Size = new Size(250, 31);
            txtVerifyCode.TabIndex = 2;
            txtVerifyCode.TextChanged += txtVerifyCode_TextChanged;
            // 
            // btnConfirmEmailVerificationCode
            // 
            btnConfirmEmailVerificationCode.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnConfirmEmailVerificationCode.BackColor = SystemColors.Control;
            btnConfirmEmailVerificationCode.Location = new Point(38, 258);
            btnConfirmEmailVerificationCode.Name = "btnConfirmEmailVerificationCode";
            btnConfirmEmailVerificationCode.Size = new Size(115, 35);
            btnConfirmEmailVerificationCode.TabIndex = 3;
            btnConfirmEmailVerificationCode.Text = "Continue";
            btnConfirmEmailVerificationCode.UseVisualStyleBackColor = false;
            btnConfirmEmailVerificationCode.Click += btnConfirmEmailVerificationCode_Click;
            // 
            // lblEmailAddress
            // 
            lblEmailAddress.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblEmailAddress.AutoSize = true;
            lblEmailAddress.Location = new Point(38, 53);
            lblEmailAddress.Name = "lblEmailAddress";
            lblEmailAddress.Size = new Size(124, 25);
            lblEmailAddress.TabIndex = 4;
            lblEmailAddress.Text = "Email Address";
            lblEmailAddress.Click += label1_Click;
            // 
            // lblVerficationCode
            // 
            lblVerficationCode.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblVerficationCode.AutoSize = true;
            lblVerficationCode.Location = new Point(38, 193);
            lblVerficationCode.Name = "lblVerficationCode";
            lblVerficationCode.Size = new Size(146, 25);
            lblVerficationCode.TabIndex = 5;
            lblVerficationCode.Text = "Verification Code";
            // 
            // ForgotPasswordForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(363, 359);
            Controls.Add(lblVerficationCode);
            Controls.Add(lblEmailAddress);
            Controls.Add(btnConfirmEmailVerificationCode);
            Controls.Add(txtVerifyCode);
            Controls.Add(btnEmailVerificationCode);
            Controls.Add(txtEmailAddress);
            ForeColor = Color.Black;
            Name = "ForgotPasswordForm";
            Text = "ForgotPasswordForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtEmailAddress;
        private Button btnEmailVerificationCode;
        private TextBox txtVerifyCode;
        private Button btnConfirmEmailVerificationCode;
        private Label lblEmailAddress;
        private Label lblVerficationCode;
    }
}