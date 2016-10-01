using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leftrightsum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sumleft = 0; ;
            int sumright = 0; ;
            int sum;

            for(int i = 0; i < n; i++)
            {
                int numb = int.Parse(Console.ReadLine());
                sumleft = sumleft + numb;
            }
            for (int i = 0; i < n; i++)
            {
                int numb = int.Parse(Console.ReadLine());
                sumright = sumright + numb;
            }
            sum = sumleft - sumright;
            if (sum < 0)
            {
                sum = -sum;
            }
            if (sumleft == sumright)
            {
                Console.WriteLine("Yes, sum=" + sumright);
            }
            else
            {

                Console.WriteLine("No, diff=" +sum);

            }
        }
    }
}
