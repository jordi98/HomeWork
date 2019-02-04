using System;
using System.Collections.Generic;
using System.Text;

namespace TestProject.TaskLibrary.Tasks.Lesson1.Task4
{
    static class Rectangle
    {
        private static double ab;
        private static double bc;

        public static double AB
        {
            get { return ab; }
            set { ab = value; }
        }
        public static double BC
        {
            get { return bc; }
            set { bc = value; }
        }
        public static double Perimeter(double Ax, double Ay, double Cx, double Cy)
        {
            ab = Cx - Ax;
            bc = Ay - Cy;
            return 2 * (ab + bc);
        }
        public static double Square(double Ax, double Ay, double Cx, double Cy)
        {
            ab = Cx - Ax;
            bc = Ay - Cy;
            return ab * bc;
        }
    }
}
