using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace VAI_Project_Assignment
{
    public class _2227823_DBHelper
    {
        private readonly string connectionString;

        public _2227823_DBHelper(string connectionString)
        {
            this.connectionString = connectionString;
        }

        // Method for adding a new user to the database
        public void InsertUserData(string firstName, string lastName, string emailAddress, string phoneNumber, string username, string hashedPassword)
        {
            // Each user is set to regular by default
            const string defaultUserType = "RegularUser";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Insert ContactInfo
                using (SqlCommand command = new SqlCommand("INSERT INTO ContactInfo " +
                    "(first_name, last_name, email_address, phone_number) VALUES (@FirstName, @LastName, @EmailAddress, @PhoneNumber); SELECT SCOPE_IDENTITY();", connection))
                {
                    command.Parameters.Add("@FirstName", SqlDbType.VarChar, 20).Value = firstName;
                    command.Parameters.Add("@LastName", SqlDbType.VarChar, 20).Value = lastName;
                    command.Parameters.Add("@EmailAddress", SqlDbType.VarChar, 50).Value = emailAddress;
                    command.Parameters.Add("@PhoneNumber", SqlDbType.VarChar, 16).Value = phoneNumber;

                    // Get the ContactInfo ID
                    int contactInfoId = Convert.ToInt32(command.ExecuteScalar());

                    // Insert User
                    using (SqlCommand userCommand = new SqlCommand("INSERT INTO [User] " +
                        "(Contact_Info_ID, user_type, username, password) VALUES (@ContactInfoId, @UserType, @Username, @Password)", connection))
                    {
                        userCommand.Parameters.Add("@ContactInfoId", SqlDbType.Int).Value = contactInfoId;
                        userCommand.Parameters.Add("@UserType", SqlDbType.VarChar, 20).Value = defaultUserType;
                        userCommand.Parameters.Add("@Username", SqlDbType.VarChar, 20).Value = username;
                        userCommand.Parameters.Add("@Password", SqlDbType.VarChar, 60).Value = hashedPassword; 

                        userCommand.ExecuteNonQuery();
                    }
                }
            }
        }

        // Method for authenticating a user that's loging in
        public bool AuthenticateUser(string username, string password)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("SELECT password FROM [User] WHERE username = @Username", connection))
                {
                    command.Parameters.AddWithValue("@Username", username);

                    string hashedPassword = command.ExecuteScalar() as string;

                    // Checking password against hashed password using the Bcrypt.Net package
                    if (!string.IsNullOrEmpty(hashedPassword) && BCrypt.Net.BCrypt.Verify(password, hashedPassword))
                    {
                        return true;
                    }

                    return false;
                }
            }
        }

        // Method for checking if a username is taken
        public bool IsUsernameTaken(string username)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM [User] WHERE username = @Username", connection))
                {
                    command.Parameters.AddWithValue("@Username", username);

                    int userCount = Convert.ToInt32(command.ExecuteScalar());

                    return userCount > 0;
                }
            }
        }

        // Method for checking if an email address is taken
        public bool IsEmailTaken(string emailAddress)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM [ContactInfo] WHERE email_address = @EmailAddress", connection))
                {
                    command.Parameters.AddWithValue("@EmailAddress", emailAddress);

                    int emailCount = Convert.ToInt32(command.ExecuteScalar());

                    return emailCount > 0;
                }
            }
        }

        // Method for checking if a phone number is taken
        public bool IsPhoneNumberTaken(string phoneNumber)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM [ContactInfo] WHERE phone_number = @PhoneNumber", connection))
                {
                    command.Parameters.AddWithValue("@PhoneNumber", phoneNumber);

                    int phoneCount = Convert.ToInt32(command.ExecuteScalar());

                    return phoneCount > 0;
                }
            }
        }
    }
}


