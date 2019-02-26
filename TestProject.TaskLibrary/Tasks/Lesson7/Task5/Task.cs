using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson7.Task5
{
    public class Task : IRunnable
    {
        public string GenerateElements(int length, Random random)
        {
            string characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            StringBuilder result = new StringBuilder(length);
            for (int i = 0; i < length; i++)
            {
                result.Append(characters[random.Next(characters.Length)]);
            }

            return result.ToString();
        }

        public void DisplayPage(IConsole console, IEnumerable<string> list, int pageNumber)
        {
            var countPages = (int)Math.Ceiling(list.Count() / 5.0);            
            if (pageNumber > 0 && pageNumber <= countPages)
            {
                console.WriteLine($"Page {pageNumber}");
                if (pageNumber == countPages)
                {
                    for (int i = (pageNumber - 1) * 5; i < list.Count(); i++)
                    {
                        console.WriteLine($"{list.ElementAt(i)}");
                    }
                }
                else
                {
                    for (int i = (pageNumber - 1) * 5; i < pageNumber * 5; i++)
                    {
                        console.WriteLine($"{list.ElementAt(i)}");
                    }
                }
            }
            else
            {
                console.WriteLine("Error!");
            }
        }

        public void Run(IConsole console)
        {
            console.WriteLine("------------------Lesson7 Task5-----------------------");
            int numberOfItemsInList;
            Random rnd = new Random();
            var list = new List<string>();
            console.Write("Input number of items in the list: ");
            while (!int.TryParse(console.ReadLine(), out numberOfItemsInList))
            {
                console.WriteLine("Error!");
            }

            for (int i = 0; i < numberOfItemsInList; i++)
            {
                list.Add(this.GenerateElements(4, rnd));
            }

            IEnumerable<string> list2 = list.Where(l => !l.StartsWith('Z')).OrderByDescending(l => l).Select(l => l).Distinct();
            console.WriteLine($"Count before: {list.Count} ({(int)Math.Ceiling(list.Count / 5.0)} pages)");
            console.WriteLine($"Count after: {list2.Count()} ({(int)Math.Ceiling(list2.Count() / 5.0)} pages)");
            foreach (var item in list2)
            {
                console.WriteLine($"{item}");
            }

            console.Write($"Input number of page: ");
            if (!int.TryParse(console.ReadLine(), out int pageNumber))
            {
                console.WriteLine("Error!");
            }
            else
            {
                this.DisplayPage(console, list2, pageNumber);
            }

            console.WriteLine("\n------------------------------------------------------");
        }
    }
}
