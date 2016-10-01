using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle_Peremeter_and_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal r = decimal.Parse(Console.ReadLine());

            decimal area;
            decimal perimeter;
            area =(decimal)Math.PI * r * r;
            perimeter = 2 *(decimal)Math.PI * r;
            Console.WriteLine("Area= " + area);
            Console.WriteLine("Perimeter= " + perimeter);

        }
    }
}
