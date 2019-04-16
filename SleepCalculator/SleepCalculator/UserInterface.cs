using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SleepCalculator
{
    public static class UserInterface
    {
        
        public static string GetStringResponse(string message)
        {
            Console.WriteLine(message);
            string result = Console.ReadLine();

            return result;
        
        }

     

        public static void PrintResult(bool deficit, decimal sleepDifference)
        {
            if (deficit == true)
            {
                Console.WriteLine("Your sleep deficit is " + sleepDifference + " hours.");
            }
            else
            {
                Console.WriteLine("you slept " + sleepDifference + " hours beyond your goal.");
            }
        }
    }
}
