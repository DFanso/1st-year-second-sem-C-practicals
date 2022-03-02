using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace encapClass_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, sum;

            Console.WriteLine("Enter Your number 1: ");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Your number 2: ");
            num2 = int.Parse(Console.ReadLine());

            encapClass objencapClass = new encapClass();

            objencapClass.Setnumbers(num1, num2);

            Console.WriteLine("Sum is: " + objencapClass.getSum());

            Console.ReadKey();


        }
    }
}
