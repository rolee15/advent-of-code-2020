using System.Collections.Generic;
using ConsoleApp.DTO;

namespace ConsoleApp.Interfaces
{
    internal interface ISolutionManager
    {
        IEnumerable<Results> SolveAll();
    }
}