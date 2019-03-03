using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson6
{
    internal static class Axis
    {
        public static void Draw(IConsole console, char[,] axis)
        {
            int rows = axis.GetUpperBound(0) + 1;
            int columns = axis.Length / rows;
            for (int y = 0; y < rows; y++)
            {
                for (int x = 0; x < columns; x++)
                {
                    if (((y == (rows - 1) / 2 && x % 2 != 0) || (x == columns / 2)))
                    {
                        if (axis[y, x] == ' ')
                        {
                            axis[y, x] = '+';
                        }
                    }

                    if ((y == (rows - 1) / 2 && x == columns / 2))
                    {
                        if (axis[y, x] == ' ')
                        {
                            axis[y, x] = '0';
                        }
                    }
                    console.Write($"{axis[y, x]}");
                }

                console.WriteLine(string.Empty);
            }
        }

        public static void Set(char[,] axis)
        {
            int rows = axis.GetUpperBound(0) + 1;
            int columns = axis.Length / rows;
            for (int y = 0; y < rows; y++)
            {
                for (int x = 0; x < columns; x++)
                {
                    axis[y, x] = ' ';
                    if ((y == (rows - 1) / 2 && x % 2 != 0) || (x == columns / 2))
                    {
                        axis[y, x] = '+';
                    }

                    if (y == (rows - 1) / 2 && x == columns / 2)
                    {
                        axis[y, x] = '0';
                    }
                }
            }
        }
    }
}
