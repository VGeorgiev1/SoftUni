using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int i;
            int numb;
            int sum = 0;
            for (i = 0; i < n; i++)
            {
                numb = int.Parse(Console.ReadLine());
                sum = sum + numb;

            }
            Console.WriteLine(sum);
        }
    }
}
