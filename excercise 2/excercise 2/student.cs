using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPRevision
{
    internal class Student
    {
        private int indexNO;
        private string name;
        private string city;

        public int getIndexNo()
        {
            return indexNO;
        }
        public void setIndexNo(int indexNo)
        {
            indexNO = indexNo;
        }
        public string getName()
        {
            return name;
        }
        public void setName(string Name)
        {
            name = Name;
        }
        public string getCity()
        {
            return city;
        }
        public void setCity(string City)
        {
            city = City;
        }

        public void printValues()
        {
            Console.WriteLine("Index NO: " + indexNO);
            Console.WriteLine("Name: " + name);
            Console.WriteLine("City: " + city);
        }
    }
}