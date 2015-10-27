using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            //Shape objShape = new Shape();
            Line objLine = new Line();
            Circle objCircle = new Circle();
            Rectangle objRectangle = new Rectangle();
            //objShape.Display();
            objLine.Display();
            objCircle.Display();
            objRectangle.Display();
            Console.Read();
        }
    }
}
