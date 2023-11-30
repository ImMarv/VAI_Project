using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace VAI_Project_Assignment
{
    public partial class LoginForm : Form
    {
        // Defining the connection string
        private string connectionString;
        internal const string ConnectionStringName = "2227823LocalDB";
        // Defining the Error Provider field
        private ErrorProvider errorProvider;

        public LoginForm()
        {
            InitializeComponent();
            // Retrive connection string from app.config
            var connectionStringSettings = ConfigurationManager.ConnectionStrings[ConnectionStringName];
            connectionString = connectionStringSettings.ConnectionString;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            // Create an instance of the DB helper
            _2227823_DBHelper dbHelper = new _2227823_DBHelper(connectionString);

            // Authenticate user
            bool isAuthenticated = dbHelper.AuthenticateUser(username, password);

            if (isAuthenticated)
            {
                // If the users authenticated display success message and send to main menu
                MessageBox.Show("Login successful!");
                MainMenu mainMenu = new MainMenu();
                this.Hide();
                mainMenu.Show();
            }
            else
            {
                // If unsucessful, ask the user to reenter their details
                MessageBox.Show("Invalid username or password. Please try again.");
            }
        }

        // Send user to the registration form
        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegistrationForm registrationForm = new RegistrationForm();

            this.Hide();
            registrationForm.Show();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
