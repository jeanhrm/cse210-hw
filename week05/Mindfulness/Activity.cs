using System;
using System.Threading;

public abstract class Activity
{
    // --- ENCAPSULATION ---
    private string _name;
    private string _description;
    private int _duration;

    // --- Constructor ---
    protected Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    protected int GetDuration()
    {
        return _duration;
    }

    protected string GetName()
    {
        return _name;
    }

    // --- INHERITING BEHAVIORS ---

    protected void StartActivity()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name} activity.\n");
        Console.WriteLine(_description);
        Console.Write("\nHow long, in seconds, would you like your session to last? ");

        while (true)
        {
            string input = Console.ReadLine();
            if (int.TryParse(input, out _duration) && _duration > 0)
            {
                break;
            }
            Console.Write("Please enter a valid positive number of seconds: ");
        }

        Console.WriteLine("\nGet ready...");
        ShowSpinner(3);
        Console.Clear();
    }

    protected void EndActivity()
    {
        Console.WriteLine();
        Console.WriteLine("Well done! You completed the activity. ");
        ShowSpinner(3);

        Console.WriteLine($"\nYou have completed {_duration} seconds of the {_name} activity.");
        ShowSpinner(3);
    }

    protected void ShowSpinner(int seconds)
    {
        char[] spinner = { '|', '/', '-', '\\' };
        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        int index = 0;

        while (DateTime.Now < endTime)
        {
            Console.Write(spinner[index]);
            Thread.Sleep(150);
            Console.Write("\b"); // backspace
            index = (index + 1) % spinner.Length;
        }
    }
    protected void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b"); 
        }
        Console.WriteLine();
    }

    public abstract void Run();
}
