﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


namespace BankAccountTests
{
    //[TestClass]
    public class HelloTest
    {
        [TestMethod]
        public void Test1()
        {
            Console.WriteLine("This is Test 1");
        }

        [TestMethod]
        public void Test2()
        {
            Console.WriteLine("This is Test 2");
        }
        [TestMethod]
        public void Test3()
        {
            Console.WriteLine("This is Test 3");
        }
        [TestMethod]
        public void NotATest()
        {
            Console.WriteLine("This is Not a Test");
        }

    }
}
