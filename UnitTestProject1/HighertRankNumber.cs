using System;
using System.Collections.Generic;
using System.Text;
using KATAA;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KATAtest
{
    [TestClass]
    public class HighertRankNumber
    {
        [TestMethod]
        public void HighestRanktest()
        {
            Assert.AreEqual(11,new HighestRankNumberInAnArray().HighestRank(new int[] { 2, 2, 2, 2, 11, 11, 11, 11, 10, 10, 10, 10, 1, 1, 1, 1 }));
        }

        [TestMethod]
        public void HighestRanktest2()
        {
            Assert.AreEqual(12, new HighestRankNumberInAnArray().HighestRank(new int[] { 12, 10, 8, 12, 7, 6, 4, 10, 12, 10 }));

        }
    }
}
