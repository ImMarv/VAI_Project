namespace VAI_Project_Assignment
{
    partial class RegistrationForm
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
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            txtPhoneNumber = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtEmailAddress = new TextBox();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            txtConfirmPassword = new TextBox();
            btnRegister = new Button();
            btnReturn = new Button();
            cboCountryCode = new ComboBox();
            SuspendLayout();
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(42, 91);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(265, 31);
            txtFirstName.TabIndex = 0;
            txtFirstName.TextChanged += txtFirstName_TextChanged;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(42, 153);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(265, 31);
            txtLastName.TabIndex = 1;
            txtLastName.TextChanged += txtLastName_TextChanged;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(129, 280);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(178, 31);
            txtPhoneNumber.TabIndex = 2;
            txtPhoneNumber.TextChanged += txtPhoneNumber_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(260, 13);
            label1.Name = "label1";
            label1.Size = new Size(117, 38);
            label1.TabIndex = 3;
            label1.Text = "Register";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 63);
            label2.Name = "label2";
            label2.Size = new Size(97, 25);
            label2.TabIndex = 4;
            label2.Text = "First Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 125);
            label3.Name = "label3";
            label3.Size = new Size(95, 25);
            label3.TabIndex = 5;
            label3.Text = "Last Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(42, 250);
            label4.Name = "label4";
            label4.Size = new Size(132, 25);
            label4.TabIndex = 6;
            label4.Text = "Phone Number";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(42, 190);
            label5.Name = "label5";
            label5.Size = new Size(124, 25);
            label5.TabIndex = 7;
            label5.Text = "Email Address";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(332, 63);
            label6.Name = "label6";
            label6.Size = new Size(91, 25);
            label6.TabIndex = 8;
            label6.Text = "Username";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(332, 125);
            label7.Name = "label7";
            label7.Size = new Size(87, 25);
            label7.TabIndex = 9;
            label7.Text = "Password";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(332, 190);
            label8.Name = "label8";
            label8.Size = new Size(156, 25);
            label8.TabIndex = 10;
            label8.Text = "Confirm Password";
            // 
            // txtEmailAddress
            // 
            txtEmailAddress.Location = new Point(42, 218);
            txtEmailAddress.Name = "txtEmailAddress";
            txtEmailAddress.Size = new Size(265, 31);
            txtEmailAddress.TabIndex = 11;
            txtEmailAddress.TextChanged += txtEmailAddress_TextChanged;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(332, 91);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(265, 31);
            txtUsername.TabIndex = 12;
            txtUsername.TextChanged += txtUsername_TextChanged;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(332, 153);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(265, 31);
            txtPassword.TabIndex = 13;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(332, 218);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.PasswordChar = '*';
            txtConfirmPassword.Size = new Size(265, 31);
            txtConfirmPassword.TabIndex = 14;
            txtConfirmPassword.TextChanged += txtConfirmPassword_TextChanged;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(332, 280);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(112, 34);
            btnRegister.TabIndex = 15;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnReturn
            // 
            btnReturn.Location = new Point(485, 280);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(112, 34);
            btnReturn.TabIndex = 16;
            btnReturn.Text = "Return";
            btnReturn.UseVisualStyleBackColor = true;
            btnReturn.Click += btnReturn_Click;
            // 
            // cboCountryCode
            // 
            cboCountryCode.DropDownWidth = 100;
            cboCountryCode.FormattingEnabled = true;
            cboCountryCode.Location = new Point(42, 278);
            cboCountryCode.Name = "cboCountryCode";
            cboCountryCode.Size = new Size(81, 33);
            cboCountryCode.TabIndex = 17;
            cboCountryCode.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(677, 353);
            Controls.Add(cboCountryCode);
            Controls.Add(btnReturn);
            Controls.Add(btnRegister);
            Controls.Add(txtConfirmPassword);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(txtEmailAddress);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPhoneNumber);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Name = "RegistrationForm";
            Text = "RegistrationForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtPhoneNumber;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtEmailAddress;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private TextBox txtConfirmPassword;
        private Button btnRegister;
        private Button btnReturn;
        private ComboBox cboCountryCode;
    }
}