using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parameter_addition_with_class
{
    internal class Program
    {
        static void Main(string[] args)


        {
            int num1,num2;

            Console.WriteLine("Enter number 1");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter number 2");
            num2 = int.Parse(Console.ReadLine());

            operation objnewoperationadd = new operation();
            objnewoperationadd.add(num1,num2);

            operation objnewoperationsub = new operation();
            objnewoperationsub.sub(num1, num2);

            Console.ReadKey();
        }
    }
}
