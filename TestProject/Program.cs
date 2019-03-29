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
            try
            {
                IRunnable runnable = LoggerProviderFactory.GetTask(14, 2);
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
