using System;
using Xunit;
using ConsoleApp.Adapters;
using ConsoleApp.Repositories;
using ConsoleApp.Managers;

namespace ConsoleApp.IntegrationTests
{
    public class IntegrationTest
    {
        [Fact]
        public void DayOne()
        {
        //Given
        var consoleAdapter = new ConsoleAdapter();
        var fileAdapter = new FileAdapter(".");
        var inputFileRepository = new InputFileRepository(fileAdapter);
        var manager = new SolutionDayOneManager(inputFileRepository);
        
        //When
        var results = manager.GetResults();
        
        //Then
        Assert.Equal(1016131, results.FirstResult);
        Assert.Equal(276432018, results.SecondResult);
        }
    }
}
