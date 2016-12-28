using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Squeres
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int[] arr = new int[50];
            int[] arr2 = new int[50];
            int i = 0;
            int j = 0;
            foreach(string num in input)
            {
                arr[i] = int.Parse(num);
                i++;
            }
            i = 0;
            do
            {
                if (Math.Sqrt(arr[i]) == (int)Math.Sqrt(arr[i]))
                {
                    arr2[j] = arr[i];
                    j++;
                }
                i++;

            } while (i < arr.Length);
            Array.Sort(arr2, (a, b) => b.CompareTo(a));
            for (j = 0; j < arr2.Length; j++)
            {
                if (arr2[j] != 0)
                {
                    Console.Write(arr2[j]+ " ");
                }
            }
        }
    }
}
