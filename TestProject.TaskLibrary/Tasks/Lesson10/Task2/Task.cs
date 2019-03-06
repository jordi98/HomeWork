using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson10.Task2
{
    public class Task : IRunnable
    {
        public void Run(IConsole console)
        {
            console.WriteLine("------------------Lesson10 Task2-----------------------");
            this.SomeMethod();
            console.WriteLine("------------------------------------------------------");
        }

        private void SomeMethod()
        {
            int[] values1 = { 1, 2, 3, 4, 5 };
            int[] values2 = new int[4];
            values2[values1.Length - 1] = values1[values1.Length - 1];
        }
    }
}
