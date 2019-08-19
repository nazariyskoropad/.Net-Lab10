using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    class Rectangle1
    {
        private readonly double x1;
        private readonly double x2;
        private readonly double y1;
        private readonly double y2;
        public Rectangle1(double x1, double y1, double x2, double y2)
        {       
            if (x1 >= x2 || y1 <= y2)
                throw new Exception("You must enter coordinates of top-right and lower-right points");
            
            this.x1 = x1;
            this.x2 = x2;
            this.y1 = y1;
            this.y2 = y2;
        }

        public double GetPerimeter()
        {
            return 2*((x2-x1) + (y1 - y2));
        }

        public double GetSquare()
        {
            return (x2 - x1) * (y1 - y2);
        }


    }
}
