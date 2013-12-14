using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RomanNumerals.src;

namespace RomanNumerals
{
    class Program
    {
        // Instantiates and runs through 4000 roman numeral conversions
        static void Main(string[] args)
        {
            for (int i = 0; i < 4000; i++)
            {
                var romanNumeral = new RomanNumeral();
                Console.WriteLine(String.Format("The roman numeral conversion for {0} is:  {1}\n", i, romanNumeral.Convert(i)));
            }
            Console.Read();
        }
    }
}
