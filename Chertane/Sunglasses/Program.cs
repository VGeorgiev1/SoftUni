using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sunglasses
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int chek = 0;
            if (n % 2 == 0)
            {
                chek = 1;
            }
            else
            {
                chek = 2;

            }
            for (int i = 1; i < 5*n+1; i++)
            {
                if (i > 2 * n && i <= 3 * n)
                {
                    Console.Write(" ");
                }
                else
                {
                    Console.Write("*");
                }
            
            }
            Console.WriteLine();
            for (int i = 1; i < n-1; i++)
            {
             Console.Write("*");
             Console.Write(new string('/', 2 * n - 2));
             Console.Write("*");
                if ((chek == 1 && i == (n/2)-1) || n==3)
                {
                    Console.Write(new string('|', n));
                }
                else if (chek == 2 && i==(n/2))
                {
                    Console.Write(new string('|', n));
                }
                else {
                    Console.Write(new string(' ', n));
                }
               
            Console.Write("*");
            Console.Write(new string('/', 2 * n - 2));
            Console.Write("*");
            Console.WriteLine();
        }
            for (int i = 1; i < 5 * n+1; i++)
            {
                if (i > 2 * n && i <= 3 * n)
                {
                    Console.Write(" ");
                }
                else
                {
                    Console.Write("*");
                }

            }
        }
    }
}
