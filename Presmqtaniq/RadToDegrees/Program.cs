using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadToDegrees
{
    class Program
    {
        static void Main(string[] args)
        {

            decimal radians;
            decimal degrees;
            radians = decimal.Parse(Console.ReadLine());
            degrees = (radians * 180) / (decimal)Math.PI;

            Console.WriteLine(Math.Round(degrees, 2));
        }
    }
}
