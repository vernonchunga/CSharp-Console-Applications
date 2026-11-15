using System;

namespace GuessingGame
{
    public class Game
    {
        private readonly Random _random;

        public const int MaxAttempts = 5;

        public Game()
        {
            _random = new Random();
        }

        public int GenerateSecretNumber()
        {
            return _random.Next(1, 101);
        }

        public string GetHint(int guess, int secretNumber)
        {
            if (guess < secretNumber)
            {
                return "Too low! Try a higher number.";
            }

            if (guess > secretNumber)
            {
                return "Too high! Try a lower number.";
            }

            return "Congratulations! You guessed correctly.";
        }

        public void Play()
        {
            int secretNumber = GenerateSecretNumber();
            int attempts = 0;
            bool guessedCorrectly = false;

            Console.WriteLine("\n===== NUMBER GUESSING GAME =====");
            Console.WriteLine("I have selected a number between 1 and 100.");
            Console.WriteLine($"You have {MaxAttempts} attempts to guess it.");

            while (attempts < MaxAttempts && !guessedCorrectly)
            {
                Console.Write("\nEnter your guess: ");

                string input = Console.ReadLine() ?? "";

                if (!int.TryParse(input, out int guess))
                {
                    Console.WriteLine("Invalid input. Please enter a whole number.");
                    continue;
                }

                if (guess < 1 || guess > 100)
                {
                    Console.WriteLine("Your guess must be between 1 and 100.");
                    continue;
                }

                attempts++;

                string hint = GetHint(guess, secretNumber);

                Console.WriteLine(hint);

                if (guess == secretNumber)
                {
                    guessedCorrectly = true;
                    Console.WriteLine($"You guessed it in {attempts} attempt(s)!");
                }
                else
                {
                    Console.WriteLine($"Attempts remaining: {MaxAttempts - attempts}");
                }
            }

            if (!guessedCorrectly)
            {
                Console.WriteLine($"\nGame over! The correct number was {secretNumber}.");
            }
        }
    }
}