using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson2.Task1
{
    public class Task : IRunnable
    {
        public void Run()
        {
            Console.WriteLine("------------------Lesson2 Task1-----------------------");
            string name, surname;
            int age = 0, n;
            Console.Write("Input name: ");
            name = Console.ReadLine();
            Console.Write("Input surname: ");
            surname = Console.ReadLine();
            Console.Write("Input age: ");
            while (age <= 0) 
            {
                while (!Int32.TryParse(Console.ReadLine(), out age))
                {
                    Console.WriteLine("Error");
                }
            }            
            Person person = new Person(name, surname, age);
            Console.Write("Input n: ");
            while (!Int32.TryParse(Console.ReadLine(), out n))
            {
                Console.WriteLine("Error");
            }
            person.MyMethod(n);
            Console.WriteLine("-----------------------------------------");
        }
    }
}
