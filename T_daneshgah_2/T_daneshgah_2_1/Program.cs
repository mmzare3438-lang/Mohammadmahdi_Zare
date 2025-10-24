﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mohammadmahdi_Zare_T2_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.Write("Enter a number: ");
            a = int.Parse(Console.ReadLine());


            if (a % 2 == 0 & a < 10)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
    }
}