using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace voting_with_class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age;
            string output;

            Console.WriteLine("Enter user age");
            age = int.Parse(Console.ReadLine());

            eligibility objnewcheck = new eligibility();
            output=objnewcheck.checkeli(age);

            Console.WriteLine(output);

            Console.ReadKey();

        }
    }
}
