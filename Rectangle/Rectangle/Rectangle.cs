using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle
{
    class Rectangle
    {
        public double width, height, xPosition, yPosition,area,perimeter;

        public Rectangle(double a, double b,double c,double d)
        {
            width=a;
            height=b;
            xPosition=c;
            yPosition=d;
        }

        public void getArea()
        {
            area = width * height;
        }

        public void getPerimeter()
        {
            perimeter = 2 * (width + height);
        }
    }
}
