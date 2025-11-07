using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string answer = Console.ReadLine();
        int percent = int.Parse(answer);
        string l = "";

        if (percent >= 90)
        {
            l = "A";
        }
        else if (percent >= 80)
        {
            l = "B";
        }
        else if (percent >= 70)
        {
            l = "C";
        }
        else if (percent >= 60)
        {
            l = "D";
        }
        else
        {
            l = "F";
        }

        Console.WriteLine($"Your grade is: {l}");
        
        if (percent >= 70)
        {
            Console.WriteLine("Congrats!");
        }
        else
        {
            Console.WriteLine("It's moment to study!");
        }
    }
}