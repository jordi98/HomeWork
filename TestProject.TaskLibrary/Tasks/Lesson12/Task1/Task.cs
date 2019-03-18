using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson12.Task1
{
    public class Task : IRunnable
    {
        public void Run(IConsole console)
        {
            console.WriteLine("------------------Lesson12 Task1-----------------------");
            DirectoryInfo dir = new DirectoryInfo(@"d:\Yura");
            console.WriteLine(dir.ToString());
            this.ShowFiles(console, dir);
            console.WriteLine("------------------------------------------------------");
        }

        private void ShowFiles(IConsole console, DirectoryInfo dir)
        {
            DirectoryInfo[] dirSubDirectories = dir.GetDirectories();
            FileInfo[] dirFiles = dir.GetFiles();
            foreach (DirectoryInfo d in dirSubDirectories)
            {
                console.WriteLine(d.ToString());
                this.ShowFiles(console, d);
            }

            foreach (FileInfo f in dirFiles)
            {
                console.WriteLine(f.ToString());
            }
        }
    }
}
