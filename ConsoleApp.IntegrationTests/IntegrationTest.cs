using System.Collections.Generic;
using System.Linq;
using ConsoleApp.Adapters;
using ConsoleApp.DTO;
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
            Manager = new SolutionManager(InputFileRepository);
        }

        private IFileAdapter FileAdapter { get; }
        private IInputFileRepository InputFileRepository { get; }
        private SolutionManager Manager { get; }
        private List<Results> AllResults { get; set; }

        [Fact]
        public void SolveAll()
        {
            var allResults = Manager.SolveAll().ToList();

            var results = allResults[0];
            Assert.Equal("Day 1: Report Repair", results.Title);
            Assert.Equal(1016131, results.FirstResult);
            Assert.Equal(276432018, results.SecondResult);

            results = allResults[1];
            Assert.Equal("Day 2: Password Philosophy", results.Title);
            Assert.Equal(474, results.FirstResult);
            Assert.Equal(745, results.SecondResult);

            results = allResults[2];
            Assert.Equal("Day 3: Toboggan Trajectory", results.Title);
            Assert.Equal(234, results.FirstResult);
            Assert.Equal(5813773056L, results.SecondResult);

            results = allResults[3];
            Assert.Equal("Day 4: Passport Processing", results.Title);
            Assert.Equal(264, results.FirstResult);
            Assert.Equal(224, results.SecondResult);

            results = allResults[4];
            Assert.Equal("Day 5: Binary Boarding", results.Title);
            Assert.Equal(959, results.FirstResult);
            Assert.Equal(527, results.SecondResult);
        }
    }
}