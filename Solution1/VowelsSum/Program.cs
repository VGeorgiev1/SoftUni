using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VowelsSum
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int lenght;
            lenght = input.Length;
            int sum = 0;
            for(int i = 0; i < lenght; i++)
            {
                
                
            if(input[i] == 'a')
            {
                    sum = sum + 1;
            }
            if(input[i] == 'e')
            {
                    sum = sum + 2;
            }
            if (input[i] == 'i')
            {
                    sum = sum + 3;

            }
            if(input[i] == 'o')
            {
                    sum = sum + 4;
            }
            if(input[i] == 'u')
            {
                    sum = sum + 5;
            }

            }
            Console.WriteLine(sum);

        }
    }
}
