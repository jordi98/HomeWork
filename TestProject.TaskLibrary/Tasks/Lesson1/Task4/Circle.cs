using System;
using System.Collections.Generic;
using System.Text;

namespace TestProject.TaskLibrary.Tasks.Lesson1.Task4
{
    static class Circle
    {
        public const double PI = 3.14;

        public static double Length(double r)
        {
            return 2 * PI * r;
        }

        public static double Square(double r)
        {
            return PI * r * r;
        }
    }
}
