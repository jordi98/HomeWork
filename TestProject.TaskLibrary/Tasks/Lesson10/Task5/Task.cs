using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson10.Task5
{
    public class Task : IRunnable
    {
        public void Run(IConsole console)
        {
            console.WriteLine("------------------Lesson10 Task5-----------------------");
            int a, b;
            console.Write("Input a: ");
            while (!int.TryParse(console.ReadLine(), out a))
            {
                console.WriteLine("Error");
            }

            console.Write("Input b: ");
            while (!int.TryParse(console.ReadLine(), out b))
            {
                console.WriteLine("Error");
            }

            try
            {
                this.DoSomeMath(a, b);
            }
            catch (ArgumentException e)
            when (e.ParamName == "a")
            {
                console.WriteLine($"{e.Message}");
            }
            catch (ArgumentException e)
            when (e.ParamName == "b")
            {
                console.WriteLine($"{e.Message}");
            }

            console.WriteLine("------------------------------------------------------");
        }

        private void DoSomeMath(int a, int b)
        {
            if (a < 0)
            {
                ArgumentException argEx = new ArgumentException("Parameter should be greater than 0", "a");
                throw argEx;
            }

            if (b > 0)
            {
                ArgumentException argEx = new ArgumentException("Parameter should be less than 0", "b");
                throw argEx;
            }
        }
    }
}
