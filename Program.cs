using System;

namespace CsharpBasicCorePrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Basic Core Programs");
            FlipCoin.CoinFlipCount();
            LeapYear.Leap();
            PowerOfTwo.CalcuOfPower();
            HarmonicNumber harmonic = new CalHarmonicSeries();
            harmonic.CalHarmonicSeries();
            Console.ReadLine();
        }
    }
}
