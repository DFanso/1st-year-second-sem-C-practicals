using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odd_even_with_class
{
    internal class oddoreven

    {
        public int num;

        
            

            
        public void check()
        {
            Console.WriteLine("Enter your number");
            num = int.Parse(Console.ReadLine());


            if (num % 2 == 0)
            {
                Console.Write("This is an even number");
            }
            else
            {
                Console.Write("This is an odd number");
            }
        }

    }
}
