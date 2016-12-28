using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectagnleStars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int broika = 0;
            int i = 0;
            for (int b=0; b < n; b++)
            {
                
                for (i = 0; i < n; i++)
                {
                    broika = 0;
                    if (broika == n)
                    {
                        break;
                    }
                    Console.Write("*");
                    broika++;
                    Console.Write(" ");
                    
                }
                Console.WriteLine();  
            }

        }
    }
}
