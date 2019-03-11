using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson1.Task3
{
    public class Task3 : IRunnable
    {
        public void Run(IConsole console)
        {
            console.WriteLine("--------------------------Lesson1 Task3--------------------");
            double radius = 0;
            while (radius <= 0)
            {
                console.Write("Input radius of circle: ");
                while (!double.TryParse(console.ReadLine(), out radius))
                {
                    console.WriteLine("Error");
                }
            }

            console.WriteLine($"Length is {Circle.Length(radius)}.\nSquare is {Circle.Square(radius)}.");
            console.WriteLine("-------------------------------------------------------");
        }
    }
}
