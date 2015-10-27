using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// WAP to check whethe the input string is palindrom of not, Display the reverse of the string also
namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            string s;
            Console.Write("Enter Teaxt:");
            s=Console.ReadLine();
            string rev="";
            for(int i=s.Length-1;i>=0;i--)
            {
                rev=rev+s[i];
            }
            Console.WriteLine("Reverse is:",+rev);
            if (rev.Equals(s) == true)
                Console.WriteLine= ("Panindrom");
            else
                Console.WriteLine("Not Panindrom");
            Console.Read();
        }
    }
}
