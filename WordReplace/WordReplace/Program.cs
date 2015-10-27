using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordReplace
{
    class Program
    {
        static void Main(string[] args)
        {
            string text, replace, search;
            Console.Write("Enter the text: ");
            text = Console.ReadLine();
            Console.Write("Enter the word u want to search: ");
            search = Console.ReadLine();
            Console.Write("Enter the word u want to replace: ");
            replace = Console.ReadLine();

            for (int location = 0; location < text.Length; location++)
            {
                for (int innerposition = location; innerposition < text.Length; innerposition++)
                {
                    if (text[location] == search[innerposition])
                    {
                        //  if(search.Length==)
                    }
                }

            }
        }
    }
}
