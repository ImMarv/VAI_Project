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
using BCrypt.Net;

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
            txtPassword.TextChanged += ValidatePassword;
            txtConfirmPassword.TextChanged += ValidateConfirmPassword;

            // Calling the validation methods once the user has clicked away from the textbox
            // This is so that they can be checked against the database once the user has finished typing
            txtEmailAddress.LostFocus += txtEmailAddress_LostFocus;
            txtPhoneNumber.LostFocus += txtPhoneNumber_LostFocus;
            txtUsername.LostFocus += txtUsername_LostFocus;

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
        // Checking if certain fields are already being used in the database (e.g., username, email address, phone number)
        private void ValidateField(TextBox textBox, string pattern, string errorMessage, string columnName, Func<string, bool> checkDatabase)
        {
            Regex regex = new Regex(pattern);

            if (!regex.IsMatch(textBox.Text))
            {
                SetError(textBox, errorMessage);
            }
            else
            {
                ClearError(textBox);
                if (checkDatabase != null && checkDatabase.Invoke(textBox.Text))
                {
                    SetError(textBox, $"{textBox.Tag} is already taken. Please choose another.");
                }
            }
        }

        // Returns true when there are no user input errors
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

        // Validating first name
        private void ValidateFirstName(object sender, EventArgs e)
        {
            ValidateField(txtFirstName, @"^(?=\S)[A-Za-z]{1,20}$",
                "Invalid first name. Please enter your details correctly.", "first_name", null);

            EnableRegisterButton();
        }

        // Validating last name
        private void ValidateLastName(object sender, EventArgs e)
        {
            ValidateField(txtLastName, @"^(?=\S)[A-Za-z]{1,20}$",
                "Invalid last name. Please enter your details correctly.", "last_name", null);

            EnableRegisterButton();
        }

        // Validating the email address
        private void txtEmailAddress_LostFocus(object sender, EventArgs e)
        {
            _2227823_DBHelper dbHelper = new _2227823_DBHelper(connectionString);
            ValidateField(txtEmailAddress, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$",
                "Invalid email address. Please enter your details correctly.", "email_address", dbHelper.IsEmailTaken);

            EnableRegisterButton();
        }

        // Method for populating the cboCountryCode combo box using libphonenumber package
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

        // Validating phone number using the libphonenumber package
        private void txtPhoneNumber_LostFocus(object sender, EventArgs e)
        {
            // Checking if the phone number is already taken
            _2227823_DBHelper dbHelper = new _2227823_DBHelper(connectionString);

            string selectedRegion = cboCountryCode.SelectedItem?.ToString();
            string countryCode = ExtractCountryCode(selectedRegion);
            string fullPhoneNumber = countryCode + txtPhoneNumber.Text;

            if (dbHelper.IsPhoneNumberTaken(fullPhoneNumber))
            {
                SetError(txtPhoneNumber, "Phone number is already taken. Please choose another.");
            }
            else
            {
                // Validating the phone number using the libphonenumber library
                if (!string.IsNullOrEmpty(fullPhoneNumber) && phoneNumberValidator.IsValidPhoneNumber(fullPhoneNumber, countryCode))
                {
                    ClearError(txtPhoneNumber);
                }
                else
                {
                    SetError(txtPhoneNumber, "Invalid phone number. Please enter your details correctly.");
                }
            }
        }

        // Extract the country code from the combo box
        private string ExtractCountryCode(string selectedRegion)
        { 
            return selectedRegion?.Split(' ').FirstOrDefault();
        }


        // Validating username
        private void txtUsername_LostFocus(object sender, EventArgs e)
        {
            // Checking if the username is already taken
            _2227823_DBHelper dbHelper = new _2227823_DBHelper(connectionString);
            ValidateField(txtUsername, @"^(?=\S)[A-Za-z0-9]*[A-Za-z][A-Za-z0-9]*(_[A-Za-z0-9]*)?(\.[A-Za-z0-9]*)?$|^.{5,20}$",
            "Invalid username. Must be 5 to 20 characters. May contain one dot or underscore followed by alphanumeric characters.", "username", dbHelper.IsUsernameTaken);

            EnableRegisterButton();
        }

        // Validating the password
        private void ValidatePassword(object sender, EventArgs e)
        {
            ValidateField(txtPassword, @"^(?=.*[A-Z])(?=.*[a-z])(?=.*\d).{8,20}$",
            "Invalid password. Must be at least 8 characters long. Must contain at least one uppercase letter. Must contain at least one lowercase letter. Must contain at least one digit. May contain special characters.", null, null);

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

        // Enabling the Regsiter button when all the fields are valid
        private void EnableRegisterButton()
        {
            btnRegister.Enabled = AreAllFieldsValid() && phoneNumberValidator.IsPhoneNumberValid();
        }


        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (AreAllFieldsValid() && phoneNumberValidator.IsPhoneNumberValid())
            {
                // Retrieve the values from textboxes
                string firstName = txtFirstName.Text;
                string lastName = txtLastName.Text;
                string emailAddress = txtEmailAddress.Text;
                string phoneNumber = cboCountryCode.SelectedItem + " " + txtPhoneNumber.Text;
                string username = txtUsername.Text;
                string password = txtPassword.Text;

                // Hash the password using the BCrypt.Net package(the salt is autogenerated)
                string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password);

                // Insert the user into the database with the hashed password
                _2227823_DBHelper dbHelper = new _2227823_DBHelper(connectionString);
                dbHelper.InsertUserData(firstName, lastName, emailAddress, phoneNumber, username, hashedPassword);

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
