using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            //working with abstract class Figure1
            Console.WriteLine("Task 2.1");
            var rectangle1 = new Rectangle1();
            rectangle1.Draw();
            var square1 = new Square1();
            square1.Draw();

            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("_________________________________________");
            Console.WriteLine("Task 2.2 + Task 2.3");

            var figure2 = new Figure2(1,1);
            figure2.Draw();
            var rectangle2 = new Rectangle2(1, 1);
            rectangle2.Draw();
            var square2 = new Square2(1, 1);
            square2.Draw();

            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("_________________________________________");
            Console.WriteLine("Task 2.4 ");
            var figure4 = new Figure4(1, 1);
            var rectangle4 = new Rectangle4(1, 1);
            var square4 = new Square4(1, 1);
            DrawAll(figure4, rectangle4, square4);
            
        }
        static void DrawAll(params IDrawable[] array)
        {
            foreach (var obj in array)
                obj.Draw();
        }
    }
}
