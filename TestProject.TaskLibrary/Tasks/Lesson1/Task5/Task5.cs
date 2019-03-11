using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson1.Task5
{
    public class Task5 : IRunnable
    {
        public void Run(IConsole console)
        {
            console.WriteLine("--------------------------Lesson1 Task5--------------------");
            double reA = 0, imA = 0, reB = 0, imB = 0;
            console.WriteLine("Number A\nInput real part: ");
            while (!double.TryParse(console.ReadLine(), out reA))
            {
                console.WriteLine("Error");
            }

            console.WriteLine("Input imaginary part: ");
            while (!double.TryParse(console.ReadLine(), out imA))
            {
                console.WriteLine("Error");
            }

            console.WriteLine("Number B\nInput real part: ");
            while (!double.TryParse(console.ReadLine(), out reB))
            {
                console.WriteLine("Error");
            }

            console.WriteLine("Input imaginary part: ");
            while (!double.TryParse(console.ReadLine(), out imB))
            {
                console.WriteLine("Error");
            }

            ComplexNumber a = new ComplexNumber(reA, imA);
            ComplexNumber b = new ComplexNumber(reB, imB);
            console.WriteLine($"Sum is {(a + b).Real} + {(a + b).Imaginary}i.\n" +
                $"Mult is {(a * b).Real} + {(a * b).Imaginary}i.");
            if (reB != 0 && imB != 0)
            {
                console.WriteLine($"Div is {(a / b).Real} + {(a / b).Imaginary}i");
            }
            else
            {
                console.WriteLine("Error! Division by 0");
            }

            console.WriteLine("-------------------------------------------------------");
        }
    }
}
