using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        bool appending = true;
        List<int> numbers = new List<int>();

        while (appending == true) {
            Console.WriteLine("Enter number: ");
            string userInput = Console.ReadLine();
            int userInputAsInt = int.Parse(userInput);
            if (userInputAsInt == 0) {
                appending = false;
            } else {
                numbers.Add(userInputAsInt);
            }
        }

        // declare and find the sum of the items in the list
        int sum = 0;
        foreach (int num in numbers) {
            sum += num;
        }

        // declare and find the avg of the items in the list
        float avg = ((float)sum) / numbers.Count;

        // declare and find the largest number (max) of the items in the list
        int max = numbers[0];
        foreach (int num in numbers) {
            if (max < num) {
                max = num;
            }
        }

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {avg}");
        Console.WriteLine($"The largest number is: {max}");
        
    }
}