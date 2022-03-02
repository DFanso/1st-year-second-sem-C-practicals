using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace excercise_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            student objs1 = new student();
            objs1.setVal(777, "Eranga", "Colombo");
            objs1.display();

            Console.ReadKey();

        }
    }
}