using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1, y1, x2, y2;
            double radius;
            double real1, imaginary1, real2, imaginary2;
            // block for rectangles
            while (true)
            {
                try
                {
                    Console.WriteLine("Enter coordinates for top-right and lower-left points of your rectangle: ");
                    Console.WriteLine("Enter x1");
                    x1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter y1");
                    y1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter x2");
                    x2 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter y2");
                    y2 = double.Parse(Console.ReadLine());

                    Console.WriteLine("_________________________________________");
                    Console.WriteLine("\nTask 1.1\n");
                    var rect1 = new Rectangle1(x1, y1, x2, y2);
                    Console.WriteLine("Perimiter = {0}", rect1.GetPerimeter());
                    Console.WriteLine("Square  = {0}", rect1.GetSquare());

                    Console.WriteLine("\nTask 1.2\n");
                    var rect2 = new Rectangle2(x1, y1, x2, y2);
                    Console.WriteLine("Perimiter = {0}", rect2.GetPerimeter);
                    Console.WriteLine("Square  = {0}", rect2.GetSquare);
                    break;
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message + " Try again");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            // block for circles
            Console.WriteLine("_________________________________________");
            Console.WriteLine("\nTask 1.3\n");
            while (true)
            {
                try
                {
                    Console.WriteLine("Enter radius for your circle:");            
                    radius = double.Parse(Console.ReadLine());                   
                    var circle1 = new Circle(radius);
                    Console.WriteLine("Perimiter = {0}", circle1.GetLength());
                    Console.WriteLine("Square  = {0}", circle1.GetSquare());
                    break;
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message + " Try again");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("_________________________________________");
            Console.WriteLine("\nTask 1.4\n");

            Console.WriteLine("Static Rectangle:\nPerimiter = {0}", StaticRectangle.GetPerimeter(x1, x2, y1, y2));
            Console.WriteLine("Square  = {0}", StaticRectangle.GetSquare(x1, x2, y1, y2));

            Console.WriteLine("\nStatic Circle:\nPerimiter = {0}", StaticCircle.GetLength(radius));
            Console.WriteLine("Square  = {0}", StaticCircle.GetSquare(radius));

            System.Threading.Thread.Sleep(2000);

            // block for complex numbers
            Console.WriteLine("_________________________________________");
            Console.WriteLine("Task 1.5\n");

            while (true)
            {
                try
                {
                    
                    Console.WriteLine("Enter 2 complex numbers");
                    Console.WriteLine("Comlex1: enter real ");
                    real1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Comlex1: enter imaginary ");
                    imaginary1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Comlex2: enter real ");
                    real2 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Comlex2: enter imaginary ");
                    imaginary2 = double.Parse(Console.ReadLine());

                    var Complex1 = new ComplexNumber (real1, imaginary1);
                    var Complex2 = new ComplexNumber(real2, imaginary2);
                    Console.Write("Complex1: ");
                    Complex1.Print();
                    Console.Write("Complex2: ");
                    Complex2.Print();

                    Console.WriteLine("\noperation * ");
                    var Complex3 = Complex1 * Complex2;
                    Complex3.Print();
                    Console.WriteLine("\noperation / ");
                    var Complex4 = Complex1 / Complex2;
                    if (Complex4 != null)
                        Complex4.Print();
                    else
                        Console.WriteLine("Can't divide: denominator == 0");
                    break;
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message + " Try again");
                }
            }
        }
    }
}
