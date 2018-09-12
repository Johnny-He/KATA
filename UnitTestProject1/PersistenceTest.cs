using KATAA;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace KATAtest
{
    [TestClass]
    public class PersistenceTest
    {
        [TestMethod]
        public void sample1()
        {
            Assert.AreEqual(3, new KATA34_PersistentBugger().Persistence(39));
        }

        [TestMethod]
        public void sample2()
        {
            Assert.AreEqual(1, new KATA34_PersistentBugger().Persistence(40));
        }

        [TestMethod]
        public void sample3()
        {
            Assert.AreEqual(0, new KATA34_PersistentBugger().Persistence(4));
        }

        [TestMethod]
        public void sample4()
        {
            Assert.AreEqual(2, new KATA34_PersistentBugger().Persistence(25));
        }

        [TestMethod]
        public void sample5()
        {
            Assert.AreEqual(4, new KATA34_PersistentBugger().Persistence(999));
        }
    }
}
