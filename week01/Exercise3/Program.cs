using System;

string playAgain = "yes";

while (playAgain == "yes")
{
    Random generator = new Random();
    int magicNumber = generator.Next(1, 101);

    int guess = -1;
    int guessCount = 0;
    Console.WriteLine("Welcome to the Magic Number Game!, i have chosen a number between 1 and 100, can you guess it?");

    while (guess != magicNumber)
    {
        Console.WriteLine("Enter your guess:");
        guess = int.Parse(Console.ReadLine());
        guessCount++;

        if (guess < magicNumber)
        {
            Console.WriteLine("Too low! higher!");
        }
        else if (guess > magicNumber)
        {
            Console.WriteLine("Too high! lower!");
        }
        else
        {
            Console.WriteLine($"Congratulations! You've guessed the magic number {magicNumber} in {guessCount} guesses!");
        }

        Console.WriteLine("Do you want to play again? (yes/no)");
        playAgain = Console.ReadLine().ToLower();

        Console.WriteLine();
    }
}