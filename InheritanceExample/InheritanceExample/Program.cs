using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExample
{
    class Parent
    {
        int x, y;
        protected void GetXY(int a, int b)
        {
            x=a;y=b;
        }
        public void Show()
        {
            Console.WriteLine("X:" + x + "\tY:" + y);
        }
    }
    class Child:Parent
    {
        int z;
        public void GetZ(int c)
        {
            GetXY(3, 4);
            z = c;
        }
        public void Show()
        {
            base.Show();
            Console.WriteLine("Z:" + z);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Child c1 = new Child();
            c1.GetZ(4);
            c1.Show();
            Console.Read();
        }
    }
}
