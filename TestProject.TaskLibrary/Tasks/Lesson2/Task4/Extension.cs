using System;
using System.Collections.Generic;
using System.Text;

namespace TestProject.TaskLibrary.Tasks.Lesson2.Task4
{
    enum Colors { Red = 5, Blue = 4, White = 6, Black = 3, Green = 1, Yellow = 2, Violet = 7 }

    public static class Extensions
    {
        public static void Sort()
        {
            foreach (var item in Enum.GetValues(typeof(Colors)))
            {
                Console.WriteLine($"{item} = {(int)item}");
            }
        }
    }
}
