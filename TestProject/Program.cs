using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TestProject.Common.Core.Interfaces;

namespace TestProject
{
    class Program
    {
        static void Main(string[] args)
        {
            int lessonNumber, taskNumber;
            try
            {
                lessonNumber = 17;
                taskNumber = 1;
                IRunnable runnable = LoggerProviderFactory.GetTask(lessonNumber, taskNumber);
                runnable.Run(new Cons());
            }
            catch (KeyNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }
    }
}
