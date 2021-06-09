using Microsoft.VisualStudio.TestTools.UnitTesting;
using RocketRace;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestGuyNumberBalvir()
        {
            Factory.GetNameId("Balvir");

            Assert.AreEqual(0, Factory.GuyNumber);
        }
        [TestMethod]
        public void TestGuyNumberAnil()
        {
            Factory.GetNameId("Anil");

            Assert.AreEqual(1, Factory.GuyNumber);
        }
        [TestMethod]
        public void TestGuyNumberAl()
        {
            Factory.GetNameId("Al");

            Assert.AreEqual(2, Factory.GuyNumber);
        }
    }
}
