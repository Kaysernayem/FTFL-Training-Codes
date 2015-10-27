using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstUpperCase
{
    class Program
    {
        static void Main(string[] args)
        {
            String s, res = "";
            Console.WriteLine("Enter the text:");
            s=Console.ReadLine();
            for (int i = 0; i <s.Length; i++)
            {
                if(char.IsUpper(s[i])==true)
                    res = res + char.ToLower(s[i]);
                else if (char.IsLower(s[i])== true)
                    res = res + char.ToUpper(s[i]);
                else
                    res = res + s[i];
            }
            Console.WriteLine("Toggle Result:" + res);
            Console.Read();
        }
    }
}
