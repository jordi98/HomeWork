using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson7.Task3
{
    public class Task : IRunnable
    {
        public void Run(IConsole console)
        {
            console.WriteLine("------------------Lesson7 Task3-----------------------");
            var list = new List<Person>
            {
                new Person { Name = "Andy", Age = 22, PhoneNumbers = new string[] { "111", "222", "333", "2735" } },
                new Person { Name = "Bruce", Age = 19, PhoneNumbers = new string[] { "444", "442", "553", "1346" } },
                new Person { Name = "Collin", Age = 16, PhoneNumbers = new string[] { "166", "277", "838" } },
                new Person { Name = "Danny", Age = 25, PhoneNumbers = new string[] { "199", "929", "963", "852", "179" } },
                new Person { Name = "Ethan", Age = 36, PhoneNumbers = new string[] { "1234", "252", "563" } },
                new Person { Name = "Facundo", Age = 27, PhoneNumbers = new string[] { "135", "4552", "342" } },
                new Person { Name = "George", Age = 20, PhoneNumbers = new string[] { "1476", "1685", "9826" } },
                new Person { Name = "Helga", Age = 30, PhoneNumbers = new string[] { "246", "292", "97169", "9593" } }
        };
            Person[] people = new Person[2];
            people[0] = new Person { Name = "Jack", Age = 26, PhoneNumbers = new string[] { "1756", "0478", "6184", "12345" } };
            people[1] = new Person { Name = "Kate", Age = 31, PhoneNumbers = new string[] { "09876", "234", "865" } };
            list.AddRange(people);

            IEnumerable<string> query = list.SelectMany(p => p.PhoneNumbers);
            foreach (var item in query)
            {
                console.WriteLine($"{item}");
            }

            console.WriteLine("\n------------------------------------------------------");
        }
    }
}
