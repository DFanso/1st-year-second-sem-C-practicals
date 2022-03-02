using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circumfarance
{
    internal class circle
    {
        private double radius;
        private double pi = 3.14;

        public void setRadius(double UserRadius)
        {
            radius = UserRadius;
        }

        public double getCircumference()
        {
            return 2 * pi * radius;
        }

        public double getArea()
        {
            return pi * radius * radius;
        }
    }
}
