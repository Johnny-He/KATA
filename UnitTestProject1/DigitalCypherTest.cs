using System;
using System.Collections.Generic;
using System.Text;
using KATAA;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KATAtest
{
    [TestClass]
    public class DigitalCypherTest
    {
        [TestMethod]
        public void EncodeTest()
        {
            var actual = new Kata31_DigitalCypher().Encode("scout", 1939);
            CollectionAssert.AreEqual(new int[] { 20, 12, 18, 30, 21 },actual);
        }
        [TestMethod]
        public void EncodeTest2()
        {
            var actual = new Kata31_DigitalCypher().Encode("abcdef", 1234567);
            CollectionAssert.AreEqual(new int[] { 2,4,6,8,10,12 }, actual);
        }
    }
}
