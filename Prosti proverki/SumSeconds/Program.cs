using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumSeconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int sum = a + b + c;
            int sec;
            if (sum < 60)
            {
                if (sum < 10)
                {
                    Console.WriteLine("0:0" + sum);

                }
                else
                {
                    Console.WriteLine("0:" + sum);
                }
            }
            if (sum >= 60 && sum<120)
            {
                sec = sum - 60;
                if (sec < 10)
                {
                    Console.WriteLine("1:0" + sec);
                 }
                else
                {
                    Console.WriteLine("1:" + sec);

                }
            }
            if (sum > 120)
            {
                sec = sum - 120;
                if (sec < 10)
                {
                    Console.WriteLine("2:0" + sec);
                }
                else
                {
                    Console.WriteLine("2:" + sec);

                }
            }
        }
    }
}
