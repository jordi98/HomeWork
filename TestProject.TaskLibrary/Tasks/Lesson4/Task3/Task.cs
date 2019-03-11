using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson4.Task3
{
    public class Task : IRunnable
    {
        public void Run(IConsole console)
        {
            console.WriteLine("------------------Lesson4 Task3-----------------------");
            int n;
            console.Write("Input array dim: ");
            while (!int.TryParse(console.ReadLine(), out n))
            {
                console.WriteLine("Error");
            }

            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                console.Write($"Array[{i}]: ");
                while (!int.TryParse(console.ReadLine(), out array[i]))
                {
                    console.WriteLine("Error");
                }
            }

            console.Write("Your array: ");
            for (int i = 0; i < n; i++)
            {
                console.Write($"{array[i]} ");
            }

            int c = 0, k = n - 1;
            bool check = false;
            while (c < n / 2 && k >= n / 2)
            {
                if (array[c] == array[k])
                {
                    check = true;
                    c++;
                    k--;
                }
                else
                {
                    check = false;
                    break;
                }
            }

            if (check)
            {
                console.WriteLine("\nArray is simetrical");
            }
            else
            {
                console.WriteLine("\nArray is not simetrical");
            }

            console.WriteLine("------------------------------------------------------");
        }
    }
}
