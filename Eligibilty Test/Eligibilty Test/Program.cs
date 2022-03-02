using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eligibilty_Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            int age;

            Console.WriteLine("Enter Your name: ");
            name = Console.ReadLine();

            Console.WriteLine("Enter Your age: ");
            age = int.Parse(Console.ReadLine());

            if (age >= 18)
            {
                Console.WriteLine("Hi" + name + "You are eligible for voting");

            }
            else
            {
                Console.WriteLine("Hi " + name + " You are not eligible for voting");
            }
            Console.ReadKey();
        }
    }
}
