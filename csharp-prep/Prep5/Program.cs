using System;

class Program
{
    static void Main(string[] args)
    {

        // DisplayWelcome();
        // DisplayResult(PromptUserName(), SquareNumber(PromptUserNumber()));

        DisplayWelcome();

        string userName = PromptUserName();
        int userNumber = PromptUserNumber();

        int squareNumber = SquareNumber(userNumber);

        DisplayResult(userName, squareNumber);

        static void DisplayWelcome() {
            Console.WriteLine("Welcome to the Program!");
        }

        static string PromptUserName() {
            Console.WriteLine("Please enter your name: ");
            string username = Console.ReadLine();
            return username;
        }

        static int PromptUserNumber() {
            Console.WriteLine("Please enter your favorite number: ");
            string userNumber = Console.ReadLine();
            int userNumberAsInt = int.Parse(userNumber);
            return userNumberAsInt;
        }

        static int SquareNumber(int userNumber) {
            int squaredUserNumber = userNumber * userNumber;
            return squaredUserNumber;
        }

        static void DisplayResult(string userName, int squaredUserNumber) {
            Console.WriteLine($"{userName}, the square of your number is {squaredUserNumber}");
        }
    }
}