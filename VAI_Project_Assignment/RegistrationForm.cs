using Microsoft.VisualBasic.Logging;
using PhoneNumbers;
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
    
    public partial class RegistrationForm : Form
    {
        // Defining contants for database connection
        private const string ConnectionStringName = "2227823LocalDB";
        private string connectionString;

        // Defining the Error Provider field
        private ErrorProvider errorProvider;

        // Enabling a new Phone number validator
        private PhoneNumberValidation phoneNumberValidator = new PhoneNumberValidation();

        public RegistrationForm()
        {
            InitializeComponent();
            PopulateCountryCodes();

            var connectionStringSettings = ConfigurationManager.ConnectionStrings[ConnectionStringName];
            connectionString = connectionStringSettings.ConnectionString;

            // Initializing a new instance of the Error Providor
            errorProvider = new ErrorProvider();
            // Setting the Error Provider to remain on the screen
            errorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;

            // Calling the validation methods when the user begins to type
            // This will validate the input in real time
            txtFirstName.TextChanged += ValidateFirstName;
            txtLastName.TextChanged += ValidateLastName;
            txtEmailAddress.TextChanged += ValidateEmailAddress;
            txtPhoneNumber.TextChanged += ValidatePhoneNumber;
            txtUsername.TextChanged += ValidateUsername;
            txtPassword.TextChanged += ValidatePassword;
            txtConfirmPassword.TextChanged += ValidateConfirmPassword;

            // Initially disabling the Register button until the users input validated
            btnRegister.Enabled = false;
        }

        // Methods for setting and clearing errors
        private void SetError(Control control, string errorMessage)
        {
            errorProvider.SetError(control, errorMessage);
        }

        private void ClearError(Control control)
        {
            errorProvider.SetError(control, null);
        }

        // Validating the Winforms textbox against patterns from the Regular Expressions library
        private void ValidateRequiredField(TextBox textBox, string pattern, string errorMessage)
        {
            Regex regex = new Regex(pattern);

            if (!regex.IsMatch(textBox.Text))
            {
                SetError(textBox, errorMessage);
            }
            else
            {
                ClearError(textBox);
            }
        }
        // Returns true when there are no errors
        private bool IsFieldValid(TextBox textBox)
        {
            return string.IsNullOrEmpty(errorProvider.GetError(textBox));
        }

        // Validating all fields
        private bool AreAllFieldsValid()
        {
            return IsFieldValid(txtFirstName) &&
                   IsFieldValid(txtLastName) &&
                   IsFieldValid(txtEmailAddress) &&
                   IsFieldValid(txtPhoneNumber) &&
                   IsFieldValid(txtUsername) &&
                   IsFieldValid(txtPassword) &&
                   IsFieldValid(txtConfirmPassword);
        }

        // Validating first name: cannot be null or contain whitespace, must be between 1-20 characters, only contain letters
        private void ValidateFirstName(object sender, EventArgs e)
        {
            ValidateRequiredField(txtFirstName, @"^(?=\S)[A-Za-z]{1,20}$",
                "Invalid first name. Please enter your details correctly.");
            EnableRegisterButton();
        }

        //Validating last name: cannot be null or contain whitespace, must be between 1-20 characters, only contain letters
        private void ValidateLastName(object sender, EventArgs e)
        {
            ValidateRequiredField(txtLastName, @"^(?=\S)[A-Za-z]{1,20}$",
                "Invalid last name. Please enter your details correctly");
            EnableRegisterButton();
        }

        private void ValidateEmailAddress(object sender, EventArgs e)
        {
            ValidateRequiredField(txtEmailAddress, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$",
                "Invalid email address. Please enter your details correctly.");
            EnableRegisterButton();
        }

        // Method for populating the cboCountryCode combo box
        private void PopulateCountryCodes()
        {
            var phoneNumberUtil = PhoneNumberUtil.GetInstance();
            var countries = phoneNumberUtil.GetSupportedRegions()
                                .Distinct()
                                .OrderBy(code => code)
                                .Select(code => $"+{phoneNumberUtil.GetCountryCodeForRegion(code)} {code}")
                                .ToList();

            cboCountryCode.DataSource = countries;
        }

        // Validating phone number using the libphonenumber library
        private void ValidatePhoneNumber(object sender, EventArgs e)
        {
            // Get phone number input
            string phoneNumber = txtPhoneNumber.Text;
            // Get selected region input
            string selectedRegion = cboCountryCode.SelectedItem?.ToString();
            // Returns extracted country code from region input
            string countryCode = ExtractCountryCode(selectedRegion);

            if (!string.IsNullOrEmpty(phoneNumber) && phoneNumberValidator.IsValidPhoneNumber(countryCode + phoneNumber, countryCode))
            {
                ClearError(txtPhoneNumber);
            }
            else
            {
                SetError(txtPhoneNumber, "Invalid phone number. Please enter your details correctly.");
            }

            EnableRegisterButton();
        }

        // Extract the country code from the combo box
        private string ExtractCountryCode(string selectedRegion)
        {
            return selectedRegion?.Split(' ').FirstOrDefault();
        }


        // Validating username: cannot be null or contain whitespace, must contain 5-20 letters, can contain . or _ if preceeded by characters,
        private void ValidateUsername(object sender, EventArgs e)
        {
            ValidateRequiredField(txtUsername, @"^(?=\S)[A-Za-z0-9]*[A-Za-z][A-Za-z0-9]*(_[A-Za-z0-9]*)?(\.[A-Za-z0-9]*)?$|^.{5,20}$",
                "Invalid username: " +
                "\r\nMust be 5 to 20 characters." +
                "\r\n May contain one dot or underscore followed by alphanumeric characters.");
            EnableRegisterButton();
        }

        // Validate password
        private void ValidatePassword(object sender, EventArgs e)
        {
            ValidateRequiredField(txtPassword, @"^(?=.*[A-Z])(?=.*[a-z])(?=.*\d).{8,20}$",
                "Invalid password: " +
                "\r\nMust be at least 8 characters long." +
                "\r\nMust contain at least one uppercase letter." +
                "\r\nMust contain at least one lowercase letter." +
                "\r\nMust contain at least one digit." +
                "\r\nMay contain special characters.");
            EnableRegisterButton();
        }

        // Confirms txtPassword and txtConfirmPassword match
        private void ValidateConfirmPassword(object sender, EventArgs e)
        {
            if (txtConfirmPassword.Text != txtPassword.Text)
            {
                SetError(txtConfirmPassword, "Passwords do not match.");
            }
            else
            {
                ClearError(txtConfirmPassword);
            }

            EnableRegisterButton();
        }

        // Enables the Regsiter button when all fields are valid
        private void EnableRegisterButton()
        {
            btnRegister.Enabled = AreAllFieldsValid() && phoneNumberValidator.IsPhoneNumberValid();
        }


        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (AreAllFieldsValid() && phoneNumberValidator.IsPhoneNumberValid())
            {
                // Retrieve values from textboxes
                string firstName = txtFirstName.Text;
                string lastName = txtLastName.Text;
                string emailAddress = txtEmailAddress.Text;
                string phoneNumber = cboCountryCode.SelectedItem + " " + txtPhoneNumber.Text;
                string username = txtUsername.Text;
                string password = txtPassword.Text;

                // Initialize the database helper with the connection string
                _2227823_DBHelper dbHelper = new _2227823_DBHelper(connectionString);

                // Insert the user's data into the database
                dbHelper.InsertUserData(firstName, lastName, emailAddress, phoneNumber, username, password);

                MessageBox.Show("Registration successful!");

                LoginForm loginForm = new LoginForm();

                this.Hide();
                loginForm.Show();
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();

            this.Hide();
            loginForm.Show();
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
