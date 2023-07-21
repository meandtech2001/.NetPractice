using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    public class Encryptor
    {
        public string Encrypt(string text)
        {
            string encrypted = "";
            for (int i = 0; i < text.Length; i++)
            {
                int ch = (int)text[i]; //ascii of chara

                encrypted += ch.ToString(); //ascii is not in string form
            }
            return encrypted;
        }

        
    }
}
