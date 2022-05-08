using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpBasicCorePrograms
{
    class PowerOfTwo
    {
        public int num = 0;
        public static void CalcuOfPower()
        {
            Console.Write("Enter a number:");//input from User
            int num = Convert.ToInt32(Console.ReadLine());
            int result = num * num; //num*num if 2*2==4
            Console.WriteLine(result);//Op
        }
    }
}
