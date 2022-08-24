using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    abstract class Person
    {

        private static int _id;
        private static string  _name; 
        private static string  _surname; 
        private static int  _age;
        private int id;


        public int Id { get => id; }
        public string Name { get => _name; set => _name = value; }
        public string SurName { get=>_surname; set=>_surname= value; }
        public int  Age { get=>_age; set=>_age=value; }
        public Person(string Name, string Surname, int Age)
        {
            id = ++_id;
            this.Name = Name;
            this.SurName = Surname;
            this.Age = Age;
        }

        public abstract string ShowInfo();
        
               
        
           
    }
}   