using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson2.Task1
{
    public class Task : IRunnable
    {
        public void Run(IConsole console)
        {
            console.WriteLine("------------------Lesson2 Task1-----------------------");
            string name, surname;
            int age = 0, n;
            console.Write("Input name: ");
            name = console.ReadLine();
            console.Write("Input surname: ");
            surname = console.ReadLine();
            console.Write("Input age: ");
            while (age <= 0) 
            {
                while (!Int32.TryParse(console.ReadLine(), out age))
                {
                    console.WriteLine("Error");
                }
            }            
            Person person = new Person(name, surname, age);
            console.Write("Input n: ");
            while (!Int32.TryParse(console.ReadLine(), out n))
            {
                console.WriteLine("Error");
            }
            person.MyMethod(n, console);
            console.WriteLine("-----------------------------------------");
        }
    }
}
