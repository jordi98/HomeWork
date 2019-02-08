using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson3.Task4
{
    public class Task : IRunnable
    {
        public void Run(IConsole console)
        {
            console.WriteLine("------------------Lesson3 Task4-----------------------");

            console.WriteLine("------------------------------------------------------");
        }
    }
}
