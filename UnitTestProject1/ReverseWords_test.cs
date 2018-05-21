using Microsoft.VisualStudio.TestTools.UnitTesting;
using KATAA;
using KATAA.KATA;

namespace KATAtest
{
    [TestClass]
    public class ReverseWordsTest
    {
        [TestMethod]
        public void ReverseWord_test()
        {
            var kataservice = new Kata26ReverseWords();
            Assert.AreEqual("CBA",kataservice.ReverseWords("ABC"));
        }
        [TestMethod]
        public void ReverseWord_test2()
        {
            var kataservice = new Kata26ReverseWords();
            Assert.AreNotEqual("CBAAA AAC bBCC", kataservice.ReverseWords("ABC AAC bBCC"));
        }
        [TestMethod]
        public void ReverseWord_test3()
        {
            var kataservice = new Kata26ReverseWords();
            Assert.AreNotEqual("CBAAA",kataservice.ReverseWords("ABC"));
        }
        [TestMethod]
        public void ReverseWord_test4()
        {
            var kataservice = new Kata26ReverseWords();
            Assert.AreNotEqual("CBAAA CAA CCBb", kataservice.ReverseWords("ABC AAC bBCC"));
        }

    }
}
