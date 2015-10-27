using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiCastDelegateExample
{
    delegate void MyDelegate(int a, int b);

    class Program
    {
            public int a{get;set;}
            public int b{get;set;}

            public static void Addition(int a, int b)
            {
                int c = a + b;
                Console.WriteLine("Addition Result=" + c);
            }
            public static void Substruction(int a, int b)
            {
                int c = a - b;
                Console.WriteLine("Substruction Result=" + c);
            }
            public static void Multiplication(int a, int b)
            {
                int c = a * b;
                Console.WriteLine("Multiplication Result=" + c);
            }
            public static void Divition(int a, int b)
            {
                int c = a / b;
                Console.WriteLine("Divition Result=" + c);
            }

        static void Main(string[] args)
        {
            MyDelegate objMyDelegate = new MyDelegate(Addition);
            objMyDelegate += Substruction;
            objMyDelegate += Divition;
            objMyDelegate += Multiplication;
            objMyDelegate -= Divition;
            objMyDelegate(10,5);
            Console.Read();
        }

    }
}
