using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson17.Task1
{
    public class Task : IRunnable
    {
        public static int TotalSum;
        public void Run(IConsole console)
        {
            console.WriteLine("------------------Lesson17 Task1-----------------------");
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0, 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 };
            Thread t1 = new Thread(Sum1);
            t1.Start(array);
            Thread t2 = new Thread(Sum2);
            t2.Start(array);
            Thread t3 = new Thread(Sum3);
            t3.Start(array);
            Thread t4 = new Thread(Sum4);
            t4.Start(array);
            t4.Join();
            console.WriteLine($"Sum: {TotalSum}");
            console.WriteLine("-------------------------------------------------------");
        }

        private static void Sum1(object y)
        {
            int sum = 0;
            int[] a = y as int[];
            for (int i = 0; i < a.Length / 4; i++)
            {
                if (a[i] % 2 == 0)
                {
                    sum += a[i];
                }
            }

            TotalSum += sum;
        }

        private static void Sum2(object y)
        {
            int sum = 0;
            int[] a = y as int[];
            for (int i = a.Length / 4; i < a.Length / 2; i++)
            {
                if (a[i] % 2 == 0)
                {
                    sum += a[i];
                }
            }

            TotalSum += sum;
        }

        private static void Sum3(object y)
        {
            int sum = 0;
            int[] a = y as int[];
            for (int i = a.Length / 2; i < 3 * a.Length / 4; i++)
            {
                if (a[i] % 2 == 0)
                {
                    sum += a[i];
                }
            }

            TotalSum += sum;
        }

        private static void Sum4(object y)
        {
            int sum = 0;
            int[] a = y as int[];
            for (int i = 3 * a.Length / 4; i < a.Length; i++)
            {
                if (a[i] % 2 == 0)
                {
                    sum += a[i];
                }
            }

            TotalSum += sum;
        }
    }
}
