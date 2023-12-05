using System.Text.RegularExpressions;

namespace VAI_Project_Assignment
{
    public static class PasswordValidation
    {
        public static bool ValidatePassword(string password)
        {
            string pattern = @"^(?=.*[A-Z])(?=.*[a-z])(?=.*\d).{8,20}$";
            return Regex.IsMatch(password, pattern);
        }
    }
}

