using System.Configuration;
using VAI_Project_Assignment;

namespace VAI_Project_Assignment
{
    public partial class PasswordResetForm : Form
    {
        private const string connectionStringName = "2227823LocalDB";
        private string connectionString;
        private string userEmail;

        private ErrorProvider errorProvider;

        public PasswordResetForm(string userEmail)
        {
            InitializeComponent();

            connectionString = _2227823_DBHelper.GetConnectionString(connectionStringName);

            this.userEmail = userEmail;

            ErrorProvider errorProvider = new ErrorProvider();
            errorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;

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

            if (!PasswordValidation.ValidatePassword(newPassword))
            {
                errorProvider.SetError(txtNewPassword, "Invalid password. Must be at least 8 characters long. Must contain at least one uppercase letter. Must contain at least one lowercase letter. Must contain at least one digit. May contain special characters.");
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

