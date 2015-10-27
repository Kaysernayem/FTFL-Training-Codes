using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            string s;
            int len;
            Console.Write("Enter text:");
            s = Console.ReadLine();
            len = s.Length;
            Console.WriteLine("Length of the text is=:"+len);
            Console.WriteLine("Upper case:"+s.ToUpper());
            Console.WriteLine("Lower case:" + s.ToLower());
            Console.WriteLine("Substring:" + s.Substring(2,3));
            Console.WriteLine("a exist in the position :" + s.IndexOf('a'));
            s = "     *   " + s + "     $     ";
            Console.WriteLine(s);
            Console.WriteLine("Text is:"+ s.Trim());
            Console.Read();
        }
    }
}
