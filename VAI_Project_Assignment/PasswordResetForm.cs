using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Text.RegularExpressions;

namespace VAI_Project_Assignment
{
    public partial class PasswordResetForm : Form
    {
        private const string ConnectionStringName = "2227823LocalDB";
        private string connectionString;
        private string userEmail;

        public PasswordResetForm(string userEmail)
        {
            InitializeComponent();
            var connectionStringSettings = ConfigurationManager.ConnectionStrings[ConnectionStringName];
            connectionString = connectionStringSettings.ConnectionString;
            this.userEmail = userEmail;

        }

        private void PasswordResetForm_Load(object sender, EventArgs e)
        {

        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            string newPassword = txtNewPassword.Text;
            string confirmNewPassword = txtConfirmNewPassword.Text;

            if (newPassword != confirmNewPassword)
            {
                MessageBox.Show("Passwords do not match. Please try again.");
                return;
            }

            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(newPassword);

            _2227823_DBHelper dbHelper = new _2227823_DBHelper(connectionString);
            dbHelper.ResetPassword(userEmail, hashedPassword);

            MessageBox.Show("Password reset successful!");

            LoginForm loginForm = new LoginForm();
            this.Close();
            loginForm.Show();
        }
    }
}

