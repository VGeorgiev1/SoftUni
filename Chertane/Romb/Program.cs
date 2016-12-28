using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Romb
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int row = 1; row <= n + 1; row++)
            {
                for (int i = 0; i < n - row + 1; i++)
                {
                    Console.Write(" ");
                }
                for (int b = 0; b < row - 1; b++)
                {
                    Console.Write("*");
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
            int rowss = 1;
            int y = 0;
            for (int rows = n - 1; rows > 0; rows--)
            {
                do
                {
                    Console.Write(" ");
                    y++;
                } while (y < rowss);
                rowss++;
            for (int i = 1; i <= rows; i++)
            {

                Console.Write("*");
                Console.Write(" ");
            }
            Console.WriteLine();
                y = 0;
            }

        }

      }
    }
    

