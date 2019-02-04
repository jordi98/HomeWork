using System;
using System.Collections.Generic;
using System.Text;

namespace TestProject.TaskLibrary.Tasks.Lesson1.Task1
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

        public Rectangle(double Ax, double Ay, double Cx, double Cy)
        {
            ab = Cx - Ax;
            bc = Ay - Cy;
        }
        public double Perimeter()
        {
            return 2 * (ab + bc);
        }
        public double Square()
        {
            return ab * bc;
        }
    }
}
