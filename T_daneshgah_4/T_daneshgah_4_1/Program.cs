using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T_daneshgah_4_1
{
    using System;

    class Program
    {
        static void Main()
        {
            int evenCount = 0;
            int oddCount = 0;

            Console.WriteLine("Enter 10 numbers:");

            for (int i = 1; i <= 10; i++)
            {
                Console.Write("Enter number " + i + ": ");
                int number = Convert.ToInt32(Console.ReadLine());

                if (number % 2 == 0)
                {
                    evenCount++;
                }
                else
                {
                    oddCount++;
                }
            }

            Console.WriteLine("");
            Console.WriteLine("Results:");
            Console.WriteLine("Even numbers: " + evenCount);
            Console.WriteLine("Odd numbers: " + oddCount);

            Console.ReadKey();
        }
    }
}

