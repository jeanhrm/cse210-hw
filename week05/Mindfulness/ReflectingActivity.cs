using System;
using System.Collections.Generic;

public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    public ReflectingActivity()
        : base(
            "Reflecting",
            "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other situations.")
    {
        _prompts = new List<string>
        {
            "Think of a time when you helped someone who was struggling.",
            "Think of a time when you overcame a difficult challenge.",
            "Think of a moment when you felt guided or inspired.",
            "Think of a time when you learned something important about yourself."
        };

        _questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "What did you learn about yourself from this experience?",
            "How can you apply what you learned to future situations?",
            "What emotions did you feel during this experience?",
            "How did this experience change your view of others?"
        };
    }

    private string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }

    private string GetRandomQuestion()
    {
        Random random = new Random();
        int index = random.Next(_questions.Count);
        return _questions[index];
    }

    public override void Run()
    {
        StartActivity();

        Console.WriteLine("\nConsider the following prompt:");
        Console.WriteLine($" --- {GetRandomPrompt()} ---");
        Console.WriteLine("\nWhen you have something in mind, press Enter to continue.");
        Console.ReadLine();

        Console.WriteLine("Now ponder on each of the following questions:");
        Console.WriteLine("You may take your time; focus on your feelings and thoughts.\n");

        int duration = GetDuration();
        DateTime endTime = DateTime.Now.AddSeconds(duration);

        while (DateTime.Now < endTime)
        {
            string question = GetRandomQuestion();
            Console.WriteLine($"> {question}");
            ShowSpinner(8); 
            Console.WriteLine();
        }

        EndActivity();
    }
}
