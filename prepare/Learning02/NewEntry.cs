using System;
using System.Collections.Generic;

public class NewEntry {
    private List<string> questions;
    public string _entry = "";
    public NewEntry() {
        questions = new List<string> {
            "What happened that made you smile today?",
            "What was something you daydreamed about today?",
            "What are some new goals you set today?",
            "Explain something new that you learned today or that you would like to learn?",
            "Who was the person you thought about most today?"
        };
    }

    public string GetRandomQuestion() {
        Random rnd = new Random();
        int randomIndex = rnd.Next(questions.Count);
        return questions[randomIndex];
    }

}