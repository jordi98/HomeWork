using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson3.Task2
{
    public abstract class Figure
    {
        public int X { get; private set; }
        public int Y { get; private set; }
        
        public Figure(int x, int y)
        {
            X = x;
            Y = y;
        }
        public abstract void Draw(IConsole console);
    }
}
