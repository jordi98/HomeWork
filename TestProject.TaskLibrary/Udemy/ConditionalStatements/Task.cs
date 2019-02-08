using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Udemy.ConditionalStatements
{
    public class Task : IRunnable
    {
        public void Run(IConsole console)
        {
            Console.WriteLine("-------1-------");
            int a, b;
            Console.Write("Input 1st number: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input 2nd number: ");
            b = Convert.ToInt32(Console.ReadLine());
            if (a == b)
            {
                Console.WriteLine($"{a} and {b} are equal");
            }
            else
                Console.WriteLine($"{a} and {b} are not equal");
            Console.WriteLine("-------2-------");
            Console.Write("Input number: ");
            a = Convert.ToInt32(Console.ReadLine());
            if (a % 2 == 0)
            {
                Console.WriteLine($"{a} is even");
            }
            else
                Console.WriteLine($"{a} is odd");
            Console.WriteLine("-------3-------");
            Console.Write("Input number: ");
            a = Convert.ToInt32(Console.ReadLine());
            if (a > 0)
            {
                Console.WriteLine($"{a} is positive");
            }
            else if (a < 0)
            {
                Console.WriteLine($"{a} is negative");
            }
            Console.WriteLine("-------4-------");
            Console.Write("Input year: ");
            a = Convert.ToInt32(Console.ReadLine());
            if (a % 4 == 0)
            {
                if (a % 100 == 0)
                {
                    if (a % 400 == 0)
                    {
                        Console.WriteLine("Leap year");
                    }
                    else
                    {
                        Console.WriteLine("Not a leap year");
                    }
                }
                else
                {
                    Console.WriteLine("Leap year");
                }
            }
            else
            {
                Console.WriteLine("Not a leap year");
            }
            Console.WriteLine("-------5-------");
            Console.Write("Input age: ");
            a = Convert.ToInt32(Console.ReadLine());
            if (a >= 18)
            {
                Console.WriteLine("Congratulation! You are eligible for casting your vote");
            }
            else
                Console.WriteLine("Sorry! You are not eligible for casting your vote");

        }
    }
}