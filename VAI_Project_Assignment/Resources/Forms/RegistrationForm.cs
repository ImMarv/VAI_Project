using PhoneNumbers;
using System.Data;
using System.Text.RegularExpressions;
using System.Configuration;
using VAI_Project_Assignment;


namespace VAI_Project_Assignment
{
    /// <summary>
    /// This is the class for the Registration form. It allows the users to enter their credentials
    /// which includes their: first name, last name, email address, phone number, a username and a
    /// password. It uses real time validation methods along with the error provider to ensure that
    /// the users credentials meet specific criteria. It also checks if the user has been previously
    /// registered in the database. The registration button only becomes avaliable when all the input
    /// is correct. It then sends them back to the LoginForm and adds the user to the database.
    /// </summary>
    public partial class RegistrationForm : Form
    {
        /*  The connnection string for the database. It can be set to connect to any database in 
         *  the App.config file by changing the connectionStringName variable below to various 
         *  connection string names in the App.config file. */
        private const string connectionStringName = "VAI_Project_Assignment.Properties.Settings.DBConnectionString";
        private string connectionString;

        /*  Using the System.Windows.Forms.ErrorProvider class in order to indicate errors in the
         *  users input. */
        private ErrorProvider errorProvider;
        //  Initializing a new instance of the PhoneNumberValidation class.
        private PhoneNumberValidation phoneNumberValidator = new PhoneNumberValidation();

        /// <summary>
        /// Initialising an instance of the RegistrationForm class.
        /// </summary>
        public RegistrationForm()
        {
            InitializeComponent();
            //  Populating the country codes ComboBox
            PopulateCountryCodes();

            /*  Retrieving the connection string from the App.config file using the
             *  GetConnectionString(); method from the _2227823_DBHelper class and the
             *  connectionStringName variable.  */
            connectionString = _2227823_DBHelper.GetConnectionString(connectionStringName);

            //  Initializing a new instance of the ErrorProvidor
            errorProvider = new ErrorProvider();
            //  Setting the ErrorProvider to remain on the screen
            errorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;

            /*  Calling the validation methods when the user begins to type, this will validate
             *  the users input in real time with feedback from the ErrorProvidor   */
            txtFirstName.TextChanged += ValidateFirstName;
            txtLastName.TextChanged += ValidateLastName;
            txtPassword.TextChanged += ValidatePassword;
            txtConfirmPassword.TextChanged += ValidateConfirmPassword;

            /*  Calling the validation methods once the user has clicked away from the textbox. This
             *  is so that they can be checked against the database once the user has finished typing.  */
            txtEmailAddress.LostFocus += txtEmailAddress_LostFocus;
            txtPhoneNumber.LostFocus += txtPhoneNumber_LostFocus;
            txtUsername.LostFocus += txtUsername_LostFocus;

            // Initially disabling the Register button until the users input has been validated.
            btnRegister.Enabled = false;
        }

        /// <summary>
        /// Creating a method used for setting errors against Controls with the ErrorProvidor
        /// </summary>
        /// <param name="control"> e.g., TextBox, Button, ComboBox </param>
        /// <param name="errorMessage"> e.g., "Incorrect input." </param>
        private void SetError(Control control, string errorMessage)
        {
            errorProvider.SetError(control, errorMessage);
        }

        /// <summary>
        /// Creating a method for clearning the errors set by the ErrorProvidor
        /// </summary>
        /// <param name="control"> e.g., ComboBox, TextBox, Button </param>
        private void ClearError(Control control)
        {
            errorProvider.SetError(control, null);
        }


        /// <summary>
        /// Validating the Winforms textbox against patterns from the Regular Expressions library
        /// Checking if certain fields are already being used in the database (e.g., username, email
        /// address, phone number)
        /// </summary>
        /// <param name="textBox"></param>
        /// <param name="pattern"></param>
        /// <param name="errorMessage"></param>
        /// <param name="columnName"></param>
        /// <param name="checkDatabase"></param> ******************
        public void ValidateField(TextBox textBox, string pattern, string errorMessage, string columnName, Func<string, bool> checkDatabase)
        {
            //  Initializing a new instance of the Regex class using the pattern parameter.
            Regex regex = new Regex(pattern);

            /*  If the users input in the TextBox doesn't conform with the Regex pattern, the Error 
             *  Providor will display the corresponding error message.   */
            if (!regex.IsMatch(textBox.Text))
            {
                SetError(textBox, errorMessage);
            }
            else
            {
                //  Clear any Regex pattern errors
                ClearError(textBox);
                /*  If the users text matches a property that has already been inserted into the
                 *  database, the ErrorProvidor will prompt them to change their input. */
                if (checkDatabase != null && checkDatabase(textBox.Text))
                {
                    SetError(textBox, $"{textBox.Tag} is already taken. Please choose another.");
                }
            }
        }

        //  Validates individual fields by checking if an error exists for each TextBox
        private bool IsFieldValid(TextBox textBox)
        {
            return string.IsNullOrEmpty(errorProvider.GetError(textBox));
        }

        //  Validating all fields
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

        // Validating first name using the ValidateField method.
        private void ValidateFirstName(object sender, EventArgs e)
        {
            ValidateField(txtFirstName, @"^(?=\S)[A-Za-z]{1,20}$",
                "Invalid first name. Please enter your details correctly.", "first_name", null);

            EnableRegisterButton();
        }

        // Validating last name using the ValidateField method.
        private void ValidateLastName(object sender, EventArgs e)
        {
            ValidateField(txtLastName, @"^(?=\S)[A-Za-z]{1,20}$",
                "Invalid last name. Please enter your details correctly.", "last_name", null);

            EnableRegisterButton();
        }

        // Validating the email address using the ValidateField method.
        private void txtEmailAddress_LostFocus(object sender, EventArgs e)
        {
            _2227823_DBHelper dbHelper = new _2227823_DBHelper(connectionString);
            ValidateField(txtEmailAddress, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$",
                "Invalid email address. Please enter your details correctly.", "email_address", dbHelper.IsEmailInDatabase);

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

        /*  Validating phone number using the libphonenumber package along with methods from the
         *  PhoneNumberValidation class.    */
        private void txtPhoneNumber_LostFocus(object sender, EventArgs e)
        {
            //  Creating a new instance of the _2227823_DBHelper class
            _2227823_DBHelper dbHelper = new _2227823_DBHelper(connectionString);

            string selectedRegion = cboCountryCode.SelectedItem?.ToString();
            string countryCode = ExtractCountryCode(selectedRegion);
            string fullPhoneNumber = countryCode + txtPhoneNumber.Text;

            if (dbHelper.IsPhoneNumberInDatabase(fullPhoneNumber))
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
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtUsername_LostFocus(object sender, EventArgs e)
        {
            // Checking if the username is already taken
            _2227823_DBHelper dbHelper = new _2227823_DBHelper(connectionString);
            ValidateField(txtUsername, @"^(?=\S)[A-Za-z0-9]*[A-Za-z][A-Za-z0-9]*(_[A-Za-z0-9]*)?(\.[A-Za-z0-9]*)?$|^.{5,20}$",
            "Invalid username. Must be 5 to 20 characters. May contain one dot or underscore followed by alphanumeric characters.", "username", dbHelper.IsUsernameInDatabase);

            EnableRegisterButton();
        }

        // Validating the password
        // Validating the password
        private void ValidatePassword(object sender, EventArgs e)
        {
            if (!PasswordValidation.ValidatePassword(txtPassword.Text))
            {
                SetError(txtPassword, "Invalid password. Must be at least 8 characters long. Must contain at least one uppercase letter. Must contain at least one lowercase letter. Must contain at least one digit. May contain special characters.");
            }
            else
            {
                ClearError(txtPassword);
            }

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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                // The default work factor is set to 10
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReturn_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();

            this.Close();
            loginForm.Show();
        }
    }
}
