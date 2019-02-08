using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Udemy.DataTypes
{
    public class Task : IRunnable
    {
        public void Run(IConsole console)
        {
            char let1, let2, let3;
            Console.WriteLine("-------1-------");
            Console.Write("Enter letter: ");
            let1 = Convert.ToChar(Console.ReadLine());
            Console.Write("Enter letter: ");
            let2 = Convert.ToChar(Console.ReadLine());
            Console.Write("Enter letter: ");
            let3 = Convert.ToChar(Console.ReadLine());
            Console.WriteLine($"{let3} {let2} {let1}");
            Console.WriteLine("-------2-------");
            Console.Write("Enter number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter width: ");
            int w = Convert.ToInt32(Console.ReadLine());
            int w1 = w;
            for (int i = 0; i < w1; i++)
            {
                for (int j = 0; j < w; j++)
                {
                    Console.Write(n);
                }
                w--;
                Console.WriteLine();
            }
            Console.WriteLine("-------3-------");
            string user, pass;
            bool s = false;
            int att = 0;
            do
            {
                Console.Write("Input username: ");
                user = Console.ReadLine();
                Console.Write("Input password: ");
                pass = Console.ReadLine();
                if (user == "yura" && pass == "1111")
                {
                    s = true;
                    att = 3;
                }
                else
                {
                    s = false;
                    att++;
                }
            } while (user != "yura" && pass != "1111" && att != 3);
            if (s == true)
            {
                Console.WriteLine("Success");
            }
            else
            {
                Console.WriteLine("Error");
            }
            Console.WriteLine("-------4-------");
            int a, b;
            char operation;
            Console.Write("Input 1st num: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input operation: ");
            operation = Convert.ToChar(Console.ReadLine());
            switch (operation)
            {
                case '+':
                    Console.Write("Input 2nd num: ");
                    b = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"{a} + {b} = {a + b}");
                    break;
                case '-':
                    Console.Write("Input 2nd num: ");
                    b = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"{a} - {b} = {a - b}");
                    break;
                case '*':
                    Console.Write("Input 2nd num: ");
                    b = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"{a} * {b} = {a * b}");
                    break;
                case '/':
                    Console.Write("Input 2nd num: ");
                    b = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"{a} / {b} = {a / b}");
                    break;
                default:
                    Console.WriteLine("Error");
                    break;
            }

        }
    }
}