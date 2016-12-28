using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleFor_
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                for (int b = 0; b < i; b++)
                {
                    Console.Write("$");
                    if (b == i)
                    {
                        break;
                    }
                    Console.Write(" ");
                }
                Console.WriteLine();
            }

        }
    }
}
