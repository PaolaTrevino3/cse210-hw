using System;
using System.Collections.Generic;

public class PromptGenerator
{
    public List<string> _prompts = new List<string>
    {
        "who was the most interesting person I interacted with today?",
        "what was the best part of my day?",
        "how did I see the head of the Lord in my life today?",
        "what was the strongest emotion I felt today?",
        "if I had one thing I could do over today, what would it be?",
        "what challenge help me grow today?",
        "what is one thing I learned today?"
    };

    public string GetRandomPrompt()
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(_prompts.Count);
        return _prompts[number];
    }
}