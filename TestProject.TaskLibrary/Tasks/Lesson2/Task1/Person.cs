using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson2.Task1
{
    public struct Person
    {
        public string Name;
        public string Surname;
        public int Age;

        public Person(string nam, string snam, int ag)
        {
            this.Name = nam;
            this.Surname = snam;
            this.Age = ag;
        }

        public void MyMethod(int n, IConsole console)
        {
            if (n > 0)
            {
                if (this.Age > n)
                {
                    console.WriteLine($"{this.Name} {this.Surname} older than {n}");
                }
                else
                {
                    console.WriteLine($"{this.Name} {this.Surname} younger than {n}");
                }
            }
            else
            {
                console.WriteLine("n must be > 0");
            }
        }
    }
}
