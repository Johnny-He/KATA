using System;
using System.Collections.Generic;
using System.Text;
using KATAA;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KATAtest
{
    [TestClass]
    public class RomanNumeralsEncoderTest
    {
        public Kata29_RomanNumeralsEncoder RomanNumeralsEncoder = new Kata29_RomanNumeralsEncoder();
        [TestMethod]
        public void RomanNumeralsEncoderTest1()
        {
            Assert.AreEqual("III", RomanNumeralsEncoder.Solution(3));
        }

        [TestMethod]
        public void RomanNumeralsEncoderTest2()
        {
            Assert.AreEqual("IV", RomanNumeralsEncoder.Solution(4));
        }

        [TestMethod]
        public void RomanNumeralsEncoderTest3()
        {
            Assert.AreEqual("IX", RomanNumeralsEncoder.Solution(9));
        }

        [TestMethod]
        public void RomanNumeralsEncoderTest4()
        {
            Assert.AreEqual("LVIII", RomanNumeralsEncoder.Solution(58));
        }

        [TestMethod]
        public void RomanNumeralsEncoderTest5()
        {
            Assert.AreEqual("MCMXCIV", RomanNumeralsEncoder.Solution(1994));
        }
    }
}
