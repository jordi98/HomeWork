using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson10.Task1
{
    public class Task : IRunnable
    {
        public void Run(IConsole console)
        {
            console.WriteLine("------------------Lesson10 Task1-----------------------");
            int i = RecursiveMethod();
            console.WriteLine("------------------------------------------------------");
        }

        private static int RecursiveMethod()
        {
            return RecursiveMethod();
        }
    }
}
