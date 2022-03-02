using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace encapClass_2
{
    internal class encapClass
    {
        private int num1, num2;


        public void Setnumbers(int no1,int no2)
        {
            num1 = no1;
            num2 = no2;
        }

        public int getSum()
        {
            return num1 + num2;
        }


    }
}
