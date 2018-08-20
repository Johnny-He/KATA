using System;
using System.Collections.Generic;
using System.Text;
using KATAA;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KATAtest
{
    [TestClass]
    public class ExesandOhsTest
    {
        [TestMethod]
        public void XOTest()
        {
            Assert.AreEqual(true, new Kata32_ExesandOhs().XO("xo"));
        }
        [TestMethod]
        public void XOTest2()
        {
            Assert.AreEqual(false, new Kata32_ExesandOhs().XO("xxxXXAAZZSFFQIOAZOo"));
        }
        [TestMethod]
        public void XOTest3()
        {
            Assert.AreEqual(false, new Kata32_ExesandOhs().XO("ooom"));
        }
    }
}
