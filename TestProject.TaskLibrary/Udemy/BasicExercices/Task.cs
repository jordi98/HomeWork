using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Udemy.BasicExercices
{
    public class Task : IRunnable
    {
        public void Run(IConsole console)
        {
            Console.WriteLine("-------1-------");
            Console.WriteLine("Hello:\nYuri Danchyshyn");
            Console.WriteLine("-------2-------");
            Console.WriteLine(2 + 2);
            Console.WriteLine("-------3-------");
            Console.WriteLine(4 / 2);
            Console.WriteLine("-------4-------");
            Console.WriteLine($"{-1 + 4 * 6}\n{(35 + 5) % 7}\n{14 + -4 * 6 / 11}\n{2 + 15 / 6 * 1 - 7 % 2}");
            int a, b, c, d;
            Console.WriteLine("-------5-------");
            Console.Write("Input 1st number: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input 2nd number: ");
            b = Convert.ToInt32(Console.ReadLine());
            c = a; a = b; b = c;
            Console.WriteLine($"After swap:\n1st number: {a}\n2nd number: {b}");
            Console.WriteLine("-------6-------");
            Console.Write("Input 1st number to mult: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input 2nd number to mult: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input 3rd number to mult: ");
            c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{a} x {b} x {c} = {a * b * c}");
            Console.WriteLine("-------7-------");
            Console.Write("Input 1st number: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input 2nd number: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{a}+{b}={a + b}\n{a}-{b}={a - b}\n{a}*{b}={a * b}\n{a}/{b}={a / b}\n{a}mod{b}={a % b}");
            Console.WriteLine("-------8-------");
            Console.Write("Enter number: ");
            d = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= 10; i++)
            {
                Console.Write($"{d} * {i} = {d * i}\n");
            }
        }
    }
}
