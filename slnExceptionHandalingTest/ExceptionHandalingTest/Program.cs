using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandalingTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int c;
            while (true)
            { 
            try
            {
                
                Console.Write("Enter first integer:");
                a = int.Parse(Console.ReadLine());
                Console.Write("Enter second integer:");
                b = int.Parse(Console.ReadLine());
                c = a / b;
                Console.WriteLine("Result=" + c);
            }
            catch (FormatException Ex1)
            {
                Console.WriteLine("Wrong format\n" + Ex1);
            }

            catch (OverflowException Ex3)
            {
                Console.WriteLine("Enter less value\n" + Ex3);
            }

            catch (DivideByZeroException Ex2)
            {
                Console.WriteLine("Unable to divide by zero(0)\n" + Ex2);
            }
            catch (Exception Ex)
            {
                Console.WriteLine("Problem\n"+Ex);
            }
            }
        }
    }
}
