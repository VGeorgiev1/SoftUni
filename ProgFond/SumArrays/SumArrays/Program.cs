using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int i = 0;
            int[] arr = new int[50];
            foreach (string num in input)
            {
                i++;
                arr[i] = int.Parse(num);
                
            }
            Console.Write(i);
            int[] arr2 = new int[i-1];


            
        }
        
    }
}
