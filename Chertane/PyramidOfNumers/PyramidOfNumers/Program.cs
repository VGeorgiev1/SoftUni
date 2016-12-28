using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PyramidOfNumers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int row = 1;
            int broichisa = 0;
            for (int i = 1; i <= n; i++)
            {
                
                Console.Write(i);
                broichisa++;
                if (broichisa == row)
                {
                    Console.WriteLine();
                    row++;
                    broichisa = 0;
                }
                

            }
        }
    }
}
