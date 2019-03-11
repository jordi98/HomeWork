﻿using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson3.Task2
{
    public class Rectangle : Figure
    {
        public Rectangle(int x, int y) : base(x, y)
        {

        }

        public override void Draw(IConsole console)
        {
            console.WriteLine($"Class Rectangle {X} {Y}");
        }
    }
}
