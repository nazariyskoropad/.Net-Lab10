using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    class Square2 : Figure2
    {
        public Square2(int x, int y) : base(x, y)
        {
        }
        public override void Draw()
        {
            Console.WriteLine("Drawing square #2...");
        }
    }
}
