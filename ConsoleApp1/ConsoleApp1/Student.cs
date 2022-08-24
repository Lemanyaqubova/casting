using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Student : Person
    {
        public float Point { get; set; }

        public Student(string Name, string Surname, float Point,int Age):base(Name,Surname,Age)
        {
          
            this.Name = Name;
           this.SurName = Surname;
            this.Point = Point;

        }
        public static bool operator>(Student str1, Student str2)
        {
            return str1.Point > str2.Point;
        }
        public static bool operator <(Student str1, Student str2)
        {
            return str1.Point < str2.Point;
        }

        public override string ShowInfo()
        {
            return ("Id:" + Id + "/nName:" + Name + "SurName:" + SurName + "Age:" + Age + "Point:"+ Point);

        }
    }
}
