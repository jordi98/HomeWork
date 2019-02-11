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
            int n, countDiv, countSimple = 0;
            console.Write("Input array dim: ");
            while (!Int32.TryParse(console.ReadLine(), out n))
            {
                console.WriteLine("Error");
            }
            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                console.Write($"Array[{i}]: ");
                while (!Int32.TryParse(console.ReadLine(), out array[i]))
                {
                    console.WriteLine("Error");
                }
            }
            console.Write("Your array: ");
            for (int i = 0; i < n; i++)
            {
                console.Write($"{array[i]} ");
            }
            
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
            console.WriteLine($"\nCount of simple numbers: {countSimple}");            
            console.WriteLine("------------------------------------------------------");
        }
    }
}
