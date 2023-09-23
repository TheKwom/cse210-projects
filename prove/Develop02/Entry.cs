using System;

public class Entry {
    private List<string> questions;
    
    public string _entry = "";
    public Entry() {
        questions = new List<string> {
            "What happened that made you smile today?",
            "What was something you daydreamed about today?",
            "What are some new goals you set today?",
            "Explain something new that you learned today or that you would like to learn?",
            "Who was the person you thought about most today? Why?"
        };
    }

    public string GetQuestion() {
        Random rnd = new Random();
        int randomIndex = rnd.Next(questions.Count);
        string question = questions[randomIndex];
        return question;
    }

}