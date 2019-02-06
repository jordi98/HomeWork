using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson3.Task2
{
    public class Square : Figure
    {
        public Square(int x, int y) : base(x, y)
        {

        }
        public override void Draw(IConsole console)
        {
            Console.WriteLine($"Class Square {X} {Y}");
        }
    }
}
