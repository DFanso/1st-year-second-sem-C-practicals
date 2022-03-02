using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circumfarance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double userRadius;

            Console.WriteLine("Enter Radius");
            userRadius = double.Parse(Console.ReadLine());


            circle objcircle = new circle();
            objcircle.setRadius(userRadius);


            Console.WriteLine("Circumference is: "+ objcircle.getCircumference());
            Console.WriteLine("Area is: " + objcircle.getArea());

            Console.ReadKey();
        }
    }
}
