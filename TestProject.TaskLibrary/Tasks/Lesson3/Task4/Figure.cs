using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson3.Task4
{
    public class Figure : IDrawable
    {
        public Figure(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public int X { get; private set; }

        public int Y { get; private set; }

        public virtual void Draw(IConsole console)
        {
            console.WriteLine($"Class Figure {X} {Y}");
        }
    }
}
