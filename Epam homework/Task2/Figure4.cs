using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    class Figure4 : IDrawable
    {
        private readonly int X;
        private readonly int Y;

        public Figure4(int x, int y)
        {
            X = x;
            Y = y;
        }
        public virtual void Draw()
        {
            Console.WriteLine("Drawing figure #4...");
        }
    }
}
