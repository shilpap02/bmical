using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AppUnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [TestCategory("UnitTest")]
        public void TestMethod1()
        {
            var a = 1;
            var b = 1;
            var c = a + b;
            Assert.AreEqual(c, 2);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        public void TestMethod2()
        {
            var a = 1;
            var b = 2;
            var c = a + b;
            Assert.AreEqual(c, 3);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        public void TestMethod3()
        {
            var a = 1;
            var b = 3;
            var c = a + b;
            Assert.AreEqual(c, 4);
        }
    }
}
