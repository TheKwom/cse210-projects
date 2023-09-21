using System;
using System.Collections.Generic;
public class Menu {
    private List<string> options;

    public Menu() {
        options = new List<string> {
        "1. Write",
        "2. Display",
        "3. Load",
        "4. Save",
        "5. Quit"
        };
    }

    public void DisplayMenu() {
    while (true) {
        Console.WriteLine("What woul you like to do?");
        foreach (string option in options) {
            Console.WriteLine(option);
        }

        string input = Console.ReadLine();

        if (int.TryParse(input, out int choice)) {
            if (choice >= 1 && choice <= 5) {
                HandleCHoice(choice);
            }
            else {
                Console.WriteLine("Please enter a number between 1 and 5.");
            }
        }
        else {
            Console.WriteLine("Please enter a number between 1 and 5.");
        }
    }
    }

    private void HandleCHoice(int choice) {
        switch (choice) {
            case 1:
                Console.WriteLine("You chose: Write");
                 // Add your code for the "Write" option here
                break;
            case 2:
                Console.WriteLine("You chose: Display");
                // Add your code for the "Display" option here
                break;
            case 3:
                Console.WriteLine("You chose: Load");
                // Add your code for the "Load" option here
                break;
            case 4:
                Console.WriteLine("You chose: Save");
                // Add your code for the "Save" option here
                break;
            case 5:
                Console.WriteLine("You chose: Quit");
                // Add your code for the "Quit" option here
                return; // Exit the program
                }
    }
}