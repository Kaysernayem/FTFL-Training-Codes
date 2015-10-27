using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// WAP to convert any string to its short form Like: Hello World as HW
namespace ShortForm
{
    class Program
    {
        static void Main(string[] args)
        {
            string text;
            Console.Write("Enter your text:");
            text = Console.ReadLine();
            string shortForm = "";
            Boolean spaceFound = false;
            for (int position = 0; position < text.Length; position++)
            {
                int asciValue = text[position];
                if (position == 0)
                {
                    shortForm = shortForm + text[position].ToString().ToUpper();
                }
                else if (asciValue == 32)
                {
                    spaceFound = true;
                }
                else if (spaceFound)
                {
                    shortForm = shortForm + text[position].ToString().ToUpper();
                    spaceFound = false;

                }
            }
            Console.WriteLine("shortForm is : " + shortForm);
            Console.ReadLine();
        }
    }
}
