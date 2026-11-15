using GradeTracker;

namespace ConsoleApplications.Tests
{
    public class GradeManagerTests
    {
        private readonly GradeManager _manager = new GradeManager();

        [Theory]
        [InlineData(85, "A")]
        [InlineData(75, "B")]
        [InlineData(65, "C")]
        [InlineData(55, "D")]
        [InlineData(35, "F")]
        public void GetGrade_ReturnsCorrectGrade(
            double score, string expectedGrade)
        {
            // Act
            string result = _manager.GetGrade(score);

            // Assert
            Assert.Equal(expectedGrade, result);
        }

        [Fact]
        public void CalculateAverageFor_ReturnsCorrectAverage()
        {
            // Arrange
            double[] scores = { 85, 72, 45, 90, 60 };

            // Act
            double result = GradeManager.CalculateAverageFor(scores);

            // Assert
            Assert.Equal(70.4, result, 2);
        }

        [Fact]
        public void GetHighestScoreFrom_ReturnsHighestScore()
        {
            // Arrange
            double[] scores = { 85, 72, 45, 90, 60 };

            // Act
            double result = GradeManager.GetHighestScoreFrom(scores);

            // Assert
            Assert.Equal(90, result);
        }

        [Fact]
        public void GetLowestScoreFrom_ReturnsLowestScore()
        {
            // Arrange
            double[] scores = { 85, 72, 45, 90, 60 };

            // Act
            double result = GradeManager.GetLowestScoreFrom(scores);

            // Assert
            Assert.Equal(45, result);
        }

        [Fact]
        public void CalculateAverageFor_ThrowsException_WhenArrayIsEmpty()
        {
            // Arrange
            double[] scores = Array.Empty<double>();

            // Act & Assert
            Assert.Throws<ArgumentException>(
                () => GradeManager.CalculateAverageFor(scores));
        }

        [Fact]
        public void GetHighestScoreFrom_ThrowsException_WhenArrayIsEmpty()
        {
            // Arrange
            double[] scores = Array.Empty<double>();

            // Act & Assert
            Assert.Throws<ArgumentException>(
                () => GradeManager.GetHighestScoreFrom(scores));
        }

        [Fact]
        public void GetLowestScoreFrom_ThrowsException_WhenArrayIsEmpty()
        {
            // Arrange
            double[] scores = Array.Empty<double>();

            // Act & Assert
            Assert.Throws<ArgumentException>(
                () => GradeManager.GetLowestScoreFrom(scores));
        }
    }
}