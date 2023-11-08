using System;

namespace TravelInsurance_SRP
{
    public class InsuranceApplierDataCapture
    {
        public static InsuranceApplier Capture()
        {
            InsuranceApplier applier = new InsuranceApplier();

            applier.FirstName = CaptureFirstName();
            applier.LastName = CaptureLastName();
            applier.Age = CaptureAge();

            return applier;
        }

        #region Private methods
        private static string CaptureFirstName()
        {
            Console.Write("Enter your first name: ");
            return Console.ReadLine();
        }

        private static string CaptureLastName()
        {
            Console.Write("Enter your last name: ");
            return Console.ReadLine();
        }

        private static string CaptureAge()
        {
            Console.Write("Enter your age: ");
            return Console.ReadLine();
        } 
        #endregion
    }
}
