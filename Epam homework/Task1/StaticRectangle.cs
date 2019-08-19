using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    static class StaticRectangle
    {
        public static double GetPerimeter(double x1, double x2, double y1, double y2)
        {
            return 2 * ((x2 - x1) + (y1 - y2));
        }

        public static double GetSquare(double x1, double x2, double y1, double y2)
        {
            return (x2 - x1) * (y1 - y2);
        }
    }
}
