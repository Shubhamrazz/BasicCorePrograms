using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpBasicCorePrograms
{
    class Quotient_Remainder
    {
        public static void Logic()
        {
            Console.WriteLine("Welcome in logic for quotient and remainder");
            Console.WriteLine("Enter Divident number: ");
            int Num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Divisor number: ");
            int divisor = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Divident: {0} Divisor: {1} ", Num, divisor);

            int Rem = Num % divisor;//logic for remainder eg:50%3 =2 or 50%10 =0
            Console.WriteLine("Remainder number is: " + Rem);

            int Quotient = Num / divisor;//logic for quotient eg:50/3 =16.66 or 50/10 =5
            Console.WriteLine("Quotient number is: " + Quotient);
        }
    }
}
