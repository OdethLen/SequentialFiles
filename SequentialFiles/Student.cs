using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SequentialFiles
{
    internal class Student
    {
        public string Name;
        public string Age;
        public string Gender;
        public string Year;
        public string Course;

        public Student() 
        {
            Name = "";
            Age = "";
            Gender = "";
            Year = "";
            Course = "";
        }

        public Student(string name, string age, string gender, string year, string course)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
            this.Year = year;
            this.Course = course;
        }

        public override string ToString() 
        {
            return "Name: " + Name + "Age: " + Age + "Gender:" + Gender + "Year: " + Year + "Course:" + Course;
        }
        
    }
}
