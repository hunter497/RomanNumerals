using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using RomanNumerals.src;

namespace RomanNumerals.Tests
{
    class RomanNumeralsTests
    {
        [TestFixture]
        public sealed class RomanNumeralTests
        {
            [Test]
            public void ZeroShouldConvertToEmpty()
            {
                var numeral = new RomanNumeral();
                var answer = numeral.Convert(0);

                Assert.AreEqual("", answer);
            }

            [Test]
            public void OneShouldConvertToI()
            {
                var numeral = new RomanNumeral();
                var answer = numeral.Convert(1);

                Assert.AreEqual("I", answer);
            }

            [Test]
            public void TwoShouldConvertToII()
            {
                var numeral = new RomanNumeral();
                var answer = numeral.Convert(2);

                Assert.AreEqual("II", answer);
            }

            [Test]
            public void FourShouldConvertToIV()
            {
                var numeral = new RomanNumeral();
                var answer = numeral.Convert(4);

                Assert.AreEqual("IV", answer);
            }

            [Test]
            public void SixSixSixShouldConvertToDCLXVI()
            {
                var numeral = new RomanNumeral();
                var answer = numeral.Convert(666);

                Assert.AreEqual("DCLXVI", answer);
            }

            [Test]
            public void NineteenNineNineShouldConvertToMCMXCIX()
            {
                var numeral = new RomanNumeral();
                var answer = numeral.Convert(1999);

                Assert.AreEqual("MCMXCIX", answer);
            }

            [Test]
            public void ThreeNineNineNineShouldConvertToMMMCMXCIX()
            {
                var numeral = new RomanNumeral();
                var answer = numeral.Convert(3999);

                Assert.AreEqual("MMMCMXCIX", answer);
            }
        }
    }
}
