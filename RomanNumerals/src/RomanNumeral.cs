using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumerals.src
{
    // Class for Roman Numerals up to 3999
    class RomanNumeral
    {
        private StringBuilder numeral = new StringBuilder();
        private Dictionary<int, string> numeralDictionary = new Dictionary<int, string>()
        {
            {1000, "M"}, {900, "CM"}, {500, "D"}, {400, "CD"}, {100, "C"}, {90, "XC"}, {50, "L"}, {40, "XL"}, {10, "X"}, {9, "IX"}, {5, "V"}, {4, "IV"}, {1, "I"}
        }; 

        internal string Convert(int numToConvert)
        {
            if (numToConvert > 0)
            {
                var numeralPair = numeralDictionary
                    .First(pair => pair.Key <= numToConvert);

                numeral.Append(numeralPair.Value);
                Convert(numToConvert -= numeralPair.Key);    
            }
            return numeral.ToString();
        }
    }
}
