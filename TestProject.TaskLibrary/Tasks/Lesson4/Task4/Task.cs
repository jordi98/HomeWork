using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson4.Task4
{
    public class Task : IRunnable
    {
        public void Run(IConsole console)
        {
            console.WriteLine("------------------Lesson4 Task4-----------------------");
            int n, m;
            console.Write("Input array dim m: ");
            while (!Int32.TryParse(console.ReadLine(), out m))
            {
                console.WriteLine("Error");
            }
            console.Write("Input array dim n: ");
            while (!Int32.TryParse(console.ReadLine(), out n))
            {
                console.WriteLine("Error");
            }
            int[,] array = new int[m, n];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    console.Write($"Array[{i}][{j}]: ");
                    while (!Int32.TryParse(console.ReadLine(), out array[i, j]))
                    {
                        console.WriteLine("Error");
                    }
                }
            }
            console.WriteLine("Your array: ");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    console.Write($"{array[i, j]} ");
                }
                console.Write("\n");
            }
            int[] vector = new int[m];            
            for (int i = 0; i < m; i++)
            {
                vector[i] = array[i, 0];
                for (int j = 1; j < n; j++)
                {
                    if (array[i, j] > vector[i])
                    {
                        vector[i] = array[i, j];
                    }
                }
            }
            console.Write("Vector:\n");
            for (int i = 0; i < m; i++)
            {
                console.Write($"{vector[i]} ");
            }
            console.WriteLine("\n------------------------------------------------------");
        }
    }
}
