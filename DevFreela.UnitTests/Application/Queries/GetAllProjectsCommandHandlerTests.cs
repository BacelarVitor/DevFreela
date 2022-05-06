using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using DevFreela.Application.Queries.GetAllProjects;
using DevFreela.Core.Entities;
using DevFreela.Core.Repositories;
using Moq;
using Xunit;

namespace DevFreela.UnitTests.Application.Queries
{
    public class GetAllProjectsCommandHandlerTests
    {
        [Fact]
        //Given_When_Then
        public async Task ThreeProjectsExists_Executed_ReturnThreeProjectViewModels()
        {
            //Arrange
            var projects = new List<Project>()
            {
                new Project("Test 1", "Desc test 1", 1, 2, 100.0m),
                new Project("Test 2", "Desc test 2", 6, 4, 2100.0m),
                new Project("Test 3", "Desc test 3", 3, 2, 980.0m),
            };

            var projectRepository = new Mock<IProjectRepository>();
            projectRepository.Setup(pr => pr.GetAllAsync().Result).Returns(projects);

            var getAllProjectsQuery = new GetAllProjectsQuery(string.Empty);
            var getAllProjectsQueryHandler = new GetAllProjectsQueryHandler(projectRepository.Object);

            //Act
            var projectViewModeList = await getAllProjectsQueryHandler.Handle(getAllProjectsQuery, new CancellationToken());

            //Asset
            Assert.Equal(3, projectViewModeList.Count);
        }
    }
}