using System.Linq;
using ConsoleApp.Interfaces;
using ConsoleApp.Solutions;

namespace ConsoleApp.Managers
{
    internal class SolutionDayThreeManager : SolutionManagerBase
    {
        public SolutionDayThreeManager(IInputFileRepository inputFileRepository) : base(inputFileRepository)
        {
        }

        protected override void InitSolution()
        {
            var input = InputFileRepository.GetDayThreeInput();
            Solution = SolutionDayThree.FromList(input.ToList());
        }
    }
}