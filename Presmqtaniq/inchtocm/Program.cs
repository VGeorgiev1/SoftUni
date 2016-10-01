
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inchtocm
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("inches=");
            double a = double.Parse(Console.ReadLine());
            a = a * 2.54;
            Console.WriteLine("Cantimeters = " + a);
        }
    }
}
