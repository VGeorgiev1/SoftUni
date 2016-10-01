using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2d_rectangle_area
{
    class Program
    {
        static void Main(string[] args)
        {

            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double y;
            double x;
            double area;
            double perimeter;
            if ((y1 - y2) < 0)
            {
                y = -(y1 - y2);
            }
            else
            {

                y = (y1 - y2);
            }
            if ((x1 - x2) < 0)
            {
                x = -(x1 - x2);
            }
            else
            {
                x = x1 - x2;

            }
            area = x * y;
            perimeter = 2 * (x + y);
            Console.WriteLine(area);
            Console.WriteLine(perimeter);

        }
    }
}
