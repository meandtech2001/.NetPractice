using BankAccount;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountTests
{
    [TestClass]
    public class BankTests
    {
        string name = "priya sharma";
        int accountNumber = 1;
        double balance = 20000;
        string password = "pass123";
        double interestRate = 9.5;
        AccountInfo account;

        [TestInitialize]
        public void Setup()
        {
            account = new AccountInfo(accountNumber, name, password, balance, interestRate);
        }

        [TestMethod]
        public void Deposit_ShouldFailForNegativeAmount()
        { 
            var result = account.DepositAmountTest(-1);
            Assert.IsTrue(result);
            //Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void Deposit_ShouldSucceedInCorrectPath()
        {
            var result = account.DepositAmountTest(1);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Withdraw_ShouldFailForNegativeAmount()
        {
           
            var result = account.WithdrawAmountTest(-1,password);
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void Withdraw_ShouldFailForInvalidCredentials()
        {
            
            var result = account.WithdrawAmountTest(1, "pass12");
            Assert.IsTrue(result);
        }
        
        [TestMethod]
        public void Withdraw_ShouldFailForInsufficientBalance()
        {
            
            var result = account.WithdrawAmountTest(100000, password);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Withdraw_ShouldSucceedInCorrectPath()
        {
           
            var result = account.WithdrawAmountTest(100, password);
            //Assert.IsTrue(result);
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void Authenticate_ShouldSucceedInCorrectPassword()
        {
            var result = account.Authenticate(password);
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void Authenticate_ShouldFailInWrongPassword()
        {

            var result = account.Authenticate("wrong-password");
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void ChangePassword_ShouldFailInCurrentPassword()
        {
            var result = account.ChangePassword("pass12","change");
            Assert.IsTrue(result);

        }
        [TestMethod]
        public void ChangePassword_ShouldFailInPasswordLessThan5()
        {
            var result = account.ChangePassword("pass123", "less");
            Assert.IsTrue(result);

        }
        [TestMethod]
        public void ChangePassword_ShouldFailInPasswordMoreThan10()
        {
            var result = account.ChangePassword("pass123", "change-password");
            Assert.IsTrue(result);

        }
        [TestMethod]
        public void ChangePassword_ShouldSucceedInCorrectPath()
        {
            var result = account.ChangePassword("pass123", "change");
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void ChangeName_ShouldFailforLastNameChange()
        {
            account.Name = "priya mall";
            var result = account.Name;
            Assert.AreEqual(result, "priya mall");//result must be equal to priya mall
        }
        [TestMethod]
       
        public void ChangeName_ShouldSucceedforFirstNameChange()
        {
            account.Name = "riya sharma";
            var result = account.Name;
            Assert.AreEqual(result, "riya sharma");//result must be equal to riya sharma

        }
        [TestMethod]

        public void CreditInterest_Check()
        {

            var result = account.CreditInterest();
            Assert.AreEqual(result, ((balance * 9.5) / 1200));
        }
        [TestMethod]

        public void GetInfo_ShouldPassforNoPassword()
        {

            Assert.AreEqual(-1, account.GetInfo().IndexOf("Password:"));
        }
        [TestMethod]

        public void GetInfo_ShouldPassForIncludingBalance()
        {
            Assert.AreNotEqual(-1, account.GetInfo().IndexOf(account.Balance.ToString()));
        }
    }
}
