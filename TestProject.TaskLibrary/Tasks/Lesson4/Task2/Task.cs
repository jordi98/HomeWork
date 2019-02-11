using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson4.Task2
{
    public class Task : IRunnable
    {
        public void Run(IConsole console)
        {
            console.WriteLine("------------------Lesson4 Task2-----------------------");
            int countDiv, countSimple = 0;
            int[] array = new int[] { 3, 5, 7, 3, 5, 1, 4 };
            for (int i = 0; i < array.Length; i++)
            {
                countDiv = 0;
                for (int j = 1; j <= array[i]; j++)
                {
                    if (array[i] % j == 0)
                    {
                        countDiv++;
                    }
                }
                if (countDiv == 2)
                {
                    countSimple++;
                }
            }
            for (int i = 0; i < array.Length; i++)
            {
                console.Write($"{array[i]} ");
            }
            console.WriteLine($"\nCount of simple numbers: {countSimple}");            
            console.WriteLine("------------------------------------------------------");
        }
    }
}
