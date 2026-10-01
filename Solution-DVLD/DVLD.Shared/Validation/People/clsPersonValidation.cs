using System;
using System.IO;
using System.Text.RegularExpressions;

namespace DVLD.Shared.Validation.People
{
    public static class clsPersonValidation
    {
        public static bool ValidatePersonInfo(
            string nationalNo,
            string firstName,
            string secondName,
            string thirdName,
            string lastName,
            string gendor,
            DateTime dateOfBirth,
            string address,
            string phoneNumber,
            string email,
            short countryID,
            string notes,
            string imagePath,
            out string errorMessage)
        {
            errorMessage = string.Empty;

            if (string.IsNullOrWhiteSpace(nationalNo))
            {
                errorMessage = "National Number is required.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(firstName))
            {
                errorMessage = "First Name is required.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(secondName))
            {
                errorMessage = "Second Name is required.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(thirdName))
            {
                errorMessage = "Third Name is required.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(lastName))
            {
                errorMessage = "Last Name is required.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(address))
            {
                errorMessage = "Address is required.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(phoneNumber))
            {
                errorMessage = "Phone Number is required.";
                return false;
            }

            // 2. فحص الدولة (يجب اختيار دولة صالحة)
            if (countryID <= 0)
            {
                errorMessage = "Please select a valid Country.";
                return false;
            }

            // 3. فحص الجنس (M أو F فقط)
            if (string.IsNullOrWhiteSpace(gendor) || (gendor.ToUpper() != "M" && gendor.ToUpper() != "F"))
            {
                errorMessage = "Gendor must be either 'M' or 'F'.";
                return false;
            }

            int age = DateTime.Now.Year - dateOfBirth.Year;
            if (dateOfBirth > DateTime.Now.AddYears(-age)) age--;

            if (age < 16)
            {
                errorMessage = "Person must be at least 16 years old.";
                return false;
            }

            if (!string.IsNullOrWhiteSpace(email))
            {
                string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
                if (!Regex.IsMatch(email, emailPattern))
                {
                    errorMessage = "Invalid Email format.";
                    return false;
                }
            }

            if (!string.IsNullOrEmpty(notes) && notes.Length > 500)
            {
                errorMessage = "Notes cannot exceed 500 characters.";
                return false;
            }

            if (!string.IsNullOrWhiteSpace(imagePath))
            {
                if (imagePath.Length > 500)
                {
                    errorMessage = "Image path cannot exceed 500 characters.";
                    return false;
                }

                string extension = Path.GetExtension(imagePath).ToLower();
                if (extension != ".jpg" && extension != ".jpeg" && extension != ".png" && extension != ".bmp")
                {
                    errorMessage = "Image must be of type (.jpg, .jpeg, .png, .bmp).";
                    return false;
                }
            }

            return true;
        }
    }
}
