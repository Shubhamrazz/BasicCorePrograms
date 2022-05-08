using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpBasicCorePrograms
{
    class LargestAmongestThree
    {
        public static void Number()
        {
            int Number1, Number2, Number3;

            Console.WriteLine("Enter the first number: ");
            Number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            Number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the third number: ");
            Number3 = Convert.ToInt32(Console.ReadLine());

            if (Number1 > Number3)
            {
                if (Number1 > Number2)
                    Console.WriteLine("First number is greater amongs three:" + Number1);
                else
                    Console.WriteLine("Second number is greater amongs three:" + Number1);
            }
            else if (Number3 > Number2)
            {
                Console.WriteLine("Third number is greater amongs three:" + Number3);
            }
            else
            {
                Console.WriteLine("Second number is greater amongs three:" + Number2);
            }
        }
    }
}
