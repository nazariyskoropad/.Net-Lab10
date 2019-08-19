using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    static class StaticCircle
    {
        public const double PI = 3.14159265358979;
        public static double GetLength(double radius)
        {
            return 2 * PI * radius;
        }

        public static double GetSquare(double radius)
        {
            return PI * radius * radius;
        }
    }
}
