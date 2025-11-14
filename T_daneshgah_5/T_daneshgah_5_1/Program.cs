using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T_daneshgah_5_1
{
    using System;

    class Program
    {
        static void Main()
        {
            Console.WriteLine("!Triangle Calculator!");
            Console.WriteLine("===================");

            Console.Write("Enter side A: ");
            double sideA = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter side B: ");
            double sideB = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter side C: ");
            double sideC = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter height for side A: ");
            double height = Convert.ToDouble(Console.ReadLine());

            double perimeter = CalculatePerimeter(sideA, sideB, sideC);
            double area = CalculateArea(sideA, height);

            Console.WriteLine("");
            Console.WriteLine("Results:");
            Console.WriteLine("Perimeter: " + perimeter);
            Console.WriteLine("Area: " + area);

            Console.ReadKey();
        }

        static double CalculatePerimeter(double a, double b, double c)
        {
            return a + b + c;
        }

        static double CalculateArea(double baseSide, double height)
        {
            return (baseSide * height) / 2;
        }
    }
}
