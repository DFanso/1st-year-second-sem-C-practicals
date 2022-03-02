using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace check_student_grade_with_class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int marks;

            Console.WriteLine("Enter Your Marks");
            marks = int.Parse(Console.ReadLine());

            grade objnewgrade = new grade();
            objnewgrade.checkgrade(marks);

            Console.ReadKey();
        }
    }
}
