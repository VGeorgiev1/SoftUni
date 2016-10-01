using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatinLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstletter = 'a';
            char lastletter = 'z';
            for(firstletter='a'; firstletter <= lastletter; firstletter++)
            {
                Console.WriteLine(firstletter);

            }
        }
    }
}
