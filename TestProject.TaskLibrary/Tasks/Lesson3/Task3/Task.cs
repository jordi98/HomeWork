using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson3.Task3
{
    public class Task : IRunnable
    {
        public void Run(IConsole console)
        {
            Figure figure = new Figure(1, 2);
            figure.Draw(console);
            Rectangle rectangle = new Rectangle(3, 4);
            rectangle.Draw(console);
            Square square = new Square(5, 6);
            square.Draw(console);
        }
    }
}
