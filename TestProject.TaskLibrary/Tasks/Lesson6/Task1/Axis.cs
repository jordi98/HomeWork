using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson6.Task1
{
    internal static class Axis
    {
        public static void Draw(IConsole console, char[,] axis)
        {
            for (int y = 0; y < 41; y++)
            {
                for (int x = 0; x < 82; x++)
                {
                    console.Write($"{axis[y, x]}");
                }

                console.WriteLine(string.Empty);
            }
        }

        public static void Set(char[,] axis)
        {
            for (int y = 0; y < 41; y++)
            {
                for (int x = 0; x < 82; x++)
                {
                    axis[y, x] = ' ';
                    if ((y == 20 && x % 2 != 0) || (x == 41))
                    {
                        axis[y, x] = '+';
                    }

                    if (y == 20 && x == 41)
                    {
                        axis[y, x] = '0';
                    }
                }
            }
        }
    }
}
