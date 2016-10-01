using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1to9WithWords
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());

            if (a == 1)
            {
                Console.WriteLine("one");

            }
            if (a == 2)
            {
                Console.WriteLine("two");

            }
            if (a == 3)
            {
                Console.WriteLine("three");

            }
            if (a == 4)
            {
                Console.WriteLine("four");

            }
            if (a == 5)
            {
                Console.WriteLine("five");

            }
            if (a == 6)
            {
                Console.WriteLine("six");

            }
            if (a == 7)
            {
                Console.WriteLine("seven");

            }
            if (a == 8)
            {
                Console.WriteLine("eight");

            }
            if (a == 9)
            {
                Console.WriteLine("nine");

            }
           
            if (a > 9)
            {
                Console.WriteLine("number too big");

            }
        }
    }
}
