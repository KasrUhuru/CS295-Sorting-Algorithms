using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    public class Student
    {
        public string name;
        public double gpa;

        // Construct a student with only a name
        public Student(string name)
        {
            this.name = name;
        }

        //Construct a student with name and GPA
        public Student(string name, double gpa)
        {
            this.name = name;
            this.gpa = gpa;
        }
    }
}
