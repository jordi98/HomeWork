using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson2.Task2
{
    public struct Rectangle : ISize, ICoordinates
    {
        public double Width { get; set; }

        public double Height { get; set; }

        public double X { get; set; }

        public double Y { get; set; }

        public double Perimeter()
        {
            return 2 * (this.Width + this.Height);
        }
    }
}
