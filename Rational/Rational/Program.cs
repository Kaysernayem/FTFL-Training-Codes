using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rational
{
    class Rational
    {
        int num;
        int deno;
        public Rational()
        {
            Console.Write("Default Constructor is called");
            num = 0; deno = 1;
        }
        public Rational(int a)
        {
            num = a; deno = 1;
            Console.Write("Parametrized constructor Invoked with 1");
        }
        public Rational(int a,int b)
        {
            int num = 2; int deno = 3;
            this.num = a; this.deno = b;
            Console.Write("Parametrized constructor Invoked with 2");
        }
        public void Show()
        {
            Console.WriteLine("Rational:" + num + "/" + deno);
        }

        public int SetGet_num
        {
            get
            {
                return num;
            }
            set
            {
                num = value;
            }
        }
            public int Get_deno
            {
            get
        {
            return deno;
        }

    }
            class Program
            {
                static void Main(string[] args)
                {
                    Rational r1 = new Rational();
                    r1.Show();
                    Rational r2 = new Rational(5);
                    r2.Show();
                    Rational r3 = new Rational(6, 7);
                    r3.Show();
                    r3.SetGet_num = 11;
                    Console.WriteLine(r3.SetGet_num);
                    Console.WriteLine(r3.Get_deno);
                    Console.Read();
                }
            }
    }
}
