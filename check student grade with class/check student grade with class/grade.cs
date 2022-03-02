using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace check_student_grade_with_class
{
    internal class grade
    {
        public void checkgrade(int marks)
        {
            if (marks >= 75 && marks <= 100)
            {
                Console.WriteLine("Your Grade is 'A'");
            }

            else if (marks >= 65 && marks <= 74)
            {
                Console.WriteLine("Your Grade is 'B'");
            }

            else if (marks >= 50 && marks <= 64)
            {
                Console.WriteLine("Your Grade is 'C'");
            }

            else if (marks >= 40 && marks <= 49)
            {
                Console.WriteLine("Your Grade is 'D'");
            }

            else if (marks <=39)
            {
                Console.WriteLine("Your Grade is 'F'");
            }

            else
            {
                Console.WriteLine("Invalid Input");
            }
        }
    }
}
