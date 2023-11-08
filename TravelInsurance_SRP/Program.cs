using System.Linq;

namespace TravelInsurance_SRP
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ConsoleMessages.WelcomeMessage();

            
            InsuranceApplier applier = InsuranceApplierDataCapture.Capture();

            InsuranceApplierValidator.Validate(applier);
            if (InsuranceApplierValidator.errorMessages.Any())
            {
                ConsoleMessages.DisplayErrorMessages(InsuranceApplierValidator.errorMessages);
                ConsoleMessages.EndProgramMessage();
                return; 
            }

            InsuranceAccount.Apply(applier);
            
            ConsoleMessages.EndProgramMessage();
        }
    }
}
