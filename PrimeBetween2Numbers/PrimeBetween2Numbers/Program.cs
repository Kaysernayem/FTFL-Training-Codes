using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeBetween2Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            Console.Write("Enter the First integer number: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter the Last integer number: ");
            num2 = int.Parse(Console.ReadLine());
            while (num1 <= num2)
            {
               Boolean noPrime = false;
                if (num1 > 1)
                {
                    for (int i = 2; i < (num1 / 2)+2; i++)
                    {
                        if (num1 % i == 0)
                        {
                            noPrime = true;
                            break;

                        }
                    }
                    if( noPrime  == false)
                    {
                        Console.WriteLine(num1);
                    }
                    
                }
                num1++;
            }
        }
    }
}
