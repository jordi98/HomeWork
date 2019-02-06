using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson3.Task1
{
    public class Task: IRunnable
    {
        public void Run(IConsole console)
        {
            Rectangle rectangle = new Rectangle();
            rectangle.Draw(console);
            Square square = new Square();
            square.Draw(console);
        }
    }
}
