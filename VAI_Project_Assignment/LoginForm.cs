using System.Configuration;

namespace VAI_Project_Assignment
{
    /// <summary>
    /// This is the class for the Login Form.
    /// It allows users to login using a username and password.
    /// It authenticates the users credentials using methods from the _2227823_DBHelper class
    /// Users can register an account using the register button or reset their password using the
    /// forgot password button.
    /// Once a user has successfully logged in they are directed to the main menu
    /// </summary>
    public partial class LoginForm : Form
    {
        /*
            The connnection string for the database. It can be set to connect to any database in 
            the App.config file by changing the connectionStringName variable below to various 
            connection string names in the App.config file.
        */
        private string connectionString;
        internal const string connectionStringName = "2227823LocalDB";

        /// <summary>
        /// Initializing an instance of the LoginForm class
        /// </summary>
        public LoginForm()
        {
            InitializeComponent();
            
            /*
                Retrieving the connection string from the App.config file using the
                GetConnectionString(); method from the _2227823_DBHelper class and the
                connectionStringName variable.
            */
            connectionString = _2227823_DBHelper.GetConnectionString(connectionStringName);

            /*  
                Creating a local variable to store the users username so it can later be used
                to retrieve the active users data.
            */
            string username;
        }

        /// <summary>
        /// Handles the users login attempt by connecting to the database, authenticating the user
        /// and displaying any required error messages.
        /// </summary>
        /// <param name="sender"> The Login button </param>
        /// <param name="e"> The Click Event </param>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            //  Extract the users input from the textboxes
            string username = txtUsername.Text;
            string enteredPassword = txtPassword.Text;

            /*
            Creating an instance of the _2227823_DBHelper class and initializing it with the
            connection string.
            */
            _2227823_DBHelper dbHelper = new _2227823_DBHelper(connectionString);

            //  Authenticate user
            bool isAuthenticated = dbHelper.AuthenticateUser(username, enteredPassword);

            if (isAuthenticated)
            {
                //  Display a success message
                MessageBox.Show("Login successful!");

                /*MainMenu mainMenu = new MainMenu();
                this.Hide();
                mainMenu.Show();*/

                /*  Retrieve the active users data to store in the UserSession class using the
                    RetrieveUserData() method in the _2227823_DBHelper class and the authenticated
                    username.   */
                UserSession userSession = dbHelper.RetrieveUserData(username);

                /*  Pass the data from the UserSession class to a new instance of the UserProfileForm
                    to provide the correct properties for displaying the users data.    */
                UserProfileForm userProfileForm = new UserProfileForm(userSession);

                //  Hide the LoginForm and display the UserProfileForm
                this.Hide();
                userProfileForm.Show();
            }
            else
            {
                // If unsuccessful, ask the user to re-enter their details
                MessageBox.Show("Invalid username or password. Please try again.");
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegistrationForm registrationForm = new RegistrationForm();

            this.Hide();
            registrationForm.Show();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblForgotPassword_Click(object sender, EventArgs e)
        {
            ForgotPasswordForm forgotPasswordForm = new ForgotPasswordForm();

            this.Hide();
            forgotPasswordForm.Show();
        }
    }
}
