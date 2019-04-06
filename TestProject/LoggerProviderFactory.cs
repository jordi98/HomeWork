using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject
{
    public class LoggerProviderFactory
    {
        public static IRunnable GetTask(int lessonNumber, int taskNumber)
        {
            var dic = new Dictionary<int, Dictionary<int, IRunnable>>();
            var lesson1 = new Dictionary<int, IRunnable>
            {
                { 1, new TaskLibrary.Tasks.Lesson1.Task1.Task1() },
                { 2, new TaskLibrary.Tasks.Lesson1.Task2.Task2() },
                { 3, new TaskLibrary.Tasks.Lesson1.Task3.Task3() },
                { 4, new TaskLibrary.Tasks.Lesson1.Task4.Task4() },
                { 5, new TaskLibrary.Tasks.Lesson1.Task5.Task5() }
            };
            var lesson2 = new Dictionary<int, IRunnable>
            {
                { 1, new TaskLibrary.Tasks.Lesson2.Task1.Task() },
                { 2, new TaskLibrary.Tasks.Lesson2.Task2.Task() },
                { 3, new TaskLibrary.Tasks.Lesson2.Task3.Task() },
                { 4, new TaskLibrary.Tasks.Lesson2.Task4.Task() },
                { 5, new TaskLibrary.Tasks.Lesson2.Task5.Task() }
            };
            var lesson3 = new Dictionary<int, IRunnable>
            {
                { 1, new TaskLibrary.Tasks.Lesson3.Task1.Task() },
                { 2, new TaskLibrary.Tasks.Lesson3.Task2.Task() },
                { 3, new TaskLibrary.Tasks.Lesson3.Task3.Task() },
                { 4, new TaskLibrary.Tasks.Lesson3.Task4.Task() }
            };
            var lesson4 = new Dictionary<int, IRunnable>
            {
                { 1, new TaskLibrary.Tasks.Lesson4.Task1.Task() },
                { 2, new TaskLibrary.Tasks.Lesson4.Task2.Task() },
                { 3, new TaskLibrary.Tasks.Lesson4.Task3.Task() },
                { 4, new TaskLibrary.Tasks.Lesson4.Task4.Task() },
                { 5, new TaskLibrary.Tasks.Lesson4.Task5.Task() }
            };
            var lesson5 = new Dictionary<int, IRunnable>
            {
                { 1, new TaskLibrary.Tasks.Lesson5.Task1.Task() },
                { 2, new TaskLibrary.Tasks.Lesson5.Task2.Task() },
                { 3, new TaskLibrary.Tasks.Lesson5.Task3.Task() }
            };
            var lesson6 = new Dictionary<int, IRunnable>
            {
                { 1, new TaskLibrary.Tasks.Lesson6.Task1.Task() },
                { 2, new TaskLibrary.Tasks.Lesson6.Task2.Task() }
            };
            var lesson7 = new Dictionary<int, IRunnable>
            {
                { 1, new TaskLibrary.Tasks.Lesson7.Task1.Task() },
                { 2, new TaskLibrary.Tasks.Lesson7.Task2.Task() },
                { 3, new TaskLibrary.Tasks.Lesson7.Task3.Task() },
                { 4, new TaskLibrary.Tasks.Lesson7.Task4.Task() },
                { 5, new TaskLibrary.Tasks.Lesson7.Task5.Task() }
            };
            var lesson10 = new Dictionary<int, IRunnable>
            {
                { 1, new TaskLibrary.Tasks.Lesson10.Task1.Task() },
                { 2, new TaskLibrary.Tasks.Lesson10.Task2.Task() },
                { 4, new TaskLibrary.Tasks.Lesson10.Task4.Task() },
                { 5, new TaskLibrary.Tasks.Lesson10.Task5.Task() }
            };
            var lesson12 = new Dictionary<int, IRunnable>
            {
                { 1, new TaskLibrary.Tasks.Lesson12.Task1.Task() },
                { 2, new TaskLibrary.Tasks.Lesson12.Task2.Task() }
            };
            var lesson13 = new Dictionary<int, IRunnable>
            {
                { 1, new TaskLibrary.Tasks.Lesson13.Task1.Task() }
            };
            var lesson14 = new Dictionary<int, IRunnable>
            {
                { 1, new TaskLibrary.Tasks.Lesson14.Task1.Task() },
                { 2, new TaskLibrary.Tasks.Lesson14.Task2.Task() }
            };
            var lesson16 = new Dictionary<int, IRunnable>
            {
                { 1, new TaskLibrary.Tasks.Lesson16.Task.Task() }
            };

            dic.Add(1, lesson1);
            dic.Add(2, lesson2);
            dic.Add(3, lesson3);
            dic.Add(4, lesson4);
            dic.Add(5, lesson5);
            dic.Add(6, lesson6);
            dic.Add(7, lesson7);
            dic.Add(10, lesson10);
            dic.Add(12, lesson12);
            dic.Add(13, lesson13);
            dic.Add(14, lesson14);
            dic.Add(16, lesson16);

            try
            {
                return dic[lessonNumber][taskNumber];
            }
            catch (KeyNotFoundException)
            {
                throw;
            }
        }
    }
}
