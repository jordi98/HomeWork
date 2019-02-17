using System;
using System.Collections.Generic;
using System.Text;

namespace TestProject.TaskLibrary.Tasks.Lesson5
{
    class Person
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public IEnumerable<string> PhoneNumbers { get; set; }
    }
}
