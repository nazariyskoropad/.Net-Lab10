using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    class Rectangle4 : Figure4
    {
        public Rectangle4(int x, int y) : base(x, y)
        {
        }
        public override void Draw()
        {
            Console.WriteLine("Drawing rectangle #4...");
        }

    }
}
