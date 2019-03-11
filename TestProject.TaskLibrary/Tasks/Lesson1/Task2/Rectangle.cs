using System;
using System.Collections.Generic;
using System.Text;

namespace TestProject.TaskLibrary.Tasks.Lesson1.Task2
{
    internal class Rectangle
    {
        private double ab;
        private double bc;
        
        public Rectangle(double xA, double yA, double xC, double yC)
        {
            this.ab = xC - xA;
            this.bc = yA - yC;
            this.Perimeter = 2 * (this.ab + this.bc);
            this.Square = this.ab * this.bc;
        }

        public double AB
        {
            get { return this.ab; }
            set { this.ab = value; }
        }

        public double BC
        {
            get { return this.bc; }
            set { this.bc = value; }
        }

        public double Perimeter { get; private set; }

        public double Square { get; private set; }
    }
}
