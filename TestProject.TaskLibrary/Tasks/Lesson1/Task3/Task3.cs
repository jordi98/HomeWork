using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson1.Task3
{
    public class Task3 : IRunnable
    {
        public void Run()
        {
            Console.WriteLine("--------------------------Task3--------------------");
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
