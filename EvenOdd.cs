using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpBasicCorePrograms
{
    class EvenOdd
    {
        public static void Number()
        {
            Console.WriteLine("Enter a number to check even or odd: ");
            int Value = Convert.ToInt32(Console.ReadLine());

            if (Value % 2 == 0)
            {
                Console.WriteLine("The number is Even: " + Value);
            }
            else
            {
                Console.WriteLine("The number is Odd: " + Value);
            }
        }
    }
}
