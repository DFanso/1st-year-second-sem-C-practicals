using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_q5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            int output;

            Console.WriteLine("Enter number 1: ");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter number 2: ");
            num2 = int.Parse(Console.ReadLine());


            calculation objnewcalculation = new calculation();
            output = objnewcalculation.mul(num1,num2);

            Console.WriteLine("Output: " + output);

            Console.ReadKey();

        }
    }
}
