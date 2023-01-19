using System;
using System.Collection.Generic;
using System.IO;
using System.Text;

public class PromptGenerator
{
    public string _promptQuestions;

    public string displayPrompt(){
        var _promptQuestions = new List<string>(){
            "What interesting thing did you do today?",
            "Who did you talk to today?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?"
        };

        Random randomQuestion = new Random();

        int indexQuestion = randomQuestion.Next(0, _promptQuestions.Count());

        return _promptQuestions[indexQuestion];
    }

}