using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace encap_practice
{
    internal class encapClass
    {
        private int age;
        private string name;

        public void setAge(int userAge)
        {
            age = userAge;
        }

        public int getAge()
        {
            return age;
        }

        public void setName(string userName)
        {
            name = userName;
        }

        public string getName()
        {
            return name;
        }
    }
}
