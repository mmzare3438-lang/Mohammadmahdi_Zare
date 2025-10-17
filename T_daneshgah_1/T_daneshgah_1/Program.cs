using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mohammadmahdi_Zare_T1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Double a, mohit, masahat;

            Console.Write("Enter a number: ");
            a = Int32.Parse(Console.ReadLine());

            mohit = 3.14 * a;
            masahat = a * 0.5 * a * 0.5 * 3.14;

            Console.WriteLine("Masahat is {0} and Mohit is {1}", masahat, mohit);



            Console.ReadKey();
        }
    }
}