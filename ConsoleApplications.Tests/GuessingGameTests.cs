using GuessingGame;

namespace ConsoleApplications.Tests
{
    public class GuessingGameTests
    {
        private readonly Game _game = new Game();

        [Fact]
        public void GetHint_ReturnsTooLow_WhenGuessIsLower()
        {
            // Arrange
            int guess = 20;
            int secretNumber = 50;

            // Act
            string result = _game.GetHint(guess, secretNumber);

            // Assert
            Assert.Equal("Too low! Try a higher number.", result);
        }

        [Fact]
        public void GetHint_ReturnsTooHigh_WhenGuessIsHigher()
        {
            // Arrange
            int guess = 80;
            int secretNumber = 50;

            // Act
            string result = _game.GetHint(guess, secretNumber);

            // Assert
            Assert.Equal("Too high! Try a lower number.", result);
        }

        [Fact]
        public void GetHint_ReturnsCongratulations_WhenGuessIsCorrect()
        {
            // Arrange
            int guess = 50;
            int secretNumber = 50;

            // Act
            string result = _game.GetHint(guess, secretNumber);

            // Assert
            Assert.Equal("Congratulations! You guessed correctly.", result);
        }

        [Fact]
        public void GenerateSecretNumber_ReturnsNumberWithinValidRange()
        {
            // Act
            int result = _game.GenerateSecretNumber();

            // Assert
            Assert.InRange(result, 1, 100);
        }
    }
}