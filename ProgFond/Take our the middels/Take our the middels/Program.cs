using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Take_our_the_middels
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int[] arr =  new int[50];
            int i = 0;
            foreach(string num in input)
            {
                arr[i] = int.Parse(num);
                i++;
            }
            if (i == 1)
            {

                Console.Write("{ "+arr[i]+" }")

            }
            else if (i % 2 == 0)
            {
                Console.Write("{ "+arr[(i / 2)-1]+", ");
                Console.Write(arr[i/2]+" }");

            }
            else if (i % 2 != 0)
            {
                Console.Write("{ "+arr[(i / 2)-1]+", ");
                Console.Write(arr[i / 2]+", ");
                Console.Write(arr[(i / 2)+1]+" }");

            }


        }
    }
}
