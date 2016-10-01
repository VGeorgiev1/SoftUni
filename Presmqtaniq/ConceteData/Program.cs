using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceteData
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            string town;
            string firstname;
            string lastname;
            firstname = Console.ReadLine();
            lastname = Console.ReadLine();
            age = int.Parse(Console.ReadLine());
            town = Console.ReadLine();

            Console.WriteLine("You are " + firstname +" "+ lastname + ", a " + age + "-years old person from " + town + ".");



        }
    }
}
