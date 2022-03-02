using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace excercise_1
{
    internal class student
    {
        int indexno;
        string name;
        string city;

        public void setVal(int i,string n, string c)
        {
            indexno = i;
            name = n;
            city = c;
        }

        public void display()
        {
            Console.WriteLine("Studnet Index no: " + indexno);
            Console.WriteLine("Studnet name: " + name);
            Console.WriteLine("Studnet City: " + city);
        }
    }
}
