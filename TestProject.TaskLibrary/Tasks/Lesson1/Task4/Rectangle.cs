using System;
using System.Collections.Generic;
using System.Text;

namespace TestProject.TaskLibrary.Tasks.Lesson1.Task4
{
    static class Rectangle
    {
        public static double AB { get; set; }

        public static double BC { get; set; }

        public static void SetSides(double xA, double yA, double xC, double yC)
        {
            AB = xC - xA;
            BC = yA - yC;
        }

        public static double Perimeter()
        {            
            return 2 * (AB + BC);
        }

        public static double Square()
        {
            return AB * BC;
        }
    }
}
