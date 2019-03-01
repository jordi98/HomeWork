using System;
using System.Collections.Generic;
using System.Text;

namespace TestProject.Common.Core.Interfaces
{
    public interface IDraw
    {
        void Draw(IConsole console, char[,] axis);
    }
}
