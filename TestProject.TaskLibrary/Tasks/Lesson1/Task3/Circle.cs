using System;
using System.Collections.Generic;
using System.Text;

namespace TestProject.TaskLibrary.Tasks.Lesson1.Task3
{
    class Circle
    {
        public const double PI = 3.14;
        //private double radius;

        //public double Radius
        //{
        //    get { return radius; }
        //    set { radius = value; }
        //}   
        //public Circle(double r)
        //{
        //    Radius = r;
        //}
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
