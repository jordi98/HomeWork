using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson6.Task1
{
    public class Task : IRunnable
    {
        public void Run(IConsole console)
        {
            console.WriteLine("------------------Lesson6 Task1-----------------------");
            int xA, yA, xC, yC, xA2, yA2, xC2, yC2;
            console.WriteLine("\nFirst rectangle\n");
            console.Write("Input X coordinate of top left rectangle corner: ");
            while (!int.TryParse(console.ReadLine(), out xA))
            {
                console.WriteLine("Error");
            }

            console.Write("Input Y coordinate of top left rectangle corner: ");
            while (!int.TryParse(console.ReadLine(), out yA))
            {
                console.WriteLine("Error");
            }

            console.Write("Input X coordinate of bottom right rectangle corner: ");
            while (!int.TryParse(console.ReadLine(), out xC))
            {
                console.WriteLine("Error");
            }

            console.Write("Input Y coordinate of bottom right rectangle corner: ");
            while (!int.TryParse(console.ReadLine(), out yC))
            {
                console.WriteLine("Error");
            }

            console.WriteLine("\nSecond rectangle\n");
            console.Write("Input X coordinate of top left rectangle corner: ");
            while (!int.TryParse(console.ReadLine(), out xA2))
            {
                console.WriteLine("Error");
            }

            console.Write("Input Y coordinate of top left rectangle corner: ");
            while (!int.TryParse(console.ReadLine(), out yA2))
            {
                console.WriteLine("Error");
            }

            console.Write("Input X coordinate of bottom right rectangle corner: ");
            while (!int.TryParse(console.ReadLine(), out xC2))
            {
                console.WriteLine("Error");
            }

            console.Write("Input Y coordinate of bottom right rectangle corner: ");
            while (!int.TryParse(console.ReadLine(), out yC2))
            {
                console.WriteLine("Error");
            }

            char[,] axis = new char[41, 82];
            Axis.Set(axis);
            if (xC > xA && yA > yC)
            {
                var rectangle1 = new Rectangle(xA, yA, xC, yC);
                rectangle1.Draw(console, axis);
                Axis.Draw(console, axis);
                Axis.Set(axis);
                rectangle1 = rectangle1.Move(1, 1);
                rectangle1.Draw(console, axis);
                Axis.Draw(console, axis);
                Axis.Set(axis);
                rectangle1.Move(1, 1).ChangeShape(1, 1).Draw(console, axis);
                Axis.Draw(console, axis);

                if (xC2 > xA2 && yA2 > yC2)
                {
                    var rectangle2 = new Rectangle(xA2, yA2, xC2, yC2);
                    rectangle2.Draw(console, axis);
                    Axis.Draw(console, axis);
                    if (rectangle2.XCoorA < rectangle1.XCoorC && rectangle2.XCoorC > rectangle1.XCoorA
                        && rectangle2.YCoorA > rectangle1.YCoorC && rectangle2.YCoorC < rectangle1.YCoorA)
                    {
                        Axis.Set(axis);
                        Rectangle.BuildRectThatIsCrossedByTwoRect(rectangle1, rectangle2).Draw(console, axis);
                        Axis.Draw(console, axis);
                    }
                    else
                    {
                        console.WriteLine("Cannot build rectangle! You must input correct values");
                    }

                    Rectangle.BuildMinRectThatContainTwoRect(rectangle1, rectangle2).Draw(console, axis);
                    Axis.Draw(console, axis);
                }
                else
                {
                    console.WriteLine("Cannot build second rectangle! You must input correct values");
                }
            }
            else
            {
                console.WriteLine("Cannot build first rectangle! You must input correct values");
            }
            
            console.WriteLine("------------------------------------------------------");
        }
    }
}
