using KATAA;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace KATAtest
{
    [TestClass]
    public class MaximumLengthDifferenceTest
    {
        [TestMethod]
        public void MxdiflgTest()
        {
            string[] s1 = new string[] { "hoqq", "bbllkw", "oox", "ejjuyyy", "plmiis", "xxxzgpsssa", "xxwwkktt", "znnnnfqknaz", "qqquuhii", "dvvvwz" };
            string[] s2 = new string[] { "cccooommaaqqoxii", "gggqaffhhh", "tttoowwwmmww" };
            var actual = new Kata30_MaximumLengthDifference().Mxdiflg(s1,s2);
            Assert.AreEqual(13, actual);
        }

    }
}
