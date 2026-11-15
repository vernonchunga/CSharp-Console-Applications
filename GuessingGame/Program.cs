using System;

namespace GuessingGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();

            bool playAgain = true;

            while (playAgain)
            {
                game.Play();

                Console.Write("\nWould you like to play again? (y/n): ");

                string response = Console.ReadLine() ?? "";

                playAgain = response.Trim().Equals(
                    "y",
                    StringComparison.OrdinalIgnoreCase
                );
            }

            Console.WriteLine("\nThank you for playing!");
        }
    }
}