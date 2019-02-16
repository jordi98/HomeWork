using System;
using System.Threading.Tasks;
using TestProject.Common.Core.Interfaces;

namespace TestProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //List of .NetLab Tasks
            var tasks = new IRunnable[]
            {
                //new TaskLibrary.Udemy.Arrays.Task()
                //new TaskLibrary.Tasks.Lesson1.Task1.Task1(),
                new TaskLibrary.Tasks.Lesson5.Task3.Task()
            };

            foreach (var task in tasks)
            {
                task.Run(new Cons());
            }
            Console.ReadLine();
        }
    }
}
