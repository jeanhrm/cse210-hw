using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("Alma", 37, 37);

        string text = "Counsel with the Lord in all thy doings, and he will direct thee for good; yea, when thou liest down at night lie down unto the Lord, " +
                      "that he may watch over you in your sleep; and when thou risest in the morning let thy heart be full of thanks unto God; " +
                      "and if ye do these things, ye shall be lifted up at the last day.";

        Scripture scripture = new Scripture(reference, text);

        // Extra: The program hides only words that are still visible, avoiding choosing already hidden words.

        while (true)
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();
            Console.Write("Press Enter to hide more words or type 'quit' to finish: ");

            string input = Console.ReadLine();

            if (input != null && input.Trim().ToLower() == "quit")
            {
                break;
            }

            scripture.HideRandomWords(3); // hide 3 words at a time

            if (scripture.IsCompletelyHidden())
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine(scripture.GetDisplayText());
                Console.WriteLine();
                Console.WriteLine("All words are now hidden. Great job!");
                Console.WriteLine("Press Enter to exit.");
                Console.ReadLine();
                break;
            }
        }
    }
}