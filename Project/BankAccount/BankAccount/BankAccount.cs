using System;
using System.Security.Principal;

namespace BankAccount
{

    public class AccountInfo
    {
        int accountNumber;
        string name;
        string password;
        double balance;
        double interestRate;

        public enum Status
        {
            SUCCESS, //=0
            INVALID_CREDENTIALS, //=1
            INSUFFICIENT_BALANCE, //=2
            INVALID_AMOUNT //=3
        }
        public string Name
        {
            get { return name; }

            set
            {
                if (LastName(name) == LastName(value))
                    name = value;
            }
        }
        
        private string LastName(string name)
        {
            int index = name.LastIndexOf(' ');
            if (index == -1)
                return "";
            else
                return name.Substring(index + 1);
        }

        public int AccountNumber
        {
            get { return accountNumber; }

        }

        public double Balance
        {
            get
            {
                return balance;
            }
            
        }
        private string Password
        {
            set
            {
                Encryptor encryptor = new Encryptor();
                this.password = encryptor.Encrypt(value);
            }
        }

        public bool Authenticate(string password)
        {
            Encryptor matcher = new Encryptor();

            return matcher.Match(this.password, password);
        }

        public bool ChangePassword(string confirmPassword, string newPassword)
        {
            if (Authenticate(confirmPassword) && (newPassword.Length >=5 && newPassword.Length <= 10))
            {
                Password = newPassword; //save the encrypted password
                return true;
            }
            else
            {
                return false;
            }

        }

        public AccountInfo(int accountNumber, string name, string password,double amount, double interestRate)
        {
            this.accountNumber = accountNumber;
            this.name = name;
            Password = password;//stores encrypted password
            this.balance = amount;
            this.interestRate = interestRate;

        }
        public string GetInfo()
        {
            string output = "Name: " + name + "\nAccount Number: "+ accountNumber + "\nBalance : " + balance;
            return output;

        }

        public bool DepositAmountTest(double value)
        {

            if (value < 0)
                return false;
            
            else
                return true;

        }
        public string DepositAmount(double value)
        {
            string message = "";
            
            if (value < 0)
            {
                message = "Negative number not Allowed";
                return message;
            }

            else
            {
                balance = balance + value;
                message = "Updated";
                return message;
            }

        }

        public bool WithdrawAmountTest(double value,string password)
        {
            //if (value < 0)
            //{
            //    return Status.INVALID_AMOUNT;
            //}
            //else if (value > balance)
            //{
            //    return Status.INSUFFICIENT_BALANCE;
            //}
            //else if (this.password == password)
            //{
            //    return Status.INVALID_CREDENTIALS;
            //}
            //else
            //{
            //    balance -= value;
            //    return Status.SUCCESS;
            //}

            if (Authenticate(password))
            {

                if (value < 0)
                    return false;

                else if (balance < value)
                    return false;

                else
                    return true;
            }
            else
            {
                return false;
            }

        }
        public string WithdrawAmount(string password,double value)
        {
            string message = "";
            if (this.password == password)
            {
                if (value < 0)
                {
                    message = "Negative number not Allowed";
                    return message;
                }

                else if (balance < value)
                {
                    message = "Insufficient Balance";
                    return message;
                }
                else
                {
                    balance = balance - value;
                    message = "Success";
                    return message;
                }
            }
            else
            {
                message = "Wrong Password";
                return message;
            }
        }
        public string TransferAmount(string password,double value)
        {
            string message = "";
            if (this.password == password)
            {
                if (value < 0)
                {
                    message = "Negative number not Allowed";
                    return message;
                }

                else if (balance < value)
                {
                    message = "Insufficient Balance";
                    return message;
                }
                else
                {
                    balance = balance - value;
                    message = "Success";
                    return message;
                }
            }
            else
            {
                message = "Wrong Password";
                return message;
            }
        }
        public double CreditInterest()
        {
            interestRate = (balance * 9.5) / 1200;
            balance = balance + interestRate;
            return interestRate;
        }

    }
}
