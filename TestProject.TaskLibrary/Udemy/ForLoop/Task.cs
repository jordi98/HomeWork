using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Udemy.ForLoop
{
    public class Task : IRunnable
    {
        public void Run(IConsole console)
        {
            Console.WriteLine("-------1-------");
            Console.WriteLine("The first 10 natural number is :");
            for (int i = 1; i < 11; i++)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine("\n-------2-------");
            int sum = 0;
            Console.WriteLine("The first 10 natural number is :");
            for (int i = 1; i < 11; i++)
            {
                Console.Write($"{i} ");
                sum += i;
            }
            Console.WriteLine($"\nSum is: {sum}");
            Console.WriteLine("-------3-------");
            int n;
            sum = 0;
            Console.Write("Input n: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"The first {n} natural number is :");
            for (int i = 1; i <= n; i++)
            {
                Console.Write($"{i} ");
                sum += i;
            }
            Console.WriteLine($"\nThe Sum of Natural Number upto {n} terms: {sum}");
            Console.WriteLine("-------4-------");
            double avg;
            sum = 0;
            Console.WriteLine("Input the 10 numbers:");
            for (int i = 1; i < 11; i++)
            {
                Console.Write($"Number {i}: ");
                n = Convert.ToInt32(Console.ReadLine());
                sum += n;
            }
            avg = sum / 10.0;
            Console.WriteLine($"The sum of 10 no is : {sum}\nThe Average is : {avg}");
            Console.WriteLine("-------5-------");
            Console.Write("Input number of terms: ");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.Write($"Number is: {i} and cube of the {i} is: {i * i * i}\n");
            }
            Console.WriteLine("-------6-------");
            Console.Write("Input the number (Table to be calculated): ");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= 10; i++)
            {
                Console.Write($"{n} * {i} = {n * i}\n");
            }

        }
    }
}