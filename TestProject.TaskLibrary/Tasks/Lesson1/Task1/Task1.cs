using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson1.Task1
{
    public class Task1 : IRunnable
    {
        public void Run(IConsole console)
        {
            console.WriteLine("--------------------------Lesson1 Task1--------------------");
            double xA = 0, yA = 0, xC = 0, yC = 0;
            console.Write("Input X coordinate of top left rectangle corner: ");
            while (!double.TryParse(console.ReadLine(), out xA))
            {
                console.WriteLine("Error");
            }

            console.Write("Input Y coordinate of top left rectangle corner: ");
            while (!double.TryParse(console.ReadLine(), out yA))
            {
                console.WriteLine("Error");
            }

            console.Write("Input X coordinate of bottom right rectangle corner: ");
            while (!double.TryParse(console.ReadLine(), out xC))
            {
                console.WriteLine("Error");
            }

            console.Write("Input Y coordinate of bottom right rectangle corner: ");
            while (!double.TryParse(console.ReadLine(), out yC))
            {
                console.WriteLine("Error");
            }

            if (xC > xA && yA > yC)
            {
                Rectangle abcd = new Rectangle(xA, yA, xC, yC);
                console.WriteLine($"Perimeter is {abcd.Perimeter()}.\nSquare is {abcd.Square()}.");
            }
            else
            {
                console.WriteLine("Cannot build rectangle! You must input correct values");
            }

            console.WriteLine("-------------------------------------------------------");
        }
    }
}