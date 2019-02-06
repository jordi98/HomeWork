using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson3.Task4
{
    public class Figure
    {
        public int X { get; private set; }
        public int Y { get; private set; }
        
        public Figure(int x, int y)
        {
            X = x;
            Y = y;
        }
        public virtual void Draw(IConsole console)
        {
            console.WriteLine($"Class Figure {X} {Y}");
        }
    }
}
