using System;

namespace NumberGuessGame
{
    internal class Program
    {
        static Random randomNum = new Random();   //Random number
        static int maxAttempts = 3;               //Max possible attempts                        

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Number Guessing Game!");

            StartNewGame();              //Play one time always
            while (PlayAgain())          //Until User wants to stop playing begin new game
                StartNewGame();

            Console.WriteLine("Thanks for playing!");
        }

        static void StartNewGame()
        {
            int randomNumber = randomNum.Next(1, 100); // Generates a random number between 1 and 100

            Console.WriteLine("\nGuess a number between 1 to 100. You have a total of 3 attempts.");

            for (int i = maxAttempts; i > 0; i--)
            {
                Console.WriteLine($"\nEnter your guess. You have {i} attempts remaining");

                Int32.TryParse(Console.ReadLine(), out int userNumber);

                if (userNumber == randomNumber)
                {
                    Console.WriteLine($"\nCongratulations! You guessed the number in {maxAttempts - i + 1} attempts.");
                    return; 
                }
                else if (userNumber > randomNumber)
                {
                    Console.WriteLine("Your guess is too high.");
                }
                else if (userNumber < randomNumber)
                {
                    Console.WriteLine("Your guess is too low.");
                }
            }

            Console.WriteLine($"\nYou have failed to guess the number. The correct number was {randomNumber}.");
        }

        static bool PlayAgain()
        {
            Console.WriteLine("\nDo you want to play again? (Yes/No)");
            string playChoice = Console.ReadLine();

            if (playChoice.ToLower() == "yes")
                return true;
            return false;
        }
    }
}
