using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TitleText
{
    class Program
    {
        static void Main(string[] args)
        {
            string s,res="";
            int nos=0,nod=0,nol=0,nosc=0;
            Console.Write("Enter the Text:");
            s = Console.ReadLine();
            for (int i = 0; i < s.Length; i++)
            {
                if(char.IsLetter(s[i]))
                    nol++;
                else if(char.IsDigit(s[i]))
                    nod++;
                else if(char.IsWhiteSpace(s[i]))
                    nos++;
                else
                    nosc++;
            }
            Console.WriteLine("Number of letters are:"+nol);
            Console.WriteLine("Number of Digits are:"+nod);
            Console.WriteLine("Number of White spaces are:"+nos);
            Console.WriteLine("Number of special characters are:"+nosc);
            
            for (int i = 0; i < s.Length; i++)
            {
                if (char.IsUpper(s[i]) == true)
                    res = res + char.ToLower(s[i]);
                else
                    res = res + s[i];
            }
            Console.WriteLine("Title Text:" + res);
            Console.Read();
        }

    }
}
