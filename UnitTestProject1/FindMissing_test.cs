using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using KATAA;
using KATAA.KATA;

namespace KATAtest
{
    [TestClass]
    public class FindMissingTest
    {
        private KATA24_FindMissing kataservice = new KATA24_FindMissing();
        [TestMethod]
        public void FindMissing_test1()
        {
            Assert.AreEqual(6, kataservice.FindMissing(new List<int> { 2, 4, 8, 10 }));
        }
        [TestMethod]
        public void FindMissing_test2()
        {
            Assert.AreEqual(600000, kataservice.FindMissing(new List<int> { 200000, 400000, 800000, 1000000 }));
        }
    }


}
