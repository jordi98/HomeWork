using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson1.Task5
{
    public class Task5 : IRunnable
    {
        public void Run()
        {
            Console.WriteLine("--------------------------Task5--------------------");
            double Are = 0, Aim = 0, Bre = 0, Bim = 0;
            Console.WriteLine("Number A\nInput real part: ");
            while (!Double.TryParse(Console.ReadLine(), out Are))
            {
                Console.WriteLine("Error");
            }
            Console.WriteLine("Input imaginary part: ");
            while (!Double.TryParse(Console.ReadLine(), out Aim))
            {
                Console.WriteLine("Error");
            }
            Console.WriteLine("Number B\nInput real part: ");
            while (!Double.TryParse(Console.ReadLine(), out Bre))
            {
                Console.WriteLine("Error");
            }
            Console.WriteLine("Input imaginary part: ");
            while (!Double.TryParse(Console.ReadLine(), out Bim))
            {
                Console.WriteLine("Error");
            }
            try
            {
                ComplexNumber A = new ComplexNumber(Are, Aim);
                ComplexNumber B = new ComplexNumber(Bre, Bim);
                Console.WriteLine($"Sum is {(A + B).Real} + {(A + B).Imaginary}i.\n" +
                    $"Mult is {(A * B).Real} + {(A * B).Imaginary}i.");
                if (Bre != 0 && Bim != 0)
                {
                    Console.WriteLine($"Div is {(A / B).Real} + {(A / B).Imaginary}i");
                }
                else
                {
                    Console.WriteLine("Error! Division by 0");
                }
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("-------------------------------------------------------");
        }
    }
}
