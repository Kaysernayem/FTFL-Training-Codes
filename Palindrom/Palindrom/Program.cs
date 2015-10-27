using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrom
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            Console.Write("Enter the  number: ");
            num1 = int.Parse(Console.ReadLine());


           // while (num1<num2)
            //{
               int num1Length = num1.ToString().Length;
               string reverse="";
               string number = num1.ToString();
               int lastPosition = num1Length - 1;
               for (int i = 0; i < num1Length; i++)
                {
                    reverse = reverse+ number[lastPosition--];
                    //lastPosition--;
                }
               if (number== reverse)
                {
                 Console.WriteLine(reverse + " is Prerindm");
               
                }
               else
               {
                   Console.WriteLine(reverse + " is not Prerindm");
               }


            //}
        }
    }
}
