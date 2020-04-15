using System;
using System.Collections.Generic;
using System.Text;

namespace NewHomeWork1504
{
    public class Square : Figure

    {
        public Square(double height, double width) : base(height, width)
        {

        }

        public new double Perimeter()

        {
            return Height * 4;
        }
        public new double Area()

        {
            return Height * Height;
        }
    }
}
