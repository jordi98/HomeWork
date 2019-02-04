using System;
using System.Collections.Generic;
using System.Text;

namespace TestProject.TaskLibrary.Tasks.Lesson1.Task5
{
    class ComplexNumber
    {
        private double real;
        private double imaginary;

        public double Imaginary
        {
            get { return imaginary; }
            set { imaginary = value; }
        }

        public double Real
        {
            get { return real; }
            set { real = value; }
        }

        public ComplexNumber(double re, double im)
        {
            real = re;
            imaginary = im;
        }

        #region A+B
        public static ComplexNumber operator +(ComplexNumber a, ComplexNumber b)
        {
            return new ComplexNumber(a.real + b.real, a.imaginary + b.imaginary);
        }
        #endregion

        #region A*B
        public static ComplexNumber operator *(ComplexNumber a, ComplexNumber b)
        {
            return new ComplexNumber(a.real * b.real - a.imaginary * b.imaginary, a.real * b.imaginary + a.imaginary * b.real);
        }
        #endregion

        #region A/B
        public static ComplexNumber operator /(ComplexNumber a, ComplexNumber b)
        {
            return new ComplexNumber((a.real * b.real + a.imaginary * b.imaginary) / (b.real * b.real + b.imaginary * b.imaginary), (a.imaginary * b.real - a.real * b.imaginary) / (b.real * b.real + b.imaginary * b.imaginary));
        }
        #endregion
    }
}
