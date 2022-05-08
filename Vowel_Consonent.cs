using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpBasicCorePrograms
{
    class Vowel_Consonent
    {
        public static void Alphabet()
        {
            Char SingleCharacter;

            Console.WriteLine("Enter any character (A-Z or a-z) to check vowel or not: ");
            SingleCharacter = Convert.ToChar(Console.ReadLine());

            if (SingleCharacter == 'a' | SingleCharacter == 'A' | SingleCharacter == 'e' | SingleCharacter == 'E' | SingleCharacter == 'i' | SingleCharacter == 'I' | SingleCharacter == 'o' | SingleCharacter == 'O' | SingleCharacter == 'u' | SingleCharacter == 'U')
            {
                Console.WriteLine("Given letter" + "  " + SingleCharacter + "is a vowel");
            }
            else
            {
                Console.WriteLine("Given letter" + " " + SingleCharacter + "is a consonent");
            }
        }
    }
}
