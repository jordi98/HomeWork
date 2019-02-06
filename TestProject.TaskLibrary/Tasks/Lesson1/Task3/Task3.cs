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
