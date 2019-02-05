using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson2.Task2
{
    public class Task : IRunnable
    {
        public void Run()
        {
            Console.WriteLine("------------------Lesson2 Task2-----------------------");
            double width = 0, height = 0, x, y;
            Console.Write("Input width: ");
            while (width <= 0)
            {
                while (!Double.TryParse(Console.ReadLine(), out width))
                {
                    Console.WriteLine("Error");
                }
            }            
            Console.Write("Input height: ");
            while (height <= 0)
            {
                while (!Double.TryParse(Console.ReadLine(), out height))
                {
                    Console.WriteLine("Error");
                }
            }
            Console.Write("Input x: ");
            while (!Double.TryParse(Console.ReadLine(), out x))
            {
                Console.WriteLine("Error");
            }
            Console.Write("Input y: ");
            while (!Double.TryParse(Console.ReadLine(), out y))
            {
                Console.WriteLine("Error");
            }
            Rectangle rectangle = new Rectangle();
            rectangle.Width = width;
            rectangle.Height = height;
            rectangle.X = x;
            rectangle.Y = y;
            Console.WriteLine($"Perimeter is {rectangle.Perimeter()}");
            Console.WriteLine("--------------------------------------------------");

        }
    }
}
