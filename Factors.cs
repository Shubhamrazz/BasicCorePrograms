using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpBasicCorePrograms
{
    class Factors
    {
        public static void Fac()
        {
            int i, Number;
            Console.WriteLine("Enter a number for Factor : ");
            Number = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i <= Number; i++)
            {
                if (Number % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
