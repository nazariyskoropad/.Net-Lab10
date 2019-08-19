using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    class Rectangle2 : Figure2
    {
        public Rectangle2(int x, int y) : base(x, y)
        {
        }

        public override void Draw()
        {
            Console.WriteLine("Drawing rectangle #2...");
        }
    }
}
