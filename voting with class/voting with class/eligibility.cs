using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace voting_with_class
{
    internal class eligibility
    {
        public string checkeli(int age)
        {
            if (age >= 18)
            {
                return "Eligible for voting";
            }
            else
            {
                return "Not Eligible for voting";
            }
        }
    }
}
