using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson6.Task2
{
    public class Task : IRunnable
    {
        public void Run(IConsole console)
        {
            console.WriteLine("------------------Lesson6 Task2-----------------------");
            int xO = 0, yO = 0, radius = 0, xO2 = 0, yO2 = 0, radius2 = 0;
            int k = 1, n = 60;
            while (k != 0)
            {
                var circle1 = new Circle(xO, yO, radius);
                var circle2 = new Circle(xO2, yO2, radius2);
                char[,] axis = new char[n + 1, (n + 1) * 2];
                Axis.Set(axis);
                console.WriteLine("1 - Build 1st circle");
                console.WriteLine("2 - Build 2nd circle");
                console.WriteLine("3 - Edit 1st circle");
                console.WriteLine("4 - Edit 2nd circle");
                console.WriteLine("5 - Build min circle that contain 2 circles");
                console.WriteLine("6 - Build area that is crossed by 2 circles");
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
                        console.WriteLine("\nFirst circle\n");
                        console.Write("Input X coordinate of circle center: ");
                        while (!int.TryParse(console.ReadLine(), out xO))
                        {
                            console.WriteLine("Error");
                        }

                        console.Write("Input Y coordinate of circle center: ");
                        while (!int.TryParse(console.ReadLine(), out yO))
                        {
                            console.WriteLine("Error");
                        }

                        console.Write("Input circle radius: ");
                        while (!int.TryParse(console.ReadLine(), out radius))
                        {
                            console.WriteLine("Error");
                        }
                        
                        if (radius > 0)
                        {
                            circle1 = new Circle(xO, yO, radius);
                            circle1.Draw(console, axis);
                            console.WriteLine("First circle:\n");
                            Axis.Draw(console, axis);
                        }
                        else
                        {
                            console.WriteLine("Cannot build 1st circle! You must input correct values");
                        }

                        break;
                    case 2:
                        console.WriteLine("\nSecond circle\n");
                        console.Write("Input X coordinate of circle center: ");
                        while (!int.TryParse(console.ReadLine(), out xO2))
                        {
                            console.WriteLine("Error");
                        }

                        console.Write("Input Y coordinate of circle center: ");
                        while (!int.TryParse(console.ReadLine(), out yO2))
                        {
                            console.WriteLine("Error");
                        }

                        console.Write("Input circle radius: ");
                        while (!int.TryParse(console.ReadLine(), out radius2))
                        {
                            console.WriteLine("Error");
                        }

                        if (radius > 0)
                        {
                            circle2 = new Circle(xO2, yO2, radius2);
                            circle2.Draw(console, axis);
                            console.WriteLine("Second circle:\n");
                            Axis.Draw(console, axis);
                        }
                        else
                        {
                            console.WriteLine("Cannot build 2nd circle! You must input correct values");
                        }

                        break;
                    case 5:
                        Axis.Set(axis);
                        if (radius > 0 && radius2 > 0)
                        {
                            circle1 = new Circle(xO, yO, radius);
                            circle2 = new Circle(xO2, yO2, radius2);
                            Circle circle3 = new Circle();
                            circle3 = circle3.BuildMinCircleThatContainTwoCircles(circle1, circle2);
                            circle3.Draw(console, axis);
                            console.WriteLine("Min circle that contain two circles:\n");
                            Axis.Draw(console, axis);
                        }
                        else
                        {
                            console.WriteLine("Cannot build circle! You must input correct values");
                        }

                        break;
                    case 6:
                        Axis.Set(axis);
                        if (radius > 0 && radius2 > 0)
                        {
                            circle1 = new Circle(xO, yO, radius);
                            circle2 = new Circle(xO2, yO2, radius2);
                            var circle = new Circle();
                            if (Circle.DistanceBetweenCenters(circle1, circle2) > Math.Abs(circle1.Radius - circle2.Radius) &&
                                Circle.DistanceBetweenCenters(circle1, circle2) < circle1.Radius + circle2.Radius)
                            {
                                if (Math.Sqrt(Math.Pow(circle1.XCoorO - 0, 2) + Math.Pow(circle1.YCoorO - 0, 2)) <
                                    Math.Sqrt(Math.Pow(circle2.XCoorO - 0, 2) + Math.Pow(circle2.YCoorO - 0, 2)))
                                {
                                    console.WriteLine("Area that is crossed by two circles:\n");
                                    circle1.Draw(console, axis);
                                    circle2.Draw2(console, axis);
                                    circle1.Draw3(console, axis);
                                    circle2.Draw4(console, axis);
                                    Axis.Draw(console, axis);
                                }
                                else
                                {
                                    console.WriteLine("Area that is crossed by two circles:\n");
                                    circle2.Draw(console, axis);
                                    circle1.Draw2(console, axis);
                                    circle2.Draw3(console, axis);
                                    circle1.Draw4(console, axis);
                                    Axis.Draw(console, axis);
                                }
                            }
                            else if (Circle.DistanceBetweenCenters(circle1,circle2) == Math.Abs(circle1.Radius - circle2.Radius) && 
                                Circle.DistanceBetweenCenters(circle1, circle2) == 0)
                            {
                                circle = circle1;
                                circle.Draw(console, axis);
                                console.WriteLine("Area that is crossed by two circles:\n");
                                Axis.Draw(console, axis);
                            }
                            else
                            {
                                console.WriteLine("Cannot build area! You must input correct values");
                            }
                        }
                        else
                        {
                            console.WriteLine("Cannot build area! You must input correct values");
                        }

                        break;
                    case 7:
                        Axis.Set(axis);
                        if (radius > 0)
                        {
                            circle1 = new Circle(xO, yO, radius);
                            circle1.Draw(console, axis);
                        }

                        if (radius2 > 0)
                        {
                            circle2 = new Circle(xO2, yO2, radius2);
                            circle2.Draw(console, axis);
                        }

                        Axis.Draw(console, axis);
                        break;
                    case 3:
                        if (radius > 0)
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
                                    circle1 = circle1.Move(xMove, yMove);
                                    circle1.Draw(console, axis);
                                    console.WriteLine($"Moved 1st circle by {xMove} on Ox and {yMove} on Oy:\n");
                                    Axis.Draw(console, axis);
                                    xO = circle1.XCoorO;
                                    yO = circle1.YCoorO;
                                    radius = circle1.Radius;
                                    break;
                                case 2:
                                    int radiusResize;
                                    console.Write("Input number: ");
                                    while (!int.TryParse(console.ReadLine(), out radiusResize))
                                    {
                                        console.WriteLine("Error");
                                    }
                                    
                                    Axis.Set(axis);
                                    circle1 = circle1.ChangeShape(radiusResize);
                                    circle1.Draw(console, axis);
                                    console.WriteLine($"Resized 1st circle by {radiusResize}:\n");
                                    Axis.Draw(console, axis);
                                    xO = circle1.XCoorO;
                                    yO = circle1.YCoorO;
                                    radius = circle1.Radius;
                                    break;
                                default:
                                    xO = circle1.XCoorO;
                                    yO = circle1.YCoorO;
                                    radius = circle1.Radius;
                                    break;
                            }
                        }
                        else
                        {
                            console.WriteLine("Cannot edit 1st circle! You must input correct values");
                        }

                        break;
                    case 4:
                        if (radius2 > 0)
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
                                    circle2 = circle2.Move(xMove, yMove);
                                    circle2.Draw(console, axis);
                                    console.WriteLine($"Moved 2nd circle by {xMove} on Ox and {yMove} on Oy:\n");
                                    Axis.Draw(console, axis);
                                    xO2 = circle2.XCoorO;
                                    yO2 = circle2.YCoorO;
                                    radius2 = circle2.Radius;
                                    break;
                                case 2:
                                    int radiusResize;
                                    console.Write("Input number: ");
                                    while (!int.TryParse(console.ReadLine(), out radiusResize))
                                    {
                                        console.WriteLine("Error");
                                    }

                                    Axis.Set(axis);
                                    circle2 = circle2.ChangeShape(radiusResize);
                                    circle2.Draw(console, axis);
                                    console.WriteLine($"Resized 2nd circle by {radiusResize}:\n");
                                    Axis.Draw(console, axis);
                                    xO2 = circle2.XCoorO;
                                    yO2 = circle2.YCoorO;
                                    radius2 = circle2.Radius;
                                    break;
                                default:
                                    xO2 = circle2.XCoorO;
                                    yO2 = circle2.YCoorO;
                                    radius2 = circle2.Radius;
                                    break;
                            }
                        }
                        else
                        {
                            console.WriteLine("Cannot edit 2nd circle! You must input correct values");
                        }

                        break;
                    default:
                        k = 0;
                        break;
                }
            }

            console.WriteLine("\n------------------------------------------------------");
        }
    }
}
