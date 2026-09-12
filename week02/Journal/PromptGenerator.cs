using System;
using System.Collections.Generic;

class PromptGenerator
{
    private List<string> _prompts = new List<string>
    {
        "What was the best part of my day?",
        "What did I learn today?",
        "Who made me smile today?",
        "What was something difficult I experienced today?",
        "What am I grateful for today?",
        "What is one thing I would like to improve tomorrow?"
    };

    private Random _random = new Random();

    public string GetRandomPrompt()
    {
        int index = _random.Next(_prompts.Count);
        return _prompts[index];
    }
}