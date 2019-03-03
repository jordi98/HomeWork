using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson6.Task2
{
    internal class Circle : IDraw
    {
        public Circle()
        {
            this.XCoorO = 0;
            this.YCoorO = 0;
            this.Radius = 0;
        }

        public Circle(int xO, int yO, int radius)
        {
            this.XCoorO = xO;
            this.YCoorO = yO;
            this.Radius = radius;
        }

        public int XCoorO { get; set; }

        public int YCoorO { get; set; }
        
        public int Radius { get; set; }

        #region MathFunctions
        public static double DistanceBetweenCenters(Circle c1, Circle c2)
        {
            double d;
            d = Math.Pow(c2.XCoorO - c1.XCoorO, 2) + Math.Pow(c2.YCoorO - c1.YCoorO, 2);
            d = Math.Sqrt(d);
            return d; 
        }

        public static double Func(double x, Circle c1, Circle c2)
        {
            double k1 = (double)(c2.YCoorO - c1.YCoorO) / (double)(c2.XCoorO - c1.XCoorO);
            return x * k1 - (double)c1.XCoorO * k1 + (double)c1.YCoorO;
        }

        public static double Func1(double y, Circle c1, Circle c2)
        {
            double k1 = (double)(c2.XCoorO - c1.XCoorO) / (double)(c2.YCoorO - c1.YCoorO);
            return y * k1 - (double)c1.YCoorO * k1 + (double)c1.XCoorO;
        }

        #endregion

        #region SearchPointsOfIntersection
        public static void SearchPoints(Circle c1, Circle c2)
        {
            int xO = c1.XCoorO, yO = c1.YCoorO;
            bool x, y;
            if (c1.XCoorO <= 0)
            {
                c1.XCoorO += Math.Abs(xO);
                c2.XCoorO += Math.Abs(xO);
                x = false;
            }
            else
            {
                c1.XCoorO -= Math.Abs(xO);
                c2.XCoorO -= Math.Abs(xO);
                x = true;
            }

            if (c1.YCoorO <= 0)
            {
                c1.YCoorO += Math.Abs(yO);
                c2.YCoorO += Math.Abs(yO);
                y = false;
            }
            else
            {
                c1.YCoorO -= Math.Abs(yO);
                c2.YCoorO -= Math.Abs(yO);
                y = true;
            }

            double a, b, c, k, d;
            double y1, y2, x1, x2;
            a = 2 * (c1.XCoorO + c2.XCoorO);
            b = 2 * (c1.YCoorO + c2.YCoorO);
            c = (c1.XCoorO + c2.XCoorO) * (c1.XCoorO + c2.XCoorO) + (c1.YCoorO + c2.YCoorO) * (c1.YCoorO + c2.YCoorO) + c1.Radius * c1.Radius - c2.Radius * c2.Radius;
            if (b == 0)
            {
                k = c / a - c1.XCoorO - c1.YCoorO * b / a;
                d = c1.Radius * c1.Radius * (a * a + b * b) - k * k * a * a;
                d = Math.Sqrt(d);
                y1 = a * (k * b + d) / (a * a + b * b);
                y2 = a * (k * b - d) / (a * a + b * b);
                x1 = k - b * y1 / a;
                x2 = k - b * y2 / a;
                if (x)
                {
                    x1 += xO;
                    x2 += xO;
                }
                else
                {
                    x1 -= xO;
                    x2 -= xO;
                }

                if (y)
                {
                    y1 += yO;
                    y2 += yO;
                }
                else
                {
                    y1 -= yO;
                    y2 -= yO;
                }

                Console.WriteLine($"(x1, y1): ({x1}, {y1})\n(x2, y2): ({x2}, {y2})\n");
            }

            if (a == 0)
            {
                k = c / b - c1.YCoorO - c1.XCoorO * a / b;
                d = c1.Radius * c1.Radius * (a * a + b * b) - k * k * b * b;
                d = Math.Sqrt(d);
                x1 = b * (k * a + d) / (a * a + b * b);
                x2 = b * (k * a - d) / (a * a + b * b);
                y1 = k - a * x1 / b;
                y2 = k - a * x2 / b;
                if (x)
                {
                    x1 += xO;
                    x2 += xO;
                }
                else
                {
                    x1 -= xO;
                    x2 -= xO;
                }

                if (y)
                {
                    y1 += yO;
                    y2 += yO;
                }
                else
                {
                    y1 -= yO;
                    y2 -= yO;
                }

                Console.WriteLine($"(x1, y1): ({x1}, {y1})\n(x2, y2): ({x2}, {y2})\n");
            }

            if (a != 0 && b != 0)
            {
                k = c / a - c1.XCoorO - c1.YCoorO * b / a;
                d = c1.Radius * c1.Radius * (a * a + b * b) - k * k * a * a;
                d = Math.Sqrt(d);
                y1 = a * (k * b + d) / (a * a + b * b);
                y2 = a * (k * b - d) / (a * a + b * b);
                x1 = k - b * y1 / a;
                x2 = k - b * y2 / a;
                if (x)
                {
                    x1 += xO;
                    x2 += xO;
                }
                else
                {
                    x1 -= xO;
                    x2 -= xO;
                }

                if (y)
                {
                    y1 += yO;
                    y2 += yO;
                }
                else
                {
                    y1 -= yO;
                    y2 -= yO;
                }

                Console.WriteLine($"(x1, y1): ({x1}, {y1})\n(x2, y2): ({x2}, {y2})\n");
            }
        }
        #endregion

        #region BuildMinCircleThatContainTwoCircles
        public Circle BuildMinCircleThatContainTwoCircles(Circle c1, Circle c2)
        {
            var minCircle = new Circle();
            double x11, x12, x21, x22, k, d;
            double xa, xb, ya, yb;
            if (c2.YCoorO == c1.YCoorO && c2.XCoorO != c1.XCoorO)
            {
                k = 1 + Math.Pow(c2.YCoorO - c1.YCoorO, 2) / Math.Pow(c2.XCoorO - c1.XCoorO, 2);
                k = Math.Sqrt(k);
                x11 = c1.XCoorO + (c1.Radius / k);
                x12 = c1.XCoorO - (c1.Radius / k);
                x21 = c2.XCoorO + (c2.Radius / k);
                x22 = c2.XCoorO - (c2.Radius / k);
                xb = Math.Max(x11, x21);
                xa = Math.Min(x12, x22);
                ya = Func(xa, c1, c2);
                yb = Func(xb, c1, c2);
                d = Math.Pow(xb - xa, 2) + Math.Pow(yb - ya, 2);
                d = Math.Sqrt(d);
                minCircle.XCoorO = (int)Math.Ceiling((xb + xa) / 2);
                minCircle.YCoorO = (int)Math.Ceiling((ya + yb) / 2);
                minCircle.Radius = (int)Math.Ceiling(d / 2);
                return minCircle;
            }
            else if (c2.XCoorO == c1.XCoorO && c2.YCoorO != c1.YCoorO)
            {
                k = 1 + Math.Pow(c2.XCoorO - c1.XCoorO, 2) / Math.Pow(c2.YCoorO - c1.YCoorO, 2);
                k = Math.Sqrt(k);
                x11 = c1.YCoorO + (c1.Radius / k);
                x12 = c1.YCoorO - (c1.Radius / k);
                x21 = c2.YCoorO + (c2.Radius / k);
                x22 = c2.YCoorO - (c2.Radius / k);
                yb = Math.Max(x11, x21);
                ya = Math.Min(x12, x22);
                xa = Func1(ya, c1, c2);
                xb = Func1(yb, c1, c2);
                d = Math.Pow(xb - xa, 2) + Math.Pow(yb - ya, 2);
                d = Math.Sqrt(d);
                minCircle.XCoorO = (int)Math.Ceiling((xb + xa) / 2);
                minCircle.YCoorO = (int)Math.Ceiling((ya + yb) / 2);
                minCircle.Radius = (int)Math.Ceiling(d / 2);
                return minCircle;
            }
            else if (c2.XCoorO == c1.XCoorO && c2.YCoorO == c1.YCoorO)
            {
                minCircle.XCoorO = c1.XCoorO;
                minCircle.YCoorO = c1.YCoorO;
                minCircle.Radius = Math.Max(c1.Radius, c2.Radius);
                return minCircle;
            }
            else
            {
                k = 1 + Math.Pow(c2.YCoorO - c1.YCoorO, 2) / Math.Pow(c2.XCoorO - c1.XCoorO, 2);
                k = Math.Sqrt(k);
                x11 = c1.XCoorO + (c1.Radius / k);
                x12 = c1.XCoorO - (c1.Radius / k);
                x21 = c2.XCoorO + (c2.Radius / k);
                x22 = c2.XCoorO - (c2.Radius / k);
                xb = Math.Max(x11, x21);
                xa = Math.Min(x12, x22);
                ya = Func(xa, c1, c2);
                yb = Func(xb, c1, c2);
                d = Math.Pow(xb - xa, 2) + Math.Pow(yb - ya, 2);
                d = Math.Sqrt(d);
                minCircle.XCoorO = (int)Math.Ceiling((xb + xa) / 2);
                minCircle.YCoorO = (int)Math.Ceiling((ya + yb) / 2);
                minCircle.Radius = (int)Math.Ceiling(d / 2);
                return minCircle;
            }
        }
        #endregion

        #region DrawMethods

        public void Draw4(IConsole console, char[,] axis)
        {
            int rows = axis.GetUpperBound(0) + 1;
            int columns = axis.Length / rows;
            int n = this.Radius * 2 + 1, m = this.Radius * 4 + 1;
            char[,] area = new char[n, m];
            for (int y = 0; y < n; y++)
            {
                for (int x = 0; x < m; x++)
                {
                    if (x % 2 == 0)
                    {
                        if (Math.Pow(((x / 2) - this.Radius), 2) + Math.Pow((y - this.Radius), 2) <= Math.Pow(this.Radius, 2))
                        {
                            area[y, x] = ' ';
                        }
                    }
                }
            }

            for (int y = 0; y < n; y++)
            {
                for (int x = 0; x < m; x++)
                {
                    if (axis[y + (rows - 1) / 2 - this.YCoorO - this.Radius, x + columns / 2 + (this.XCoorO - this.Radius) * 2] == ',')
                    {
                        axis[y + (rows - 1) / 2 - this.YCoorO - this.Radius, x + columns / 2 + (this.XCoorO - this.Radius) * 2] = ',';
                    }
                    else
                    {
                        axis[y + (rows - 1) / 2 - this.YCoorO - this.Radius, x + columns / 2 + (this.XCoorO - this.Radius) * 2] = area[y, x];
                    }
                }
            }
        }

        public void Draw3(IConsole console, char[,] axis)
        {
            int rows = axis.GetUpperBound(0) + 1;
            int columns = axis.Length / rows;
            int n = this.Radius * 2 + 1, m = this.Radius * 4 + 1;
            char[,] area = new char[n, m];
            for (int y = 0; y < n; y++)
            {
                for (int x = 0; x < m; x++)
                {
                    if (x % 2 == 0)
                    {
                        if (Math.Pow(((x / 2) - this.Radius), 2) + Math.Pow((y - this.Radius), 2) <= Math.Pow(this.Radius, 2))
                        {
                            area[y, x] = ' ';
                        }
                    }
                }
            }

            for (int y = 0; y < n; y++)
            {
                for (int x = 0; x < m; x++)
                {
                    if (axis[y + (rows - 1) / 2 - this.YCoorO - this.Radius, x + columns / 2 + (this.XCoorO - this.Radius) * 2] == '.' &&
                        (Math.Pow(((x / 2) - this.Radius), 2) + Math.Pow((y - this.Radius), 2) <= Math.Pow(this.Radius - 1, 2)))
                    {
                        axis[y + (rows - 1) / 2 - this.YCoorO - this.Radius, x + columns / 2 + (this.XCoorO - this.Radius) * 2] = ',';
                    }
                    else
                    {
                        axis[y + (rows - 1) / 2 - this.YCoorO - this.Radius, x + columns / 2 + (this.XCoorO - this.Radius) * 2] = area[y, x];
                    }
                }
            }
        }

        public void Draw2(IConsole console, char[,] axis)
        {
            int rows = axis.GetUpperBound(0) + 1;
            int columns = axis.Length / rows;
            int n = this.Radius * 2 + 1, m = this.Radius * 4 + 1;
            char[,] area = new char[n, m];
            for (int y = 0; y < n; y++)
            {
                for (int x = 0; x < m; x++)
                {
                    if (x % 2 == 0)
                    {
                        if (Math.Pow(((x / 2) - this.Radius), 2) + Math.Pow((y - this.Radius), 2) <= Math.Pow(this.Radius, 2))
                        {
                            area[y, x] = '.';
                        }
                    }
                }
            }

            for (int y = 0; y < n; y++)
            {
                for (int x = 0; x < m; x++)
                {
                    if (axis[y + (rows - 1) / 2 - this.YCoorO - this.Radius, x + columns / 2 + (this.XCoorO - this.Radius) * 2] == '.')
                    {
                        axis[y + (rows - 1) / 2 - this.YCoorO - this.Radius, x + columns / 2 + (this.XCoorO - this.Radius) * 2] = '.';
                    }
                    else
                    {
                        axis[y + (rows - 1) / 2 - this.YCoorO - this.Radius, x + columns / 2 + (this.XCoorO - this.Radius) * 2] = area[y, x];
                    }
                }
            }
        }

        public void Draw(IConsole console, char[,] axis)
        {
            int rows = axis.GetUpperBound(0) + 1;
            int columns = axis.Length / rows;
            int n = this.Radius * 2 + 1, m = this.Radius * 4 + 1;
            char[,] rectangle = new char[n, m];
            for (int y = 0; y < n; y++)
            {
                for (int x = 0; x < m; x++)
                {
                    if (x % 2 == 0)
                    {
                        if (Math.Pow(((x / 2) - this.Radius), 2) + Math.Pow((y - this.Radius), 2) <= Math.Pow(this.Radius, 2) &&
                            Math.Pow(((x / 2) - this.Radius), 2) + Math.Pow((y - this.Radius), 2) > Math.Pow(this.Radius - 1, 2))
                        {
                            rectangle[y, x] = '.';
                        }
                    }
                }
            }

            for (int y = 0; y < n; y++)
            {
                for (int x = 0; x < m; x++)
                {
                    if (axis[y + (rows - 1) / 2 - this.YCoorO - this.Radius, x + columns / 2 + (this.XCoorO - this.Radius) * 2] == '.')
                    {
                        axis[y + (rows - 1) / 2 - this.YCoorO - this.Radius, x + columns / 2 + (this.XCoorO - this.Radius) * 2] = '.';
                    }
                    else if (axis[y + (rows - 1) / 2 - this.YCoorO - this.Radius, x + columns / 2 + (this.XCoorO - this.Radius) * 2] == ',' &&
                        Math.Pow(((x / 2) - this.Radius), 2) + Math.Pow((y - this.Radius), 2) <= Math.Pow(this.Radius - 1, 2))
                    {
                        axis[y + (rows - 1) / 2 - this.YCoorO - this.Radius, x + columns / 2 + (this.XCoorO - this.Radius) * 2] = ',';
                    }
                    else
                    {
                        axis[y + (rows - 1) / 2 - this.YCoorO - this.Radius, x + columns / 2 + (this.XCoorO - this.Radius) * 2] = rectangle[y, x];
                    }
                }
            }
        }

        #endregion

        public Circle Move(int x, int y)
        {
            var circle = new Circle(this.XCoorO + x, this.YCoorO + y, this.Radius);
            return circle;
        }

        public Circle ChangeShape(int radius)
        {
            var circle = new Circle(this.XCoorO, this.YCoorO, this.Radius + radius);
            return circle;
        }
    }
}
