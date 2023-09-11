using System;

class Program
{
    static void Main(string[] args)
    {
        Random rnd = new Random();
        int magicNum = rnd.Next(1, 100);

        bool correct = false;

        while (correct == false) {
            Console.WriteLine("What is your guess? ");
            string userGuess = Console.ReadLine();
            int userGuessAsInt = int.Parse(userGuess);
            if (userGuessAsInt < magicNum) {
                Console.WriteLine("Higher");
            } else if (userGuessAsInt > magicNum) {
                Console.WriteLine("Lower");
            } else {
                correct = true;
                }
        }

        Console.WriteLine("You guesses it!");

    }
}