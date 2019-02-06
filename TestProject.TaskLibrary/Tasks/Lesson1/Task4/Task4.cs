using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson1.Task4
{
    public class Task4 : IRunnable
    {
        public void Run(IConsole console)
        {
            console.WriteLine("--------------------------Lesson1 Task4--------------------");
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
                Rectangle.SetSides(Ax, Ay, Cx, Cy);
                console.WriteLine($"Perimeter is {Rectangle.Perimeter()}.\nSquare is {Rectangle.Square()}.");
            }
            else
            {
                console.WriteLine("Cannot build rectangle! You must input correct values");
            }
            double R = 0;
            while (R <= 0)
            {
                console.Write("Input radius of circle: ");
                while (!Double.TryParse(console.ReadLine(), out R))
                {
                    console.WriteLine("Error");
                }
            }
            console.WriteLine($"Length is {Circle.Length(R)}.\nSquare is {Circle.Square(R)}.");
            console.WriteLine("-------------------------------------------------------");
        }
    }
}
