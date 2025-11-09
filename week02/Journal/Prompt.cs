using System;
using System.Collections.Generic;

namespace JournalProgram
{
    public class Prompt
    {
        private readonly List<string> _prompts;
        private readonly Random _random;

        public Prompt()
        {
            _random = new Random();

            _prompts = new List<string>
            {
                "Who was the most interesting person I interacted with today?",
                "What was the best part of my day?",
                "What did I learn today?",
                "How did I see the hand of the Lord in my life today?",
                "If I could do one thing over today, what would it be?",
                "What am I grateful for today?",
            };
        }

        public string GetRandomPrompt()
        {
            int index = _random.Next(_prompts.Count);
            return _prompts[index];
        }

        public void AddPrompt(string prompt)
        {
            if (!string.IsNullOrWhiteSpace(prompt))
            {
                _prompts.Add(prompt.Trim());
            }
        }
    }
}
