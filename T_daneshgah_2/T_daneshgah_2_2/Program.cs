﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mohammadmahdi_Zare_T2_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int c, a;
            Console.Write("Enter your desired number: ");
            a = int.Parse(Console.ReadLine());

            if (a % 7 == 0)
            {
                Console.WriteLine("yes!");
            }
            else
            {
                c = a * 3;
                Console.WriteLine(c);
                Console.ReadKey();
            }
        }
    }
}