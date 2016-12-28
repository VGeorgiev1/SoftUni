using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareFrame
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int broi = 0;
            for (int i = 1; i<2 ; i++)
            {
                
                Console.Write("+");
                
                for (int b = 0; b <n-1 ; b++)
                {
                    
                    Console.Write(" ");
                    broi++;
                    if (broi == n - 1)
                    {
                        break;
                    }
                    Console.Write("-");
                    
                }
                Console.WriteLine("+");
  
            }
            broi = 0;
            for (int c = 0; c < n-2; c++)
            { Console.Write("|");
                broi = 0;
                for(int u = 0; u <n-2 ; u++)
                {   
                    Console.Write(" ");
                    broi++;
                    Console.Write("-");
                    if (broi == n - 2)
                    {
                        break;
                    }
                }
                Console.WriteLine(" |");
            }
            broi = 0;
            for (int i = 1; i < 2; i++)
            {

                Console.Write("+");

                for (int b = 0; b < n - 1; b++)
                {

                    Console.Write(" ");
                    broi++;
                    if (broi == n - 1)
                    {
                        break;
                    }
                    Console.Write("-");

                }
                Console.WriteLine("+");

            }
        }
    }
}
