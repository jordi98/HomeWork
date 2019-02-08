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
                //new TaskLibrary.Tasks.Lesson1.Task1.Task1(),
                //new TaskLibrary.Tasks.Lesson3.Task3.Task()
                new TaskLibrary.Udemy.Arrays.Task()
            };

            foreach (var task in tasks)
            {
                task.Run(new Cons());
            }
            Console.ReadLine();
        }
    }
}
