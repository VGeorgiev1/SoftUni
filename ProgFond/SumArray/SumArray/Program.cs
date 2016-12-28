using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            string[] input2 = Console.ReadLine().Split(' ');
            int i = 0;
            int J = 0;
            int border = 0;
            int border2 = 0;
            int[] arr = new int[50];
            int[] arr2 = new int[50];
            foreach (string num in input)
            {
                
                arr[i] = int.Parse(num);
                i++;
            }
            border = i;
            
            foreach (string numm in input2)
            {
                
                arr2[J] = int.Parse(numm);
                J++;
            }
            border2 = J;
            if (i > J)
            {   border2 = J;
                int[] sum = new int[i];
                i=J=0;
                do
                {
                    if (J >= border2)
                    {
                        J = 0;
                    }
                    sum[i] = arr[i] + arr2[J];
                    Console.Write(" "+sum[i]);
                    i++;
                    J++;
                } while (i <= border-1);
                i = 0;
               
            }
            else if (J > i)
            {   
                int[] sum = new int[J];
                i = J = 0;
                do
                {
                    if (i >= border)
                    {
                        i = 0;
                    }
                    sum[J] = arr[i] + arr2[J];
                    Console.Write(sum[J]+" ");
                    i++;
                    J++;
                } while (J <= border2 - 1);
               
            }
            else
            {
                int[] sum = new int[i];
                i = J = 0;
                do
                {
                    sum[i] = arr[i] + arr2[i];
                    Console.Write(sum[i]+ " ");
                    i++;
                } while (i <= border - 1);

            }
            
        }
    }
}
