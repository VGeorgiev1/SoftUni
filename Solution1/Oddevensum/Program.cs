using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oddevensum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int y = 1;
            int numb;
            int sumodd=0;
            int sumeven=0;
            int sum = 0;
            for (y = 1; y < n+1; y++)
            {
                numb = int.Parse(Console.ReadLine());
                if (y % 2 == 0)
                {
                    sumeven = sumeven + numb;

                }
                else
                {
                    sumodd = sumodd + numb;

                }
                sum = sumeven - sumodd;
                if (sum < 0)
                {
                    sum = -sum;
                }


            }
            if (sumodd == sumeven)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum=" + sumeven);

            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine("Diff=" +sum );

            }


        }
    }
}
