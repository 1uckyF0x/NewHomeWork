using System;
using System.Collections.Generic;
using System.Text;

namespace NewHomeWork1504
{
    class Circle : Figure

    {
        public const double PI = 3.14;
        public Circle(double height, double width) : base(height, width)
        {

        }
        public new double Perimeter()

        {
            return Height * 2 * PI;
        }

        public new double Area()

        {
            return Height*Height;
        }

    }
}
