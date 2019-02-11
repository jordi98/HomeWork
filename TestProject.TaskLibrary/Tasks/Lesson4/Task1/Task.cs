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
            int[] array = new int[5] { 1, 2, 3, 4, 5 };
            int[] array2 = new int[5];
            for (int i = 0; i < 5; i++)
            {
                array2[i] = (int)Math.Pow(array[i], 3);
            }
            for (int i = 0; i < 5; i++)
            {
                console.Write($"{array2[i]} ");
            }
            console.WriteLine("\n------------------------------------------------------");
        }
    }
}
