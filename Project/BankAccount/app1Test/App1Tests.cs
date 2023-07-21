using App01;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Security.Principal;

namespace App1Tests
{
    [TestClass]
    public class App1Tests
    {
        string name = "priya sharma";
        int accountNumber = 1;
        double balance = 20000;
        string password = "pass123";
        double interestRate = 9.5;
        BankAccount account;

        [TestInitialize]
        public void Setup()
        {
            account = new BankAccount(accountNumber, name, password, balance, interestRate);
        }

        [TestMethod]
        
        public void Withdraw_ShouldFailForNegativeAmount()
        {

            var result = account.Withdraw(-1, password);
            Assert.AreEqual(result, "Invalid Amount");
        }
        [TestMethod]
        public void Withdraw_ShouldFailForInvalidCredentials()
        {

            var result = account.Withdraw(1, "pass12");
            Assert.AreEqual(result, "Invalid Credentials");
        }

        [TestMethod]
        public void Withdraw_ShouldFailForInsufficientBalance()
        {

            var result = account.Withdraw(100000, password);
            Assert.AreEqual(result, "Insufficient Balance");
        }

        [TestMethod]
        public void Withdraw_ShouldSucceedInCorrectPath()
        {

            var result = account.Withdraw(100, password);
            //Assert.IsTrue(result);
            Assert.AreEqual(result, "Success");
        }
    }
}
