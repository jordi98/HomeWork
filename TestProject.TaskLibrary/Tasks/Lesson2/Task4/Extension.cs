using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson2.Task4
{
    enum Colors { Red = 5, Blue = 4, White = 6, Black = 3, Green = 1, Yellow = 2, Violet = 7 }

    public static class Extensions
    {
        public static void Sort(IConsole console)
        {
            foreach (var item in Enum.GetValues(typeof(Colors)))
            {
                console.WriteLine($"{item} = {(int)item}");
            }
        }
    }
}
