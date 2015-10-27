using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Check whether the input integer is prime or not.
namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Boolean flag = false;
            Console.WriteLine("Enter the integer number");
            num = int.Parse(Console.ReadLine());
            if (num > 1)
            {
                for (int i = 2; i <= num / 2; i++)
                {
                    if (num % i == 0)
                    {
                        flag = true;
                        break;
                    }
                }
                    if (flag == true)
                        Console.WriteLine("Not Prime");
                    else
                        Console.WriteLine("Prime Number");
            }
                else
                    Console.WriteLine("Invalid Input");
                    Console.Read();
            }
    }
}
