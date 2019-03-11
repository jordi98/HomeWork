using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson4.Task5
{
    public class Task : IRunnable
    {
        public void Run(IConsole console)
        {
            console.WriteLine("------------------Lesson4 Task5-----------------------");
            int m;
            console.Write("Input array dim m: ");
            while (!int.TryParse(console.ReadLine(), out m))
            {
                console.WriteLine("Error");
            }

            int[][] array = new int[m][];
            for (int i = 0; i < m; i++)
            {
                array[i] = new int[i + 1];
                for (int j = 0; j < array[i].Length; j++)
                {
                    console.Write($"Array[{i}][{j}]: ");
                    while (!int.TryParse(console.ReadLine(), out array[i][j]))
                    {
                        console.WriteLine("Error");
                    }
                }
            }

            console.WriteLine("Your array: ");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    console.Write($"{array[i][j]} ");
                }

                console.Write("\n");
            }

            int[] vector = new int[m];
            for (int i = 0; i < m; i++)
            {
                vector[i] = array[i][0];
                for (int j = 1; j < array[i].Length; j++)
                {
                    if (array[i][j] > vector[i])
                    {
                        vector[i] = array[i][j];
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
