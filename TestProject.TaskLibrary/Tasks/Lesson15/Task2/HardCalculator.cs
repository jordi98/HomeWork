using System;
using System.Collections.Generic;
using System.Text;

namespace TestProject.TaskLibrary.Tasks.Lesson15.Task2
{
    public static class HardCalculator
    {
        public static int[] Add(int[] num1, int[] num2)
        {
            if (num1.Length == num2.Length)
            {
                var c = new int[num1.Length];
                for (int i = 0; i < num1.Length; i++)
                {
                    c[i] = num1[i] + num2[i];
                }
                return c;
            }
            else if (num1.Length > num2.Length)
            {
                var c = new int[num1.Length];
                for (int i = 0; i < num2.Length; i++)
                {
                    c[i] = num1[i] + num2[i];
                }
                for (int i = num2.Length; i < num1.Length; i++)
                {
                    c[i] = num1[i];
                }
                return c;
            }
            else
            {
                var c = new int[num2.Length];
                for (int i = 0; i < num1.Length; i++)
                {
                    c[i] = num1[i] + num2[i];
                }
                for (int i = num1.Length; i < num2.Length; i++)
                {
                    c[i] = num2[i];
                }
                return c;
            }
        }

        public static int[] Sub(int[] num1, int[] num2)
        {
            if (num1.Length == num2.Length)
            {
                var c = new int[num1.Length];
                for (int i = 0; i < num1.Length; i++)
                {
                    c[i] = num1[i] - num2[i];
                }
                return c;
            }
            else if (num1.Length > num2.Length)
            {
                var c = new int[num1.Length];
                for (int i = 0; i < num2.Length; i++)
                {
                    c[i] = num1[i] - num2[i];
                }
                for (int i = num2.Length; i < num1.Length; i++)
                {
                    c[i] = num1[i];
                }
                return c;
            }
            else
            {
                var c = new int[num2.Length];
                for (int i = 0; i < num1.Length; i++)
                {
                    c[i] = num1[i] - num2[i];
                }
                for (int i = num1.Length; i < num2.Length; i++)
                {
                    c[i] = num2[i];
                }
                return c;
            }
        }

        public static int[] Mul(int[] num1, int[] num2)
        {
            if (num1.Length == num2.Length)
            {
                var c = new int[num1.Length];
                for (int i = 0; i < num1.Length; i++)
                {
                    c[i] = num1[i] * num2[i];
                }
                return c;
            }
            else if (num1.Length > num2.Length)
            {
                var c = new int[num1.Length];
                for (int i = 0; i < num2.Length; i++)
                {
                    c[i] = num1[i] * num2[i];
                }
                for (int i = num2.Length; i < num1.Length; i++)
                {
                    c[i] = num1[i];
                }
                return c;
            }
            else
            {
                var c = new int[num2.Length];
                for (int i = 0; i < num1.Length; i++)
                {
                    c[i] = num1[i] * num2[i];
                }
                for (int i = num1.Length; i < num2.Length; i++)
                {
                    c[i] = num2[i];
                }
                return c;
            }
        }

        public static int[] Div(int[] num1, int[] num2)
        {
            if (num1.Length == num2.Length)
            {
                var c = new int[num1.Length];
                for (int i = 0; i < num1.Length; i++)
                {
                    c[i] = num1[i] / num2[i];
                }
                return c;
            }
            else if (num1.Length > num2.Length)
            {
                var c = new int[num1.Length];
                for (int i = 0; i < num2.Length; i++)
                {
                    c[i] = num1[i] / num2[i];
                }
                for (int i = num2.Length; i < num1.Length; i++)
                {
                    c[i] = num1[i];
                }
                return c;
            }
            else
            {
                var c = new int[num2.Length];
                for (int i = 0; i < num1.Length; i++)
                {
                    c[i] = num1[i] / num2[i];
                }
                for (int i = num1.Length; i < num2.Length; i++)
                {
                    c[i] = num2[i];
                }
                return c;
            }
        }
    }
}
