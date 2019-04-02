using System;
using System.Collections.Generic;
using System.Text;

namespace TestProject.Common.Core.Interfaces
{
    public interface ICalculator<T>
    {
        T Add(T num1, T num2);

        T Sub(T num1, T num2);

        T Mul(T num1, T num2);

        T Div(T num1, T num2);
    }
}
