using System;
using System.IO; 
public class Menu {
    private List<string> options;
    private List<string> answers;
    DateTime currentTime = DateTime.Now;
    string entries = "entries.txt";
    


    public Menu() {
        options = new List<string> {
        "1. Write",
        "2. Display",
        "3. Load",
        "4. Save",
        "5. Quit"
        };
        answers = new List<string> {

        };
    }

    public void DisplayMenu() {
    while (true) {
        Console.WriteLine("What would you like to do?");
        foreach (string option in options) {
            Console.WriteLine(option);
        }

        string input = Console.ReadLine();

        if (int.TryParse(input, out int choice)) {
            if (choice >= 1 && choice <= 5) {
                HandleChoice(choice);
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

    private void HandleChoice(int choice) {
        switch (choice) {
            case 1:
                Entry newEntry = new Entry();
                string question = newEntry.GetQuestion();
                Console.WriteLine(question);
                string answer = Console.ReadLine();
                answers.Add($"{currentTime}: - Prompt: {question} {answer}");
                break;
            case 2:
                foreach (string entry in answers) {
                    Console.WriteLine(entry);
                }
                break;
            case 3:
                string[] lines = System.IO.File.ReadAllLines(entries);
                foreach (string line in lines) {
                    Console.WriteLine(line);
                }
                break;
            case 4:
                using (StreamWriter outputFile = new StreamWriter(entries)) {
                    foreach (String entry in answers) {
                        outputFile.WriteLine(entry);
                    }
                }
                break;
            case 5:
                Environment.Exit(0);
                return;
                }
    }
}