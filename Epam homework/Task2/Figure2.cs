using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    class Figure2
    {
        private readonly int X;
        private readonly int Y;

        public Figure2(int x, int y)
        {
            X = x;
            Y = y;
        }
        public virtual void Draw()
        {
            Console.WriteLine("Drawing figure #2...");
        }
    }
}
