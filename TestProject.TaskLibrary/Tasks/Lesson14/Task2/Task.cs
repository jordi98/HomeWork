using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Threading;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson14.Task2
{
    public class Task : IRunnable
    {
        private static Dictionary<string, string> cultureDictionary = new Dictionary<string, string> { { "gb", "en-GB" }, { "ua", "uk-UA" }, { "us", "en-US" },
            { "au", "en-AU" }, { "nl", "nl-NL" }, { "cn", "zh-CN" }, { "by", "be-BY" }, { "ca", "en-CA" } };

        public void Run(IConsole console)
        {
            console.WriteLine("------------------Lesson14 Task2-----------------------");
            console.Write("Input culture(gb, ua, us, au, nl, cn, by, ca): ");
            string currentCulture = console.ReadLine();
            string culture = cultureDictionary[currentCulture];
            if (!string.IsNullOrEmpty(culture))
            {
                DateTime dateTime = DateTime.Now;
                switch (currentCulture)
                {
                    case "ua":
                        console.WriteLine(dateTime.ToString(new CultureInfo(culture)));
                        break;
                    case "us":
                        console.WriteLine(dateTime.ToString(new CultureInfo(culture)));
                        break;
                    case "ca":
                        console.WriteLine(dateTime.ToString(new CultureInfo(culture)));
                        break;
                    case "gb":
                        console.WriteLine(dateTime.ToString(new CultureInfo(culture)));
                        break;
                    case "au":
                        console.WriteLine(dateTime.ToString(new CultureInfo(culture)));
                        break;
                    case "nl":
                        console.WriteLine(dateTime.ToString(new CultureInfo(culture)));
                        break;
                    case "cn":
                        console.WriteLine(dateTime.ToString(new CultureInfo(culture)));
                        break;
                    case "by":
                        console.WriteLine(dateTime.ToString(new CultureInfo(culture)));
                        break;
                    default:
                        break;
                }
            }

            console.WriteLine("------------------------------------------------------");
        }
    }
}
