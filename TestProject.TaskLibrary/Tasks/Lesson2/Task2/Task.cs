using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson2.Task2
{
    public class Task : IRunnable
    {
        public void Run(IConsole console)
        {
            console.WriteLine("------------------Lesson2 Task2-----------------------");
            double width = 0, height = 0, x, y;
            console.Write("Input width: ");
            while (width <= 0)
            {
                while (!double.TryParse(console.ReadLine(), out width))
                {
                    console.WriteLine("Error");
                }
            }

            console.Write("Input height: ");
            while (height <= 0)
            {
                while (!double.TryParse(console.ReadLine(), out height))
                {
                    console.WriteLine("Error");
                }
            }

            console.Write("Input x: ");
            while (!double.TryParse(console.ReadLine(), out x))
            {
                console.WriteLine("Error");
            }

            console.Write("Input y: ");
            while (!double.TryParse(console.ReadLine(), out y))
            {
                console.WriteLine("Error");
            }

            Rectangle rectangle = new Rectangle
            {
                Width = width,
                Height = height,
                X = x,
                Y = y
            };
            console.WriteLine($"Perimeter is {rectangle.Perimeter()}");
            console.WriteLine("--------------------------------------------------");
        }
    }
}
