using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Udemy.Arrays
{
    public class Task : IRunnable
    {
        public void Run(IConsole console)
        {
            int[] A = new int[50];
            Console.WriteLine("-------1-------");
            Console.WriteLine("Input 10 elements in the array:");
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Element {i}: ");
                A[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Elements in array are:");
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"{A[i]} ");
            }
            Console.WriteLine("\n-------2-------");
            int n;
            Console.Write("Input the number of elements to store in the array: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Input {n} elements in the array:");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Element {i}: ");
                A[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("The values store into the array are:");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{A[i]} ");
            }
            Console.WriteLine("\nThe values store into the array in reverse are:");
            for (int i = n - 1; i >= 0; i--)
            {
                Console.Write($"{A[i]} ");
            }
            Console.WriteLine("\n-------3-------");
            Console.Write("Input the number of elements to store in the array: ");
            int sum = 0;
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Input {n} elements in the array:");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Element {i}: ");
                A[i] = Convert.ToInt32(Console.ReadLine());
                sum += A[i];
            }
            Console.WriteLine($"Sum of all elements stored in the array is: {sum}");

            Console.WriteLine("-------4-------");
            Console.Write("Input the number of elements to store in the array: ");
            n = Convert.ToInt32(Console.ReadLine());
            int[] B = new int[50];
            Console.WriteLine($"Input {n} elements in the array:");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Element {i}: ");
                A[i] = Convert.ToInt32(Console.ReadLine());
                B[i] = A[i];
            }
            Console.WriteLine("The elements stored in the first array are:");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{A[i]} ");
            }
            Console.WriteLine("\nThe elements copied into the second array are:");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{B[i]} ");
            }
            Console.WriteLine("\n-------5-------");
            int counter = 0;
            Console.Write("Input the number of elements to store in the array: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Input {n} elements in the array:");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Element {i}: ");
                A[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < n - 1; i++)
                for (int j = i + 1; j < n; j++)
                {
                    if (A[j] == A[i])
                    {
                        counter++;
                        break;
                    }
                }
            Console.WriteLine($"Total number of duplicate elements found in the array is :{counter}");
        }
    }
}
