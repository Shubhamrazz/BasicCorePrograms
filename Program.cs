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
            Factors.Fac();
            Quotient_Remainder.Logic();
            SwapNumber swap = new SwapTwo();
            swap.SwapTwo();
            EvenOdd.Number();
            Console.ReadLine();
        }
    }
}
