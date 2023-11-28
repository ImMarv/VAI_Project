using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VAI_Project_Assignment
{
    public partial class RegistrationForm : Form
    {
        // Defining contants for database connection
        internal const string ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\2227823LocalDB.mdf;Integrated Security=True;Connect Timeout=30";
        internal const string ConnectionStringName = "2227823_DBConnection";
        // Defining the Error Provider field
        private ErrorProvider errorProvider;

        public RegistrationForm()
        {
            InitializeComponent();

            // Initializing a new instance of the Error Providor
            errorProvider = new ErrorProvider();
            // Setting the Error Provider to remain on the screen
            errorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmailAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPhoneNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtConfirmPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();

            this.Hide();
            loginForm.Show();
        }

        
    }
}
