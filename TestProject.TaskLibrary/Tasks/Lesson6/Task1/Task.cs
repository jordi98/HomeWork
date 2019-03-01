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
            int xA = 0, yA = 0, xC = 0, yC = 0, xA2 = 0, yA2 = 0, xC2 = 0, yC2 = 0;
            int k = 1;
            int n = 60;
            while (k != 0)
            {
                var rectangle1 = new Rectangle(xA, yA, xC, yC);
                var rectangle2 = new Rectangle(xA2, yA2, xC2, yC2);
                char[,] axis = new char[n + 1, (n + 1) * 2];
                Axis.Set(axis);
                console.WriteLine("1 - Build 1st rectangle");
                console.WriteLine("2 - Build 2nd rectangle");
                console.WriteLine("3 - Edit 1st rectangle");
                console.WriteLine("4 - Edit 2nd rectangle");
                console.WriteLine("5 - Build min rect that contain 2 rect");
                console.WriteLine("6 - Build rect that is crossed by 2 rect");
                console.WriteLine("7 - Show");
                console.WriteLine("0 - Exit");
                console.Write("Choose: ");
                int choice;
                while (!int.TryParse(console.ReadLine(), out choice))
                {
                    console.WriteLine("Error");
                }

                switch (choice)
                {
                    case 1:
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

                        if (xC > xA && yA > yC)
                        {
                            rectangle1 = new Rectangle(xA, yA, xC, yC);
                            rectangle1.Draw(console, axis);
                            console.WriteLine("First rectangle:\n");
                            Axis.Draw(console, axis);
                        }
                        else
                        {
                            console.WriteLine("Cannot build 1st rectangle! You must input correct values");
                        }

                        break;
                    case 2:
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

                        if (xC2 > xA2 && yA2 > yC2)
                        {
                            rectangle2 = new Rectangle(xA2, yA2, xC2, yC2);
                            rectangle2.Draw(console, axis);
                            console.WriteLine("Second rectangle:\n");
                            Axis.Draw(console, axis);
                        }
                        else
                        {
                            console.WriteLine("Cannot build 2nd rectangle! You must input correct values");
                        }

                        break;
                    case 5:
                        Axis.Set(axis);
                        if (xC > xA && yA > yC && xC2 > xA2 && yA2 > yC2)
                        {
                            rectangle1 = new Rectangle(xA, yA, xC, yC);
                            rectangle2 = new Rectangle(xA2, yA2, xC2, yC2);
                            Rectangle rectangle3 = new Rectangle();
                            rectangle3.BuildMinRectThatContainTwoRect(rectangle1, rectangle2).Draw(console, axis);
                            console.WriteLine("Min rectangle that contain two rectangles:\n");
                            Axis.Draw(console, axis);
                        }
                        else
                        {
                            console.WriteLine("Cannot build rectangle! You must input correct values");
                        }

                        break;
                    case 6:
                        Axis.Set(axis);
                        rectangle1 = new Rectangle(xA, yA, xC, yC);
                        rectangle2 = new Rectangle(xA2, yA2, xC2, yC2);
                        if (rectangle2.XCoorA < rectangle1.XCoorC && rectangle2.XCoorC > rectangle1.XCoorA
                                && rectangle2.YCoorA > rectangle1.YCoorC && rectangle2.YCoorC < rectangle1.YCoorA
                                && !(rectangle1.XCoorA <= rectangle2.XCoorA && rectangle2.XCoorC <= rectangle1.XCoorC
                                && rectangle2.YCoorA <= rectangle1.YCoorA && rectangle1.YCoorC <= rectangle2.YCoorC))
                        {
                            Rectangle rectangle3 = new Rectangle();
                            rectangle3.BuildRectThatIsCrossedByTwoRect(rectangle1, rectangle2).Draw(console, axis);
                            console.WriteLine("Rectangle that is crossed by two rectangles:\n");
                            Axis.Draw(console, axis);
                        }
                        else
                        {
                            console.WriteLine("Cannot build rectangle! You must input correct values");
                        }

                        break;
                    case 7:
                        Axis.Set(axis);
                        if (xC > xA && yA > yC)
                        {
                            rectangle1 = new Rectangle(xA, yA, xC, yC);
                            rectangle1.Draw(console, axis);
                        }

                        if (xC2 > xA2 && yA2 > yC2)
                        {
                            rectangle2 = new Rectangle(xA2, yA2, xC2, yC2);
                            rectangle2.Draw(console, axis);
                        }

                        Axis.Draw(console, axis);
                        break;
                    case 3:
                        if (xC > xA && yA > yC)
                        {
                            console.WriteLine("1 - Move");
                            console.WriteLine("2 - Resize");
                            console.WriteLine("0 - Exit");
                            int choice0;
                            while (!int.TryParse(console.ReadLine(), out choice0))
                            {
                                console.WriteLine("Error");
                            }

                            switch (choice0)
                            {
                                case 1:
                                    int xMove, yMove;
                                    console.Write("Input x: ");
                                    while (!int.TryParse(console.ReadLine(), out xMove))
                                    {
                                        console.WriteLine("Error");
                                    }

                                    console.Write("Input y: ");
                                    while (!int.TryParse(console.ReadLine(), out yMove))
                                    {
                                        console.WriteLine("Error");
                                    }

                                    Axis.Set(axis);
                                    rectangle1 = rectangle1.Move(xMove, yMove);
                                    rectangle1.Draw(console, axis);
                                    console.WriteLine($"Moved 1st rectangle by {xMove} on Ox and {yMove} on Oy:\n");
                                    Axis.Draw(console, axis);
                                    xA = rectangle1.XCoorA;
                                    xC = rectangle1.XCoorC;
                                    yA = rectangle1.YCoorA;
                                    yC = rectangle1.YCoorC;
                                    break;
                                case 2:
                                    int xResize, yResize;
                                    console.Write("Input x: ");
                                    while (!int.TryParse(console.ReadLine(), out xResize))
                                    {
                                        console.WriteLine("Error");
                                    }

                                    console.Write("Input y: ");
                                    while (!int.TryParse(console.ReadLine(), out yResize))
                                    {
                                        console.WriteLine("Error");
                                    }

                                    Axis.Set(axis);
                                    rectangle1 = rectangle1.ChangeShape(xResize, yResize);
                                    rectangle1.Draw(console, axis);
                                    console.WriteLine($"Resized 1st rectangle by {xResize} on Ox and {yResize} on Oy:\n");
                                    Axis.Draw(console, axis);
                                    xA = rectangle1.XCoorA;
                                    xC = rectangle1.XCoorC;
                                    yA = rectangle1.YCoorA;
                                    yC = rectangle1.YCoorC;
                                    break;
                                default:
                                    xA = rectangle1.XCoorA;
                                    xC = rectangle1.XCoorC;
                                    yA = rectangle1.YCoorA;
                                    yC = rectangle1.YCoorC;
                                    break;
                            }
                        }
                        else
                        {
                            console.WriteLine("Cannot edit 1st rectangle! You must input correct values");
                        }

                        break;
                    case 4:
                        if (xC2 > xA2 && yA2 > yC2)
                        {
                            console.WriteLine("1 - Move");
                            console.WriteLine("2 - Resize");
                            console.WriteLine("0 - Exit");
                            int choice1;
                            while (!int.TryParse(console.ReadLine(), out choice1))
                            {
                                console.WriteLine("Error");
                            }

                            switch (choice1)
                            {
                                case 1:
                                    int xMove, yMove;
                                    console.Write("Input x: ");
                                    while (!int.TryParse(console.ReadLine(), out xMove))
                                    {
                                        console.WriteLine("Error");
                                    }

                                    console.Write("Input y: ");
                                    while (!int.TryParse(console.ReadLine(), out yMove))
                                    {
                                        console.WriteLine("Error");
                                    }

                                    Axis.Set(axis);
                                    rectangle2 = rectangle2.Move(xMove, yMove);
                                    rectangle2.Draw(console, axis);
                                    console.WriteLine($"Moved 2nd rectangle by {xMove} on Ox and {yMove} on Oy:\n");
                                    Axis.Draw(console, axis);
                                    xA2 = rectangle2.XCoorA;
                                    xC2 = rectangle2.XCoorC;
                                    yA2 = rectangle2.YCoorA;
                                    yC2 = rectangle2.YCoorC;
                                    break;
                                case 2:
                                    int xResize, yResize;
                                    console.Write("Input x: ");
                                    while (!int.TryParse(console.ReadLine(), out xResize))
                                    {
                                        console.WriteLine("Error");
                                    }

                                    console.Write("Input y: ");
                                    while (!int.TryParse(console.ReadLine(), out yResize))
                                    {
                                        console.WriteLine("Error");
                                    }

                                    Axis.Set(axis);
                                    rectangle2 = rectangle2.ChangeShape(xResize, yResize);
                                    rectangle2.Draw(console, axis);
                                    console.WriteLine($"Resized 2nd rectangle by {xResize} on Ox and {yResize} on Oy:\n");
                                    Axis.Draw(console, axis);
                                    xA2 = rectangle2.XCoorA;
                                    xC2 = rectangle2.XCoorC;
                                    yA2 = rectangle2.YCoorA;
                                    yC2 = rectangle2.YCoorC;
                                    break;
                                default:
                                    xA2 = rectangle2.XCoorA;
                                    xC2 = rectangle2.XCoorC;
                                    yA2 = rectangle2.YCoorA;
                                    yC2 = rectangle2.YCoorC;
                                    break;
                            }
                        }
                        else
                        {
                            console.WriteLine("Cannot edit 2nd rectangle! You must input correct values");
                        }
                        
                        break;
                    default:
                        k = 0;
                        break;
                }
            }

            console.WriteLine("------------------------------------------------------");
        }
    }
}
