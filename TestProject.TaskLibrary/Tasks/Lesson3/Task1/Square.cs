using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson3.Task1
{
    public class Square : Figure
    {
        public override void Draw(IConsole console)
        {
            Console.WriteLine("Class Square");
        }
    }
}
