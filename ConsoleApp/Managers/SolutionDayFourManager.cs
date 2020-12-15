using System.Linq;
using ConsoleApp.Interfaces;
using ConsoleApp.Solutions;

namespace ConsoleApp.Managers
{
    internal class SolutionDayFourManager : SolutionManagerBase
    {
        public SolutionDayFourManager(
            IInputFileRepository inputFileRepository) : base(
            inputFileRepository)
        {
        }

        protected override void InitSolution()
        {
            var input = InputFileRepository.GetDayFourInput();
            Solution = SolutionDayFour.FromList(input.ToList());
        }
    }
}