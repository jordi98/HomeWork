using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson12.Task2
{
    public class Task : IRunnable
    {
        public void Run(IConsole console)
        {
            console.WriteLine("------------------Lesson12 Task2-----------------------");
            console.Write("Input name: ");
            string name = console.ReadLine();
            this.FindByName(console, "C:\\Users\\user\\Documents", name);
            console.WriteLine("-------------------------------------------------------");
        }

        private void FindByName(IConsole console, string path, string partiallyName)
        {
            var dir = new DirectoryInfo(path);
            var files = new List<FileInfo>();
            try
            {
                files = dir.EnumerateFiles("*" + partiallyName + "*.txt").ToList();
                foreach (var file in files)
                {
                    console.WriteLine(file.FullName);
                }
                
            }
            catch (UnauthorizedAccessException uAEx)
            {
                console.WriteLine(uAEx.Message);
            }

            if (!dir.Exists)
            {
                console.WriteLine("Dir does not exist");
            }

            try
            {
                foreach (var directory in dir.EnumerateDirectories("*"))
                {
                    FindByName(console, path + "\\" + directory.Name, partiallyName);
                }
            }
            catch (UnauthorizedAccessException unAuthTop)
            {
                console.WriteLine($"\t{unAuthTop.Message}");
            }
            
        }
    }
}
