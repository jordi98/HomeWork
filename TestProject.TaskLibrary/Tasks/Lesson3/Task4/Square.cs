using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson3.Task4
{
    public class Square : Figure, IDrawable
    {
        public Square(int x, int y) : base(x, y)
        {

        }

        public override void Draw(IConsole console)
        {
            console.WriteLine($"Class Square {X} {Y}");
        }
    }
}
