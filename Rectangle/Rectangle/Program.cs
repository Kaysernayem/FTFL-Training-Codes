using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle(20,10,10,5);
            r.getArea();
            r.getPerimeter();
            Console.WriteLine("Area=" + r.area);
            Console.WriteLine("Perimerer=" + r.perimeter);
            Console.Read();
        }
    }
}
