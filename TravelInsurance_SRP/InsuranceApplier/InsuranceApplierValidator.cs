using System.Collections.Generic;

namespace TravelInsurance_SRP
{
    public class InsuranceApplierValidator
    {
        public static List<string> errorMessages = new List<string>();
        public static void Validate(InsuranceApplier applier)
        {
            ValidateFirstName(applier.FirstName);
            ValidateLastName(applier.LastName);
            ValidateAge(applier.Age);

        }

        #region Private methods
        private static void ValidateFirstName(string firstName)
        {
            if (string.IsNullOrWhiteSpace(firstName))
            {
                errorMessages.Add("Invalid first name.");
            }
        }

        private static void ValidateLastName(string lastName)
        {
            if (string.IsNullOrWhiteSpace(lastName))
            {
                errorMessages.Add("Invalid last name.");
            }
        }

        private static void ValidateAge(string ageStr)
        {
            int age = 0;
            if (int.TryParse(ageStr, out age))
            {
                ValidateEligible(age);
            }
            else
            {
                errorMessages.Add("Invalid age.");
            }
        }

        private static void ValidateEligible(int age)
        {
            if (age < 18 || age > 70)
            {
                errorMessages.Add("Sorry, you are not eligible for insurance at the moment.");
            }
        } 
        #endregion
    }
}
