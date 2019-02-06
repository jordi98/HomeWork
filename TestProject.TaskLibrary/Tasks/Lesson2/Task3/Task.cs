using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson2.Task3
{
    enum Months    {January, February, March, April, May, June, July, August, September, October, November, December }

    public class Task : IRunnable
    {
        public void Run(IConsole console)
        {
            console.WriteLine("------------------Lesson2 Task3-----------------------");
            int n;
            console.Write("Input n: ");
            while (!Int32.TryParse(console.ReadLine(), out n))
            {
                console.WriteLine("Error");
            }
            if (Enum.IsDefined(typeof(Months), n))
            {
                console.WriteLine($"Value n is defined in Enum Months: {(Months)n} ");
            }
            else
                console.WriteLine("n must be 0 <= n < 12 ");
            console.WriteLine("--------------------------------------------------");

        }
    }
}
