using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson2.Task4
{    
    public class Task : IRunnable
    {
        public void Run(IConsole console)
        {
            console.WriteLine("------------------Lesson2 Task4-----------------------");
            Extensions.Sort(console);
            console.WriteLine("------------------------------------------------------");
        }
    }
}
