using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson3.Task3
{
    public class Task : IRunnable
    {
        public void Run(IConsole console)
        {
            console.WriteLine("------------------Lesson3 Task3-----------------------");
            int rectX, rectY, sqX, sqY, figX, figY;
            console.Write("Input X for figure: ");
            while (!Int32.TryParse(console.ReadLine(), out figX))
            {
                console.WriteLine("Error");
            }
            console.Write("Input Y for figure: ");
            while (!Int32.TryParse(console.ReadLine(), out figY))
            {
                console.WriteLine("Error");
            }
            Figure figure = new Figure(figX, figY);
            figure.Draw(console);
            console.Write("Input X for rectangle: ");
            while (!Int32.TryParse(console.ReadLine(), out rectX))
            {
                console.WriteLine("Error");
            }
            console.Write("Input Y for rectangle: ");
            while (!Int32.TryParse(console.ReadLine(), out rectY))
            {
                console.WriteLine("Error");
            }
            Rectangle rectangle = new Rectangle(rectX, rectY);
            rectangle.Draw(console);
            console.Write("Input X for square: ");
            while (!Int32.TryParse(console.ReadLine(), out sqX))
            {
                console.WriteLine("Error");
            }
            console.Write("Input Y for square: ");
            while (!Int32.TryParse(console.ReadLine(), out sqY))
            {
                console.WriteLine("Error");
            }
            Square square = new Square(sqX, sqY);
            square.Draw(console);
            console.WriteLine("------------------------------------------------------");
        }
    }
}
