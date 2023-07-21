using System;
using System.Xml.Linq;
using BankAccount;


namespace MainProgram
{
    class Atm
    {
        static void Main(string[] args)
        {
            int val;
            double userInput;
            string message;
            
            
            Input input = new Input();
            var accountNumber = input.ReadInt("Account Number: ");
            var name = input.ReadString("Name: ");
            var password = input.ReadString("Enter Password: ");
            var balance = input.ReadDouble("Inital Amount?");
            var interestRate = 12;

            var account=new AccountInfo(accountNumber, name, password,balance,interestRate);


            Console.WriteLine("-----------Login to BANK--------------");

            
            Console.WriteLine("------Welcome " + account.Name + "-------\n");
            do
            {
                
                val = input.ReadInt("MENU\n1. Get Info \n2. Deposit\n3. Withdraw\n4. Transfer\n5. Check Balance\n0. Exit\nChoose:");
                switch (val)
                {
                    case 1:
                            Console.WriteLine("Account Number: " + account.AccountNumber);
                            Console.WriteLine("Name: " + account.Name);
                            Console.WriteLine("Balance: " + account.Balance);
                            //Console.WriteLine("One month Interest Rate: " + interestRate);
                        break;
                    case 2:
                        userInput = input.ReadDouble("Enter the amount to be deposited: ");
                        message = account.DepositAmount(userInput);
                        Console.WriteLine(message);

                        break;

                    case 3:
                        userInput = input.ReadDouble("Enter the amount to be withdrawed: ");
                       
                        Console.Write("Enter Password: ");
                        string enteredPassword1 = Console.ReadLine();
                        message = account.WithdrawAmount(enteredPassword1,userInput);
                        Console.WriteLine(message);

                        break;

                    case 4:
                        userInput = input.ReadDouble("Enter the amount to be transferred: ");

                        string enteredPassword2 = input.ReadString("Enter Password: ");
                        string messageT = account.TransferAmount(enteredPassword2, userInput);
                        Console.WriteLine(messageT);

                        break;

                    case 5:
                        Console.WriteLine("current balance is: " + account.Balance);
                        //account.creditinterest();
                        //console.writeline("interest credited");
                        break;

                    case 0:
                        Console.WriteLine("Thanks");
                        break;
                }

            } while (val != 0);
            
        }
    }
}
