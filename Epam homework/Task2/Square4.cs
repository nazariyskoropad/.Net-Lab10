using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    class Square4 : Figure4
    {
        public Square4(int x, int y) : base(x, y)
        {
        }
        public override void Draw()
        {
            Console.WriteLine("Drawing square #4...");
        }
    }
}
