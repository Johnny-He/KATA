using System;
using System.Collections.Generic;
using System.Text;
using KATAA;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KATAtest
{
    [TestClass]
    public class FindtheOddIntTest
    {
        [TestMethod]
        public void sampleTest()
        {
            Assert.AreEqual(5, new FindTheOddInt().find_it(new[] { 20, 1, -1, 2, -2, 3, 3, 5, 5, 1, 2, 4, 20, 4, -1, -2, 5 }));
        }
        [TestMethod]
        public void LongArrayTest()
        {
            Assert.AreEqual(5, new FindTheOddInt().find_it(new[] { 20, 1, -1, 2, -2, 3, 3, 5, 5, 1, 2, 4, 20, 4, -1, -2, 5, 20, 4, -1, -2, 20, 4, -1, -2, 20, 4, -1, -2, 20, 4, -1, -2, 20, 4, -1, -2 , 20, 4, -1, -2, }));
        }

        [TestMethod]
        public void ShortArrayTest()
        {
            Assert.AreEqual(0, new FindTheOddInt().find_it(new[] {0}));
        }

        [TestMethod]
        public void NothingTest()
        {
            Assert.AreEqual(-1, new FindTheOddInt().find_it(new[] { 0,0,0,0 }));
        }

    }
}
