using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson3.Task2
{
    public class Task : IRunnable
    {
        public void Run(IConsole console)
        {
            Rectangle rectangle = new Rectangle(1, 2);
            rectangle.Draw(console);
            Square square = new Square(3, 4);
            square.Draw(console);
        }
    }
}
