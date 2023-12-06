using System.Net.Mail;
using System.Net;
using System.Configuration;

namespace VAI_Project_Assignment
{
    public partial class ForgotPasswordForm : Form
    {
        string verificationCode;

        private string connectionString;
        internal const string connectionStringName = "VAI_Project_Assignment.Properties.Settings.DBConnectionString"; 

        private string userEmail;
        public ForgotPasswordForm()
        {
            InitializeComponent();
            connectionString = _2227823_DBHelper.GetConnectionString(connectionStringName);
        }

        private string GenerateVerificationCode()
        {
            Random generatedCode = new Random();
            return generatedCode.Next(100000, 999999).ToString();
        }

        private void btnEmailVerificationCode_Click(object sender, EventArgs e)
        {
            userEmail = txtEmailAddress.Text.Trim();
            _2227823_DBHelper dbHelper = new _2227823_DBHelper(connectionString);

            if (!dbHelper.IsEmailInDatabase(userEmail))
            {
                MessageBox.Show("Email address not found. Please enter a valid email address.");
                return;
            }

            verificationCode = GenerateVerificationCode();

            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                Credentials = new NetworkCredential("sysadm2227823@gmail.com", "ovss riak tjxi twwt"),
                EnableSsl = true,
            };

            MailMessage mailMessage = new MailMessage
            {
                From = new MailAddress("sysadm2227823@gmail.com"),
                Subject = "Verification Code",
                Body = $"Your verification code is: {verificationCode}",
            };

            mailMessage.To.Add(userEmail);

            smtpClient.Send(mailMessage);

            MessageBox.Show("Check your email and enter the verification code below.");
        }

        private void btnConfirmEmailVerificationCode_Click(object sender, EventArgs e)
        {
            if (txtVerifyCode.Text == verificationCode)
            {
                PasswordResetForm passwordResetForm = new PasswordResetForm(userEmail);
                this.Close();
                passwordResetForm.Show();
            }
            else
            {
                MessageBox.Show("Invalid verification code. Please try again.");
            }
        }
    }
}




