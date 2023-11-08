using System;
using System.Collections.Generic;


namespace TravelInsurance_SRP
{
    public class ConsoleMessages
    {
        public static void WelcomeMessage()
        {
            Console.WriteLine("Welcome to the Travel Insurance application!");
        }

        public static void ApplySuccessMessage()
        {
            Console.WriteLine("Congratulations! Your insurance has been applied.");
        }
        public static void EndProgramMessage()
        {
            Console.WriteLine("Press enter to close console.");
            Console.ReadLine();
        }
        public static void DisplayErrorMessages(List<string> list)
        {
            foreach (var msg in list)
                Console.WriteLine(msg);
        }
    }
}
