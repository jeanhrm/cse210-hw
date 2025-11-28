using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private List<string> _prompts;

    public ListingActivity()
        : base(
            "Listing",
            "This activity will help you reflect on the good things in your life by listing as many items as you can in a given area.")
    {
  
        _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths you have?",
            "When have you felt peace this week?",
            "What beautiful things have you seen today?",
            "What opportunities has living in Huancavelica given you?"
        };
    }

    private string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }

    public override void Run()
    {
        StartActivity();

        string prompt = GetRandomPrompt();
        Console.WriteLine("\nConsider the following prompt:");
        Console.WriteLine($" --- {prompt} ---");
        Console.WriteLine("\nYou will have a moment to think, then start listing items.");
        Console.Write("Prepare your mind...");
        ShowSpinner(5);

        Console.WriteLine("\nStart listing items. Press Enter after each one.");
        Console.WriteLine("When time is up, you will see how many items you listed.\n");

        int duration = GetDuration();
        DateTime endTime = DateTime.Now.AddSeconds(duration);
        int count = 0;

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            if (Console.KeyAvailable)
            {
                Console.ReadKey(intercept: true);
            }

            string item = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(item))
            {
                count++;
            }
        }

        Console.WriteLine($"\nYou listed {count} items!");
        EndActivity();
    }
}
