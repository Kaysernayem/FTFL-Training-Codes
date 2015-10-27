using System;
// Program to find the sum of two given number
namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b,sum;
            Console.WriteLine("Enter the first number:");
            a=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number:");
            b=int.Parse(Console.ReadLine());
            sum = a + b;
            Console.WriteLine("Sum={0}", sum);
            //Console.WriteLine("Sum="+z);
            Console.Read();
        }
    }
}
