using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SleepCalculator
{
    public class Calculator
    {
        public bool deficit;
        public int age;
        public decimal weeklySleep;
        public int sleepGoal;
        

        public void SetMemberVariables()
        {
            
            age = Convert.ToInt32(UserInterface.GetStringResponse("What is your age?"));
            for(int i = 1; i<=7;i++)
            {
                weeklySleep += Convert.ToInt32(UserInterface.GetStringResponse("Enter hours slept: "));
            }
            
        }

        internal void CalculateSleep()
        {
            SetMemberVariables();
            int hours = GetSleepByAge(age);
            int sleepGoal = GetWeeklySleepGoal(hours);
            decimal sleepDifference = GetDeficitOrSurplus(weeklySleep, sleepGoal);
            UserInterface.PrintResult(deficit, sleepDifference);
        }


        public int GetSleepByAge(int age)
        {
            int hours;
            if (age >= 0 && age <=13)
            {
                hours = 10;
            }

            else if(age >= 14 && age <=19)
            {
                hours = 9;
            }

            else
            {
                hours = 8;
            }
          
            return hours;
        }
        public int GetWeeklySleepGoal(int hours)
        {
            int sleepGoal = hours * 7;
            return sleepGoal;
        }
       
        public decimal GetDeficitOrSurplus(decimal weeklySleep, int sleepGoal)
        {
            
            decimal sleepDifference = weeklySleep - sleepGoal;
            
            if (sleepDifference < 0)
            {
                deficit = true;
            }
           
            sleepDifference = Math.Abs(sleepDifference);
            return sleepDifference;
        }
       
 
    }

}
