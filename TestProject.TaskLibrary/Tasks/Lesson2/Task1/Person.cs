using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;

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
        public void MyMethod(int n, IConsole console)
        {
            if (n > 0)
            {
                if (age > n)
                {
                    console.WriteLine($"{name} {surname} older than {n}");
                }
                else
                    console.WriteLine($"{name} {surname} younger than {n}");
            }
            else
                console.WriteLine("n must be > 0");
        }
    }
}
