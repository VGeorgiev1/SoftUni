﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NxNRectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                for (int b = 0; b < n; b++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

        }
    }
}
