using System.Configuration;

namespace VAI_Project_Assignment
{
    public partial class UserProfileForm : Form
    {
        internal const string connectionStringName = "2227823LocalDB";
        private string connectionString;

        private Label lblUsername;
        private Label lblName;
        private Label lblEmailAddress;
        private Label lblPhoneNumber;

        private UserSession userSession;

        public UserProfileForm(UserSession userSession)
        {
            InitializeComponent();

            connectionString = _2227823_DBHelper.GetConnectionString(connectionStringName);
            _2227823_DBHelper dBHelper = new _2227823_DBHelper(connectionString);

            this.userSession = userSession;

            UpdateLabels();
        }

        public void UpdateLabels()
        {
            lblUsername.Text = userSession.Username;
            lblName.Text = $"{userSession.FirstName} {userSession.LastName}";
            lblEmailAddress.Text = userSession.EmailAddress;
            lblPhoneNumber.Text = userSession.PhoneNumber;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();

            this.Close();
            loginForm.Show();
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();

            this.Hide();
            mainMenu.Show();
        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            string emailAddress = userSession.EmailAddress;
            PasswordResetForm passwordResetForm = new PasswordResetForm(emailAddress);
            
            this.Hide();
            passwordResetForm.Show();
        }

        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {

        }
    }
}