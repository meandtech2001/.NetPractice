using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankTesterAccount
{
    public class TestRepoter
    {
        public static void Report(string actualResult,string expectedResult,string testDiscription)
        {
            if (actualResult == expectedResult) 
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("PASSED " + testDiscription);
                Console.WriteLine("Actual Result: {0}\t Expected Result: {1}\n ",actualResult,expectedResult);
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("FAILED " + testDiscription);
                Console.WriteLine("Actual Result: {0}\t Expected Result: {1} \n", actualResult, expectedResult);
                Console.ResetColor();
            }
        }
    }
}
