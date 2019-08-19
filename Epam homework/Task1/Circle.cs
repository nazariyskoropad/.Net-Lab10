using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    class Circle
    {
        public const double PI = 3.14159265358979;
        private readonly double radius;
        public Circle(double radius)
        {
            if (radius <= 0)
                throw new Exception("Radius must be positive");
            this.radius = radius;
        }

        public double GetLength()
        {
            return 2 * PI * radius;
        }

        public double GetSquare()
        {
            return PI * radius * radius;
        }
    }
}
