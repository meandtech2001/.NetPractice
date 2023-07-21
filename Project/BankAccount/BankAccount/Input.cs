using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainProgram
{
     public class Input
    {
        public string ReadString(string prompt)
        {

            Console.Write(prompt);
            return Console.ReadLine();
        }
        public int ReadInt(string prompt)
        {

            Console.Write(prompt);
            return int.Parse(Console.ReadLine());
        }
        public double ReadDouble(string prompt)
        {

            Console.Write(prompt);
            return double.Parse(Console.ReadLine());
        }
    }
}

