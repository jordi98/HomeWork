using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson2.Task4
{    
    public class Task : IRunnable
    {
        public void Run()
        {
            Console.WriteLine("------------------Lesson2 Task4-----------------------");
            Extensions.Sort();
            Console.WriteLine("------------------------------------------------------");
        }
    }
}
