using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson3.Task4
{
    public class Task : IRunnable
    {
        public void Run(IConsole console)
        {
            console.WriteLine("------------------Lesson3 Task4-----------------------");
            int rectX, rectY, sqX, sqY, figX, figY;
            console.Write("Input X for figure: ");
            while (!int.TryParse(console.ReadLine(), out figX))
            {
                console.WriteLine("Error");
            }

            console.Write("Input Y for figure: ");
            while (!int.TryParse(console.ReadLine(), out figY))
            {
                console.WriteLine("Error");
            }

            Figure figure = new Figure(figX, figY);
            console.Write("Input X for rectangle: ");
            while (!int.TryParse(console.ReadLine(), out rectX))
            {
                console.WriteLine("Error");
            }

            console.Write("Input Y for rectangle: ");
            while (!int.TryParse(console.ReadLine(), out rectY))
            {
                console.WriteLine("Error");
            }

            Rectangle rectangle = new Rectangle(rectX, rectY);
            console.Write("Input X for square: ");
            while (!int.TryParse(console.ReadLine(), out sqX))
            {
                console.WriteLine("Error");
            }

            console.Write("Input Y for square: ");
            while (!int.TryParse(console.ReadLine(), out sqY))
            {
                console.WriteLine("Error");
            }

            Square square = new Square(sqX, sqY);
            DrawAll(console, figure, rectangle, square);
            console.WriteLine("------------------------------------------------------");
        }

        private static void DrawAll(IConsole console, params IDrawable[] array)
        {
            foreach (var item in array)
            {
                item.Draw(console);
            }
        }
    }
}
