using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson2.Task3
{
    enum Months    {January, February, March, April, May, June, July, August, September, October, November, December }

    public class Task : IRunnable
    {
        public void Run()
        {
            Console.WriteLine("------------------Lesson2 Task3-----------------------");
            int n;
            Console.Write("Input n: ");
            while (!Int32.TryParse(Console.ReadLine(), out n))
            {
                Console.WriteLine("Error");
            }
            if (Enum.IsDefined(typeof(Months), n))
            {
                Console.WriteLine($"Value n is defined in Enum Months: {(Months)n} ");
            }
            else
                Console.WriteLine("n must be 0 <= n < 12 ");
            Console.WriteLine("--------------------------------------------------");

        }
    }
}
