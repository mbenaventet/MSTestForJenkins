using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MSTestForJenkins
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod_Passed()
        {
            Assert.AreEqual(true, true);
        }
        [TestMethod]
        public void TestMethod_Fail()
        {
            Assert.AreEqual(true, false);
        }
    }
}
