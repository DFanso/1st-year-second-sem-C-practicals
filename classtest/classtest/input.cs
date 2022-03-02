using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classtest
{
    internal class input
    {
        public int age;
        public string name;

        public void inputs()
        {
            Console.WriteLine("Enter Your Name: ");
            name = Console.ReadLine();

            Console.WriteLine("Enter Your Age: ");
            age = int.Parse(Console.ReadLine());

            Console.WriteLine("Hello " + name + " welocme & you are " + age + " years old");
        }

    }
}
