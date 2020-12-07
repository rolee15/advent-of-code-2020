using ConsoleApp.Adapters;
using ConsoleApp.Interfaces;
using ConsoleApp.Managers;
using ConsoleApp.Repositories;
using Xunit;

namespace ConsoleApp.IntegrationTests
{
    public class IntegrationTest
    {
        public IFileAdapter FileAdapter { get; set; }
        public IInputFileRepository InputFileRepository { get; set; }
        public IntegrationTest()
        {
            FileAdapter = new FileAdapter(".");
            InputFileRepository = new InputFileRepository(FileAdapter);
        }

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
        }
    }
}