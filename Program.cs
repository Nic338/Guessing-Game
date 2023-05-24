// See https://aka.ms/new-console-template for more information
using System;

Main();

void Main()
{
    GuessingGameMain();
}

static void GuessingGameMain()
{
    Console.WriteLine("Choose a Difficulty");
    Console.WriteLine();
    Console.WriteLine("(1): Easy  (2): Medium  (3): Hard  (4): CHEATER MODE");
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("Welcome to the Guessing Game");

    int attemptCount = 4;
    string userDifficulty;

    userDifficulty = Console.ReadLine().ToLower();

    int parsedDifficulty;
    bool checkDifficulty = int.TryParse(userDifficulty, out parsedDifficulty);

    if (checkDifficulty && parsedDifficulty > 0 && parsedDifficulty < 5)
    {
        attemptCount =
        parsedDifficulty == 1 ? 8 : (parsedDifficulty == 2 ? 6 : (parsedDifficulty == 3 ? 4 : int.MaxValue));
    }

        int secretNumber = new Random().Next(1, 100);

    while (attemptCount > 0)
    {
        Console.WriteLine("Guess the Number");
        Console.WriteLine("(Between 1 and 100)");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write($"Your Guess: ");


        string userInput = Console.ReadLine();

        int parsedInput = int.Parse(userInput);
        Console.WriteLine();

        if (secretNumber == parsedInput)
        {
            Console.WriteLine("WOW YOU GUESSED THE SECRET NUMBER");
            break;
        }
        else
        {
            Console.WriteLine("WRONG");
            Console.WriteLine();
            attemptCount--;
            if (parsedInput > secretNumber)
            {
                Console.WriteLine("Sorry, Guess Lower...");
            }
            if (parsedInput < secretNumber)
            {
                Console.WriteLine("Sorry, Guess Higher...");
            }
            Console.WriteLine();
            Console.WriteLine($"YOU HAVE {attemptCount} GUESSES REMAINING");
        }
        if (attemptCount == 0)
        {
            Console.WriteLine();
            Console.WriteLine("Geez You're Bad at This");
        }
    }
}

