using System;
using System.Collections.Generic;
using System.Text;

namespace TestProject.TaskLibrary.Tasks.Lesson1.Task2
{
    class Rectangle
    {
        private double ab;
        private double bc;

        public double AB
        {
            get { return ab; }
            set { ab = value; }
        }
        public double BC
        {
            get { return bc; }
            set { bc = value; }
        }
        public double Perimeter { get; private set; }
        public double Square { get; private set; }

        public Rectangle(double Ax, double Ay, double Cx, double Cy)
        {
            ab = Cx - Ax;
            bc = Ay - Cy;
            Perimeter = 2 * (ab + bc);
            Square = ab * bc;
        }
    }
}
