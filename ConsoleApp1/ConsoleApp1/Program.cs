using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person Tunar = new Student("Tunar", "Namazov", 100, 21);
            Person Elnur = new Teacher("Elnur", "Xelilov", 4000, 22);
            Person Leman = new Student("Leman", "Yaqubova", 100, 19);
            Console.WriteLine(Leman.ShowInfo());
        }
    }
}
