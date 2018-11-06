using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Factorial1;

namespace UnitTestFactorial
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestforAvgCase()
        {
            Assert.AreEqual(Factorial.GetFactorial(5), 120);
        }

    }
}
