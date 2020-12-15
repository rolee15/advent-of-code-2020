using System.Linq;
using ConsoleApp.Interfaces;
using ConsoleApp.Solutions;

namespace ConsoleApp.Managers
{
    internal class SolutionDayFiveManager : SolutionManagerBase
    {
        public SolutionDayFiveManager(
            IInputFileRepository inputFileRepository) : base(
            inputFileRepository)
        {
        }

        protected override void InitSolution()
        {
            var input = InputFileRepository.GetDayFiveInput();
            Solution = SolutionDayFive.FromList(input.ToList());
        }
    }
}