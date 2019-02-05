using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson1.Task2
{    
    public class Task2 : IRunnable
    {
        public void Run()
        {
            Console.WriteLine("--------------------------Lesson1 Task2--------------------");
            double Ax = 0, Ay = 0, Cx = 0, Cy = 0;
            Console.Write("Input X coordinate of top left rectangle corner: ");
            while (!Double.TryParse(Console.ReadLine(), out Ax))
            {
                Console.WriteLine("Error");
            }
            Console.Write("Input Y coordinate of top left rectangle corner: ");
            while (!Double.TryParse(Console.ReadLine(), out Ay))
            {
                Console.WriteLine("Error");
            }
            Console.Write("Input X coordinate of bottom right rectangle corner: ");
            while (!Double.TryParse(Console.ReadLine(), out Cx))
            {
                Console.WriteLine("Error");
            }
            Console.Write("Input Y coordinate of bottom right rectangle corner: ");
            while (!Double.TryParse(Console.ReadLine(), out Cy))
            {
                Console.WriteLine("Error");
            }

            if (Cx > Ax && Ay > Cy)
            {
                Rectangle ABCD = new Rectangle(Ax, Ay, Cx, Cy);
                Console.WriteLine($"Perimeter is {ABCD.Perimeter}.\nSquare is {ABCD.Square}.");
            }
            else
            {
                Console.WriteLine("Cannot build rectangle! You must input correct values");
            }
            Console.WriteLine("-------------------------------------------------------");
        }
    }
}
