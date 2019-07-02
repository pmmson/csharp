using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    public class Student
    {
        string FI;
        int course;
        int age;

        public Student()
        {

        }

        public string FIO
        {
            get { return FI; }
            set { FI = value; }
        }
        public int Course
        {
            get { return course; }
            set { course = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public Student(string FI, int course, int age)
        {
            this.FI = FI;
            this.course = course;
            this.age = age;
        }
    }
}
