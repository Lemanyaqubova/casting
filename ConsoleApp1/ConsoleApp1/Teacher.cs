using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Teacher : Person
    {
        private static float _salary;

        public Teacher(string Name, string Surname, float Salary, int Age) : base(Name, Surname, Age)
        {
            this.Salary = Salary;
        }

        public float Salary { get; }

        public override string ShowInfo()
        {
            return ("Id:" + Id + "/nName:" + Name + "/nSurName:" + SurName + "/nAge:" + Age +"/nSalary" +Salary);
        }

        public static bool operator >(Teacher t1, Teacher t2)
        {
            return t1.Salary > t2.Salary;
        }
        public static bool operator <( Teacher t1, Teacher t2)
        {
            return t1.Salary < t2.Salary;
        }

    }

}
