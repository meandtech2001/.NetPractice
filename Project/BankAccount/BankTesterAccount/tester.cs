using System;
using System.Xml.Linq;
using BankAccount;
using BankTesterAccount;

namespace MainProgram
{
    class Atm
    {
 
        static void Main(string[] args)
        {
            var account = new AccountInfo(1,"priya sharma","pass123",50000, 9.5);//originial account info

            TestWithdraw(account, 1, "pass12", false, "Incorrect password");
            TestWithdraw(account, 1, "pass123", true, "Positive withdraw and correct password is allowed");
            TestWithdraw(account, -1, "pass123", false, "Negative withdraw should not be allowed");
            TestWithdraw(account, 1000000, "pass123", false, "Insufficient Balance");
            TestWithdraw(account, 1000000, "pass123", true, "Insufficient Balance");

            TestDeposite(account,-1,false,"Negative deposite should not be allowed");
            TestDeposite(account, 1, true, "Positive deposite is allowed");

            TestName(account,"priya singh","priya sharma", "Last name change not allowed");
            TestName(account, "riya sharma", "riya sharma", "First name can be changed");
        }

        private static void TestDeposite(AccountInfo account, int amount, bool expectedResult, string testDescription)
        {
            var actualResult = account.DepositAmountTest(amount);
            TestRepoter.Report(actualResult.ToString(),expectedResult.ToString(), testDescription);
        }

        private static void TestWithdraw(AccountInfo account, int amount,string password, bool expectedResult, string testDescription)
        {
            var actualResult = account.WithdrawAmountTest(amount,password);
            TestRepoter.Report(actualResult.ToString(), expectedResult.ToString(), testDescription);
        }

        private static void TestName(AccountInfo account,string newname,string expectedResult ,string testDescription)
        {
            account.Name=newname;
            var actualResult = account.Name;
            TestRepoter.Report(actualResult.ToString(), expectedResult.ToString(), testDescription);
        }

    }
}
