using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson1.Task2
{    
    public class Task2 : IRunnable
    {
        public void Run(IConsole console)
        {
            console.WriteLine("--------------------------Lesson1 Task2--------------------");
            double Ax = 0, Ay = 0, Cx = 0, Cy = 0;
            console.Write("Input X coordinate of top left rectangle corner: ");
            while (!Double.TryParse(console.ReadLine(), out Ax))
            {
                console.WriteLine("Error");
            }
            console.Write("Input Y coordinate of top left rectangle corner: ");
            while (!Double.TryParse(console.ReadLine(), out Ay))
            {
                console.WriteLine("Error");
            }
            console.Write("Input X coordinate of bottom right rectangle corner: ");
            while (!Double.TryParse(console.ReadLine(), out Cx))
            {
                console.WriteLine("Error");
            }
            console.Write("Input Y coordinate of bottom right rectangle corner: ");
            while (!Double.TryParse(console.ReadLine(), out Cy))
            {
                console.WriteLine("Error");
            }

            if (Cx > Ax && Ay > Cy)
            {
                Rectangle ABCD = new Rectangle(Ax, Ay, Cx, Cy);
                console.WriteLine($"Perimeter is {ABCD.Perimeter}.\nSquare is {ABCD.Square}.");
            }
            else
            {
                console.WriteLine("Cannot build rectangle! You must input correct values");
            }
            console.WriteLine("-------------------------------------------------------");
        }
    }
}
