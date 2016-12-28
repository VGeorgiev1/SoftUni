using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountSubsequenses
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int i = 0;
            int j;
            foreach(string num in input)
            {
                i++;
            }
            int[] arr = new int[i];
            j = i;
            i = 0;
            foreach (string num in input)
            {
                arr[i] = int.Parse(num);
                i++;
            }
            i = 0;
            Array.Sort(arr);
          //  do
            //{
            //    Console.WriteLine(arr[i]);
             //   i++;
           // } while (i < arr.Length);
            int count = 1;
            i = 0;
            do
            {
                if(i + 1 >= arr.Length)
                {
                    Console.WriteLine(arr[i] + " -> " + count);
                    break;
                }
                
                if (arr[i] == arr[i + 1])
                {
                    count++;
                }
                else
                {
                    Console.WriteLine(arr[i] + " -> " + count);
                    count = 1;
                }
                i++;
            } while (i <= arr.Length);

        }
    }
}
