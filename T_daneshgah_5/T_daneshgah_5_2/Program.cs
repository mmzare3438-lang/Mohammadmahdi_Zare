using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T_daneshgah_5_2
{
    using System;

    class Program
    {
        static void Main()
        {
            Console.WriteLine("!Multiplication of numbers!");
            Console.WriteLine("==============================");

            Console.Write("Enter first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int result = MultiplyRecursive(num1, num2);

            Console.WriteLine("");
            Console.WriteLine("Result: " + num1 + " * " + num2 + " = " + result);

            Console.ReadKey();
        }

        static int MultiplyRecursive(int a, int b)
        {
            if (a == 0 || b == 0)
                return 0;

            if (b == 1)
                return a;

            if (b == -1)
                return -a;

            if (b > 0)
                return a + MultiplyRecursive(a, b - 1);

            else
                return -a + MultiplyRecursive(a, b + 1);
        }
    }
}
