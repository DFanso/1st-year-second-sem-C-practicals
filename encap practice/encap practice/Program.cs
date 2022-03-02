using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace encap_practice
{
    internal class Program
    {
        static void Main(string[] args)


        {
            int age;
            string name;

            encapClass objencapClass = new encapClass();

            Console.WriteLine("Enter Your Age: ");
            objencapClass.setAge(age=int.Parse(Console.ReadLine()));

            Console.WriteLine("Enter Your Name: ");
            objencapClass.setName(name = Console.ReadLine());


            Console.WriteLine("Your age is: " + objencapClass.getAge());
            Console.WriteLine("Your Name is: " + objencapClass.getName());

            Console.ReadKey();
        }
    }
}
