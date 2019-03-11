using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson5.Task3
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

        public List<string> RemoveDuplicates(List<string> list)
        {
            var result = new List<string>();

            for (int i = 0; i < list.Count; i++)
            {
                if (!result.Contains(list[i]))
                {
                    result.Add(list[i]);
                }
            }

            return result;
        }

        public void DisplayPage(IConsole console, List<string> list, int pageNumber)
        {
            var countPages = (int)Math.Ceiling(list.Count / 5.0);            
            if (pageNumber > 0 && pageNumber <= countPages)
            {
                console.WriteLine($"Page {pageNumber}");
                if (pageNumber == countPages)
                {
                    for (int i = (pageNumber - 1) * 5; i < list.Count; i++)
                    {
                        console.WriteLine($"{list[i]}");
                    }
                }
                else
                {
                    for (int i = (pageNumber - 1) * 5; i < pageNumber * 5; i++)
                    {
                        console.WriteLine($"{list[i]}");
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
            console.WriteLine("------------------Lesson5 Task3-----------------------");
            int pageNumber, numberOfItemsInList;
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

            var noDupList = this.RemoveDuplicates(list);
            for (int i = 0; i < noDupList.Count; i++)
            {
                if (noDupList[i][0] == 'Z')
                {
                    noDupList.RemoveAt(i);
                }
            }

            noDupList.Sort();
            noDupList.Reverse();
            console.WriteLine($"Count before: {list.Count} ({(int)Math.Ceiling(list.Count / 5.0)} pages)");
            console.WriteLine($"Count after: {noDupList.Count} ({(int)Math.Ceiling(noDupList.Count / 5.0)} pages)");
            console.Write($"Input number of page: ");
            if (!int.TryParse(console.ReadLine(), out pageNumber))
            {
                console.WriteLine("Error!");
            }
            else
            {
                this.DisplayPage(console, noDupList, pageNumber);
            }

            console.WriteLine("\n------------------------------------------------------");
        }
    }
}
