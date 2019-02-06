using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson2.Task5
{
    enum LongRange : long { Max = 9223372036854775807, Min = -9223372036854775808 }

    public class Task : IRunnable
    {
        public void Run(IConsole console)
        {
            console.WriteLine("------------------Lesson2 Task5-----------------------");
            foreach (var item in Enum.GetValues(typeof(LongRange)))
            {
                console.WriteLine($"{item} = {(long)item}");
            }
            console.WriteLine("------------------------------------------------------");
        }
    }
}
