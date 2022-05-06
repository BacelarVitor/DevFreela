using DevFreela.Core.Entities;
using DevFreela.Core.Enums;
using Xunit;

namespace DevFreela.UnitTests.Core.Entities
{
    public class ProjectTests
    {
        [Fact]
        public void ProjectStart_Executed_StatusIsInProgressAndStartedAtNotNull()
        {
            // Arrange
            var project = new Project("Test", "Desc de test", 1, 2, 190.0m);

            // Act
            project.Start();

            // Assert 
            Assert.Equal(ProjectStatusEnum.InProgress, project.Status);
            Assert.NotNull(project.StartedAt);

        }

        [Fact]
        public void ProjectCancel_Executed_StatusIsCancelled()
        {
            // Arrange
            var project = new Project("Test", "Desc de test", 1, 2, 100.0m);
            project.Start();

            // Act
            project.Cancel();

            // Assert
            Assert.Equal(ProjectStatusEnum.Cancelled, project.Status);
        }

        [Fact]
        public void ProjectFinish_Executed_StatusIsFinishedAndFinishedAtNotNull()
        {
            // Arrange
            var project = new Project("Test", "Desc de test", 2, 4, 90.0m);
            project.Start();

            // Act
            project.Finish();

            // Assert
            Assert.Equal(ProjectStatusEnum.Finished, project.Status);
            Assert.NotNull(project.FinishedAt);
        }

        [Fact]
        public void ProjectFinish_Executed_StatusIsCreatedAndFinishAtIsNull()
        {
            // Arrange
            var project = new Project("Test", "Desc test", 4, 9, 203.58m);

            // Act
            project.Finish();

            // Assert
            Assert.Equal(ProjectStatusEnum.Created, project.Status);
            Assert.Null(project.FinishedAt);
        }

        [Fact]
        public void ProjectStart_Executed_StatusIsCancelledAndStartAtIsNull()
        {
            // Arrange
            var project = new Project("Test", "Desc test", 4, 9, 203.58m);
            project.Cancel();

            // Act
            project.Start();

            // Assert
            Assert.Equal(ProjectStatusEnum.Cancelled, project.Status);
            Assert.Null(project.StartedAt);
        }
    }
}