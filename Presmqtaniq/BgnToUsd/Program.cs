using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BgnToUsd
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal usd;
            decimal bgn;
            usd = decimal.Parse(Console.ReadLine());
            bgn=usd*(decimal)1.79549;
            Console.WriteLine(bgn + " BGN");


        }
    }
}
