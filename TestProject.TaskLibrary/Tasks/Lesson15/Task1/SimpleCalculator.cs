using System;
using System.Collections.Generic;
using System.Text;

namespace TestProject.TaskLibrary.Tasks.Lesson15.Task1
{
    public static class SimpleCalculator
    {
        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public static int Sub(int num1, int num2)
        {
            return num1 - num2;
        }

        public static int Mul(int num1, int num2)
        {
            return num1 * num2;
        }

        public static int Div(int num1, int num2)
        {
            return num1 / num2;
        }
    }
}
