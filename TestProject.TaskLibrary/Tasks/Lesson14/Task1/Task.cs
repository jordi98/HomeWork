using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson14.Task1
{
    public class Task : IRunnable
    {
        public void Run(IConsole console)
        {
            string first = "Ґанок";
            string second = "Ґанок";
            CultureInfo cultureInfo = new CultureInfo("uk-UA");
            var areEqual = string.Equals(first, second, StringComparison.CurrentCulture);
            console.WriteLine($"The two strings are equal - {areEqual}");
        }
    }
}
