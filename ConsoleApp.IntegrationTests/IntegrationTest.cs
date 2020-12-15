using ConsoleApp.Adapters;
using ConsoleApp.Interfaces;
using ConsoleApp.Managers;
using ConsoleApp.Repositories;
using Xunit;

namespace ConsoleApp.IntegrationTests
{
    public class IntegrationTest
    {
        public IntegrationTest()
        {
            FileAdapter = new FileAdapter(".");
            InputFileRepository = new InputFileRepository(FileAdapter);
        }

        private IFileAdapter FileAdapter { get; }
        private IInputFileRepository InputFileRepository { get; }

        [Fact]
        public void DayOne()
        {
            //Given
            var manager = new SolutionDayOneManager(InputFileRepository);

            //When
            var results = manager.GetResults();

            //Then
            Assert.Equal(1016131, results.FirstResult);
            Assert.Equal(276432018, results.SecondResult);
        }

        [Fact]
        public void DayTwo()
        {
            //Given
            var manager = new SolutionDayTwoManager(InputFileRepository);

            //When
            var results = manager.GetResults();

            //Then            
            Assert.Equal(474, results.FirstResult);
            Assert.Equal(745, results.SecondResult);
        }

        [Fact]
        public void DayThree()
        {
            //Given
            var manager = new SolutionDayThreeManager(InputFileRepository);

            //When
            var results = manager.GetResults();

            //Then
            Assert.Equal(234, results.FirstResult);
            Assert.Equal(5813773056L, results.SecondResult);
        }

        [Fact]
        public void DayFour()
        {
            //Given
            var manager = new SolutionDayFourManager(InputFileRepository);

            //When
            var results = manager.GetResults();

            //Then
            Assert.Equal(264, results.FirstResult);
            Assert.Equal(224, results.SecondResult);
        }

        [Fact]
        public void DayFive()
        {
            //Given
            var manager = new SolutionDayFiveManager(InputFileRepository);

            //When
            var results = manager.GetResults();

            //Then
            Assert.Equal(959, results.FirstResult);
            //Assert.Equal(224, results.SecondResult);
        }
    }
}