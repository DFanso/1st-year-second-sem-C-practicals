using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance_task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal objanimal = new Animal();

            Dog objdog = new Dog();
            objanimal.print();

            Console.Write(" ");

            objdog.doglegs();

            Console.ReadKey();

            
        }
    }
}
