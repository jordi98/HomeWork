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
            double Are = 0, Aim = 0, Bre = 0, Bim = 0;
            console.WriteLine("Number A\nInput real part: ");
            while (!Double.TryParse(console.ReadLine(), out Are))
            {
                console.WriteLine("Error");
            }
            console.WriteLine("Input imaginary part: ");
            while (!Double.TryParse(console.ReadLine(), out Aim))
            {
                console.WriteLine("Error");
            }
            console.WriteLine("Number B\nInput real part: ");
            while (!Double.TryParse(console.ReadLine(), out Bre))
            {
                console.WriteLine("Error");
            }
            console.WriteLine("Input imaginary part: ");
            while (!Double.TryParse(console.ReadLine(), out Bim))
            {
                console.WriteLine("Error");
            }
            ComplexNumber A = new ComplexNumber(Are, Aim);
            ComplexNumber B = new ComplexNumber(Bre, Bim);
            console.WriteLine($"Sum is {(A + B).Real} + {(A + B).Imaginary}i.\n" +
                $"Mult is {(A * B).Real} + {(A * B).Imaginary}i.");
            if (Bre != 0 && Bim != 0)
            {
                console.WriteLine($"Div is {(A / B).Real} + {(A / B).Imaginary}i");
            }
            else
            {
                console.WriteLine("Error! Division by 0");
            }
            console.WriteLine("-------------------------------------------------------");
        }
    }
}
