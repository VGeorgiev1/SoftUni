using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convertor
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal a;
            a = decimal.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            string output = Console.ReadLine();
            if (input == "BGN")
            {
                if (output == "USD")
                {
                    a = a *(decimal)0.5569510272961698;

                }
                else if (output == "EUR")
                {
                    a = a *(decimal)0.5112918811962185;
                }
                else if(output == "GBP")
                {
                    a = a *(decimal)0.3946252047118249;

                }
            }
            if (input == "USD")
            {
                if (output == "BGN")
                {
                    a = a *(decimal)1.79549;

                }
                else if (output == "EUR")
                {
                    a = a * (decimal)0.9180194597689983;
                }
                else if(output == "GBP")
                {
                    a = a * (decimal)0.752190756;

                }

            }
            if (input == "EUR")
            {
                if (output == "BGN")
                {
                    a = a * (decimal)1.95290058;

                }
                else if (output == "USD")
                {
                    a = a * (decimal)1.11495;
                }
                else if (output == "GBP")
                {
                    a = a * (decimal)0.838150724;

                }
            }
             if (input == "GBP")
                {
                    if (output == "BGN")
                    {
                        a = a * (decimal)2.33001121;

                    }
                    else if (output == "EUR")
                    {
                        a = a * (decimal)1.19310283;
                    }
                    else if (output == "USD)
                    {
                        a = a * (decimal)0.7085456088080346;

                    }

                }
                Console.WriteLine(Math.Round(a,2));
            }


        }
    }

