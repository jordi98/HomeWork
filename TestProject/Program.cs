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
                new TaskLibrary.Tasks.Lesson1.Task1.Task1(),
                //new TaskLibrary.Tasks.Lesson1.Task2.Task2(),
                //new TaskLibrary.Tasks.Lesson1.Task3.Task3(),
                //new TaskLibrary.Tasks.Lesson1.Task4.Task4(),
                //new TaskLibrary.Tasks.Lesson1.Task5.Task5(),
            };

            foreach (var task in tasks)
            {
                task.Run();
            }
            Console.ReadLine();
        }
    }
}
