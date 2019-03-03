using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson6.Task1
{
    internal class Rectangle : IDraw
    {
        public Rectangle()
        {
            this.XCoorA = 0;
            this.YCoorA = 0;
            this.XCoorC = 0;
            this.YCoorC = 0;
            this.AB = this.XCoorC - this.XCoorA;
            this.BC = this.YCoorA - this.YCoorC;
        }

        public Rectangle(int xA, int yA, int xC, int yC)
        {
            this.XCoorA = xA;
            this.YCoorA = yA;
            this.XCoorC = xC;
            this.YCoorC = yC;
            this.AB = this.XCoorC - this.XCoorA;
            this.BC = this.YCoorA - this.YCoorC;
        }

        public int XCoorA { get; set; }

        public int YCoorA { get; set; }

        public int XCoorC { get; set; }

        public int YCoorC { get; set; }

        public int AB { get; set; }

        public int BC { get; set; }

        #region BuildMinRectThatContainTwoRect
        public Rectangle BuildMinRectThatContainTwoRect(Rectangle rectangle1, Rectangle rectangle2)
        {
            var minRect = new Rectangle();
            if (rectangle1.YCoorA >= rectangle2.YCoorA)
            {
                minRect.YCoorA = rectangle1.YCoorA;
            }
            else
            {
                minRect.YCoorA = rectangle2.YCoorA;
            }

            if (rectangle2.YCoorC <= rectangle1.YCoorC)
            {
                minRect.YCoorC = rectangle2.YCoorC;
            }
            else
            {
                minRect.YCoorC = rectangle1.YCoorC;
            }

            if (rectangle1.XCoorA <= rectangle2.XCoorA)
            {
                minRect.XCoorA = rectangle1.XCoorA;
            }
            else
            {
                minRect.XCoorA = rectangle2.XCoorA;
            }

            if (rectangle2.XCoorC >= rectangle1.XCoorC)
            {
                minRect.XCoorC = rectangle2.XCoorC;
            }
            else
            {
                minRect.XCoorC = rectangle1.XCoorC;
            }

            return minRect;
        }

        #endregion

        #region BuildRectThatIsCrossedByTwoRect
        public Rectangle BuildRectThatIsCrossedByTwoRect(Rectangle rectangle1, Rectangle rectangle2)
        {
            var rect = new Rectangle();
            if (rectangle2.XCoorA >= rectangle1.XCoorA)
            {
                rect.XCoorA = rectangle2.XCoorA;
            }
            else
            {
                rect.XCoorA = rectangle1.XCoorA;
            }

            if (rectangle2.XCoorC <= rectangle1.XCoorC)
            {
                rect.XCoorC = rectangle2.XCoorC;
            }
            else
            {
                rect.XCoorC = rectangle1.XCoorC;
            }

            if (rectangle2.YCoorA <= rectangle1.YCoorA)
            {
                rect.YCoorA = rectangle2.YCoorA;
            }
            else
            {
                rect.YCoorA = rectangle1.YCoorA;
            }

            if (rectangle2.YCoorC >= rectangle1.YCoorC)
            {
                rect.YCoorC = rectangle2.YCoorC;
            }
            else
            {
                rect.YCoorC = rectangle1.YCoorC;
            }

            return rect;
        }

        #endregion

        #region DrawMethod
        public void Draw(IConsole console, char[,] axis)
        {
            int rows = axis.GetUpperBound(0) + 1;
            int columns = axis.Length / rows;
            this.AB = this.XCoorC - this.XCoorA;
            this.BC = this.YCoorA - this.YCoorC;
            int n = this.BC + 1, m = this.AB * 2 + 1;
            char[,] rectangle = new char[n, m];
            for (int y = 0; y < n; y++)
            {
                for (int x = 0; x < m; x++)
                {
                    if (x % 2 == 0 && ((x == 0 || x == m - 1) || (y == 0 || y == n - 1)))
                    {
                        rectangle[y, x] = '.';
                    }
                }
            }

            for (int y = 0; y < n; y++)
            {
                for (int x = 0; x < m; x++)
                {
                    if (axis[y + (rows - 1) / 2 - this.YCoorA, x + columns / 2 + this.XCoorA * 2] == '.')
                    {
                        axis[y + (rows - 1) / 2 - this.YCoorA, x + columns / 2 + this.XCoorA * 2] = '.';
                    }
                    else
                    {
                        axis[y + (rows - 1) / 2 - this.YCoorA, x + columns / 2 + this.XCoorA * 2] = rectangle[y, x];
                    }
                }
            }
        }

        #endregion

        public Rectangle Move(int x, int y)
        {
            var rectangle = new Rectangle(this.XCoorA + x, this.YCoorA + y, this.XCoorC + x, this.YCoorC + y);
            return rectangle;
        }

        public Rectangle ChangeShape(int x, int y)
        {
            var rectangle = new Rectangle(this.XCoorA, this.YCoorA, this.XCoorC + x, this.YCoorC + y);
            return rectangle;
        }
    }
}
