using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson7.Task1
{
    public class Task : IRunnable
    {
        public void Run(IConsole console)
        {
            console.WriteLine("------------------Lesson7 Task1-----------------------");
            var list = new List<Person>
            {
                new Person { Name = "Andy", Age = 22, PhoneNumbers = new string[] { "111", "222", "333", "2735" } },
                new Person { Name = "Bruce", Age = 19, PhoneNumbers = new string[] { "444", "442", "553", "1346" } },
                new Person { Name = "Collin", Age = 16, PhoneNumbers = new string[] { "166", "277", "838" } },
                new Person { Name = "Danny", Age = 25, PhoneNumbers = new string[] { "199", "929", "963", "852", "179" } },
                new Person { Name = "Ethan", Age = 36, PhoneNumbers = new string[] { "1234", "252", "563" } },
                new Person { Name = "Facundo", Age = 27, PhoneNumbers = new string[] { "135", "4552", "342" } }
            };

            console.WriteLine(string.Join(string.Empty, list.Select(l => $"Name: {l.Name} Age: {l.Age}\n")));
            console.WriteLine("------------------------------------------------------");
        }
    }
}
