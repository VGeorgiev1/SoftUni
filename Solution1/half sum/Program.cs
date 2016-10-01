using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace half_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int[] array;
            int equal = 0;
            int max;
            
           for(int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine);
                sum = sum + array[i];
                               
            }
            max = array[0];
           for(int i =0;i < n; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }

                if (array[i] == sum)
                {
                    equal = 1;
                }

            }
            if (equal == 1)
            {
                
                Console.WriteLine("Yes");
                Console.WriteLine("Sum=" + sum);
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine("Diff="+ )

            }
        }
    }
}
