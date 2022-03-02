using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_to_get_vehicle_name_from_wheels
{
    internal class Program
    {
        static void Main(string[] args)
        {
            vehicle objnewvehicle = new vehicle();

            objnewvehicle.check();

            Console.ReadKey();
        }
    }
}
