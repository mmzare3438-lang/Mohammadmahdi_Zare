using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace Mohammadmahdi_Zare_T3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, product = 1;

            Console.Write("Enter your number: ");
            a = Convert.ToInt32(Console.ReadLine());

            while (a != 0)
            {
                product *= a;
                Console.Write("Enter your number: ");
                a = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Product: {0}", product);
            Console.ReadKey();
        }
    }
}
