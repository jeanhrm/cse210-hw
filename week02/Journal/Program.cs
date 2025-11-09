using System;

namespace JournalProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            var journal = new Journal();
            var prompts = new Prompt();

            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("\n--- Journal Menu ---");
                Console.WriteLine("1. Write a new entry");
                Console.WriteLine("2. Display journal entries");
                Console.WriteLine("3. Save journal to file");
                Console.WriteLine("4. Load journal from file");
                Console.WriteLine("5. Add a new prompt (optional)");
                Console.WriteLine("6. Quit");
                Console.Write("Choose an option (1-6): ");

                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        string prompt = prompts.GetRandomPrompt();
                        Console.WriteLine($"\nPrompt: {prompt}");
                        Console.Write("Your response: ");
                        string response = Console.ReadLine();
                        string date = DateTime.Now.ToShortDateString();

                        journal.AddEntry(new Entry(date, prompt, response));
                        Console.WriteLine("Entry added.");
                        break;

                    case "2":
                        journal.DisplayEntries();
                        break;

                    case "3":
                        Console.Write("Enter filename to save (ex: journal.txt): ");
                        string saveFile = Console.ReadLine();
                        journal.SaveToFile(saveFile);
                        break;

                    case "4":
                        Console.Write("Enter filename to load (ex: journal.txt): ");
                        string loadFile = Console.ReadLine();
                        journal.LoadFromFile(loadFile);
                        break;

                    case "5":
                        Console.Write("Write a new prompt to add: ");
                        string newPrompt = Console.ReadLine();
                        prompts.AddPrompt(newPrompt);
                        Console.WriteLine("Prompt added.");
                        break;

                    case "6":
                        exit = true;
                        break;

                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }

            Console.WriteLine("Goodbye! Have a great day.");
        }
    }
}
