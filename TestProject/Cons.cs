using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject
{
    public class Cons : IConsole
    {
        public void WriteLine(string str)
        {
            Console.WriteLine(str);
        }
        public void Write(string str)
        {
            Console.Write(str);
        }
        public string ReadLine()
        {
            return Console.ReadLine();
        }
    }
}
