using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonusi
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());

            double bonus;
            double obshto;
            if (a <= 100)
            {
                bonus = 5;

            }
            else if (a > 100)
            {

                bonus = 0.2 * a;
            }
            else if (a > 1000)
            {

                bonus = 0.1 * a;
            }
            if (a % 10 == 0)
            {

                bonus = bonus + 1;
            }

        }
    }
}
