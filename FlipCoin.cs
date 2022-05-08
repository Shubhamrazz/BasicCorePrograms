using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpBasicCorePrograms
{
    class FlipCoin
    {
        public static void CoinFlipCount()
        {
            //Variables
            int tailCount = 0, headCount = 0;
            Random random = new Random();
            Console.WriteLine("Enter number of times to flip coin");
            int numbOfTimes = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= numbOfTimes; i++)
            {
                //Check Reandom 
                double input = random.NextDouble();
                if (input < 0.5)//Tails
                    tailCount++;
                else//Heads
                    headCount++;
            }
            Console.WriteLine("tailCount:{0} headCount{1}", tailCount, headCount);
            //now we take out percentage=(100*part)/whole
            double headPercentage = (100 * headCount) / numbOfTimes;
            double tailPercentage = (100 * tailCount) / numbOfTimes;
            Console.WriteLine("Head Percentage {0}% Tail Percentage {1}%", headPercentage, tailPercentage);
        }
    }
}
