using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpBasicCorePrograms
{
    class SwapNumber
    {
        public int first, second, temp = 0;
        public void SwapTwo()
        {
            Console.WriteLine("please enter first number");//78
            first = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("please enter second number");//54
            second = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("BeforeSwap");
            Console.WriteLine("first {0} second {1}", first, second);
            temp = first;//temp=78;
            first = second;//first=54;
            second = temp;//second=78;
            Console.WriteLine("AfterSwap");
            Console.WriteLine("first {0} second {1}", first, second);
        }
    }
}

