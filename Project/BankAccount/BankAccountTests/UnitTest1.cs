using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace BankAccountTests
{
    //[TestClass]
    public class UnitTest1
    {
        Math m = new Math();
        [TestMethod]
        public void addTest()
        {
            int x = 5; int y = 4;
            int result = m.add(x, y);
            if (result != x + y)
                Assert.Fail();
        }

        [TestMethod]
        public void subTest()
        {
            int x = 5; int y = 4;
            int result = m.sub(x, y);
           
                Assert.AreEqual(x - y,result);
        }
    }
}
