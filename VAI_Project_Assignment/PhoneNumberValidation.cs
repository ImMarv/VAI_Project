﻿using PhoneNumbers;

namespace VAI_Project_Assignment
{
    internal class PhoneNumberValidation
    {
        // Instance of the PhoneNumberUtil class from the libphonenumber library
        private PhoneNumberUtil phoneUtil = PhoneNumberUtil.GetInstance();
        // Returns the validity of the phone number (true or false)
        private bool isPhoneNumberValid;

        // Method for validating a phone number
        public bool IsValidPhoneNumber(string input, string countryCode)
        {
            try
            {
                // Parse the phone number
                PhoneNumber phoneNumber = phoneUtil.ParseAndKeepRawInput(input, countryCode);
                // Extracting the national significant number (input in txtPhoneNumber)
                string nationalSignificantNumber = phoneUtil.GetNationalSignificantNumber(phoneNumber);
                // Validate parsed phone number
                isPhoneNumberValid = phoneUtil.IsValidNumber(phoneNumber);
                return isPhoneNumberValid;
            }
            catch (NumberParseException)
            {
                // If the phone number isn't valid return false
                isPhoneNumberValid = false;
                return false;
            }
        }
        // Returns the validity of a phone number depending on the conditions met in the in the IsPhoneNumberValid(); method
        public bool IsPhoneNumberValid() => isPhoneNumberValid;
    }
}

