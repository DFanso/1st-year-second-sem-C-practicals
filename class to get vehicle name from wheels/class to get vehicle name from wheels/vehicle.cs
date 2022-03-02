using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_to_get_vehicle_name_from_wheels
{
    internal class vehicle
    {
        public int wheels;

        public void check()
        {
            Console.WriteLine("How many wheels");
            wheels = int.Parse(Console.ReadLine());

            if(wheels == 2)
            {
                Console.WriteLine("Bicyle");
            }
            else if (wheels == 3)
            {
                Console.WriteLine("Threewheel");
            }
            else if (wheels == 4)
            {
                Console.WriteLine("car");
            }
            else if (wheels >= 5)
            {
                Console.WriteLine("Mutli-purpouse Vehicles");
            }
            else
            {
                Console.WriteLine("invalid inuput");
            }
        }
    }
}
