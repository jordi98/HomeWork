using System;
using System.Collections.Generic;
using System.Text;

namespace TestProject.TaskLibrary.Tasks.Lesson2.Task1
{
    public struct Person
    {
        public string name;
        public string surname;
        public int age;
        public Person(string nam, string snam, int ag)
        {
            name = nam;
            surname = snam;
            age = ag;
        }
        public void MyMethod(int n)
        {
            if (n > 0)
            {
                if (age > n)
                {
                    Console.WriteLine($"{name} {surname} older than {n}");
                }
                else
                    Console.WriteLine($"{name} {surname} younger than {n}");
            }
            else
                Console.WriteLine("n must be > 0");
        }
    }
}
