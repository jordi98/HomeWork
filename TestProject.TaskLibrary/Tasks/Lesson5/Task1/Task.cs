using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson5.Task1
{
    public class Task : IRunnable
    {
        public void Run(IConsole console)
        {
            console.WriteLine("------------------Lesson5 Task1-----------------------");
            var list = new List<Person>();
            list.Add(new Person { Name = "Andy", Age = 22, PhoneNumbers = new string[] { "111", "222", "333", "2735" } });
            list.Add(new Person { Name = "Bruce", Age = 19, PhoneNumbers = new string[] { "444", "442", "553", "1346" } });
            list.Add(new Person { Name = "Collin", Age = 16, PhoneNumbers = new string[] { "166", "277", "838" } });
            list.Add(new Person { Name = "Danny", Age = 25, PhoneNumbers = new string[] { "199", "929", "963", "852", "179" } });
            list.Add(new Person { Name = "Ethan", Age = 36, PhoneNumbers = new string[] { "1234", "252", "563" } });
            list.Add(new Person { Name = "Facundo", Age = 27, PhoneNumbers = new string[] { "135", "4552", "342" } });
            foreach (var item in list)
            {
                console.WriteLine($"Name: {item.Name} Age: {item.Age}");
            }
            console.WriteLine("------------------------------------------------------");
        }
    }
}
