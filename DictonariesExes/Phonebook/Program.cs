using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> phonebook = new Dictionary<string, string>();
            string input =Console.ReadLine();
            while (input != "END")
            {
                string[] words = input.Split(' ');

                if (words[0] == "A")
                {
                    phonebook[words[1]] = words[2];
                    
                }
                else if (words[0] == "S")
                {
                    if (phonebook.ContainsKey(words[1]))
                    {
                        Console.WriteLine("{0} -> {1}", words[1], phonebook[words[1]]);
                    }
                    else
                    {
                        Console.WriteLine("Contact {0} does not exist.", words[1]);
                    }
                }
                input = Console.ReadLine();

            }

        }
    }
}
