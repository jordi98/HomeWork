using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson4.Task1
{
    public class Task : IRunnable
    {
        public void Run(IConsole console)
        {
            console.WriteLine("------------------Lesson4 Task1-----------------------");
            int n;
            console.Write("Input array dim: ");
            while (!Int32.TryParse(console.ReadLine(), out n))
            {
                console.WriteLine("Error");
            }
            int[] array = new int[n];
            int[] array2 = array;
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
            console.Write("\nNew array: ");
            for (int i = 0; i < n; i++)
            {
                array2[i] = array[i] * array[i] * array[i];
                console.Write($"{array2[i]} ");
            }
            console.WriteLine("\n------------------------------------------------------");
        }
    }
}
