using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson16.Task
{
    public class Task : IRunnable
    {
        public void Run(IConsole console)
        {
            console.WriteLine("------------------Lesson16 Task1-----------------------");
            Assembly assembly = Assembly.LoadFile(@"C:\Users\user\Desktop\Epam\VectorLibrary.dll");
            foreach (var item in assembly.GetModules(true))
            {
                console.WriteLine($"{item}");
            }

            foreach (var type in assembly.GetExportedTypes())
            {
                console.WriteLine($"{type}");
                foreach (var member in type.GetMembers())
                {
                    console.WriteLine($"{member}");
                    if (member.MemberType == MemberTypes.Method)
                    {
                        foreach (var parameterInfo in ((MethodInfo)member).GetParameters())
                        {
                            console.WriteLine($"{parameterInfo}");
                        }
                    }
                }
            }

            console.WriteLine("-------------------------------------------------------");
        }
    }
}
