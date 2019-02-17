using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson4.TestBubleSort
{
    public class Main : IRunnable
    {
        static void BubbleSort(IConsole console, int[] arr)
        {
            console.WriteLine("Buble sort:");
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        var temp = arr[j + 1];
                        arr[j + 1] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
        }
        static void OptBubbleSort(IConsole console, int[] arr)
        {
            console.WriteLine("Optimized Buble sort:");
            int temp = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
        }
        public void Run(IConsole console)
        {
            DateTime timeStart;
            DateTime timeEnd;
            //var timer = new System.Timers.Timer();
            var array1 = new int[] { 4, 54, 2, 86, 5, 3, 67, 11, 2, 8 };
            timeStart = DateTime.Now;
            BubbleSort(console, array1);
            timeEnd = DateTime.Now;
            console.WriteLine($"Time to sort: {(timeEnd - timeStart).Milliseconds} miliseconds");
            for (int i = 0; i < array1.Length; i++)
            {
                console.Write(array1[i] + " ");
            }
            console.WriteLine("\n");
            var array2 = new int[] { 4, 54, 2, 86, 5, 3, 67, 11, 2, 8 };            
            timeStart = DateTime.Now;
            OptBubbleSort(console, array2);
            timeEnd = DateTime.Now;
            console.WriteLine($"Time to sort: {(timeEnd - timeStart).Milliseconds} miliseconds");
            for (int i = 0; i < array2.Length; i++)
            {
                console.Write(array2[i] + " ");
            }
            console.WriteLine("\n");

        }
    }
}
