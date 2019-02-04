using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson1.Task4
{
    public class Task4 : IRunnable
    {
        public void Run()
        {
            Console.WriteLine("--------------------------Task4--------------------");
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
                Console.WriteLine($"Perimeter is {Rectangle.Perimeter(Ax, Ay, Cx, Cy)}.\nSquare is {Rectangle.Square(Ax, Ay, Cx, Cy)}.");
            }
            else
            {
                Console.WriteLine("Cannot build rectangle! You must input correct values");
            }
            double R = 0;
            while (R <= 0)
            {
                Console.Write("Input radius of circle: ");
                while (!Double.TryParse(Console.ReadLine(), out R))
                {
                    Console.WriteLine("Error");
                }
                //Console.WriteLine("Cannot build circle! You must input correct values");
            }
            Console.WriteLine($"Length is {Circle.Length(R)}.\nSquare is {Circle.Square(R)}.");
            Console.WriteLine("-------------------------------------------------------");
        }
    }
}
