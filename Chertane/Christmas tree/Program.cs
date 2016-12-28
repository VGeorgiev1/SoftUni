using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Christmas_tree
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <=n+1; i++)
            {
                Console.Write(" ");
            }
            Console.WriteLine("|");
            int spaces = 0;
                for (int i = 0; i < n+2; i++)
                {
                    for (int b = 0; b < (2*n)+3; b++)
                    {
                    do
                    {
                        Console.Write(" ");
                        spaces++;
                    } while (spaces < n - i);

                    }
                }

        }
    }
}
