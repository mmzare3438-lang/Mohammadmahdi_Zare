using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T_daneshgah_4_2
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main()
        {
            List<int> positions = new List<int>();

            Console.WriteLine("Enter 5 numbers:");

            for (int i = 1; i <= 5; i++)
            {
                Console.Write("Enter number " + i + ": ");
                int number = Convert.ToInt32(Console.ReadLine());

                if (number == 2)
                {
                    positions.Add(i);
                }
            }

            if (positions.Count > 0)
            {
                Console.Write("Number 2 found at position(s): ");
                for (int i = 0; i < positions.Count; i++)
                {
                    Console.Write(positions[i]);
                    if (i < positions.Count - 1)
                        Console.Write(", ");
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Number 2 not found");
            }
        }
    }
}