using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpBasicCorePrograms
{
    class LeapYear
    {
        public static void Leap()
        {
            Console.WriteLine("Enter the number of years: ");
            int Varify = Convert.ToInt32(Console.ReadLine());
            /*LEAP YEAR EXPLANATION..
             * * In this if statement here this condition tell us about...
             * Leap year=365.25(5hr,48min,45sec-- 6hr)Adding that extra hours in one day in month of feb(29) every 4 yrs & due to its no exactly 6hr so,its changes..
             * BY this our calender moves forward by 18hrs of sun calender every 100 years..
             * So to fix this 18 hrs from every 100 yrs we have to remove leap yr..
             * we add that 6hrs after 400 hrs to match sun &our calender*/
            if (Varify % 400 == 0 || (Varify % 4 == 0 && Varify != 100))
            {
                Console.WriteLine("It is a leap year :" + Varify);
            }
            else
            {
                Console.WriteLine("Not a leap year :" + Varify);
            }
        }
    }
}
