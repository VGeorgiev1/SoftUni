using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal a;
            decimal h;
            decimal area;

            a = decimal.Parse(Console.ReadLine());
            h = decimal.Parse(Console.ReadLine());
            area = a * h / 2;
            Console.WriteLine("Triangle area= "+Math.Round(area, 2));

        }
    }
}
