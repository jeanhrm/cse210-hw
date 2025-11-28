using System;

class Program
{
    /*
     * EXTRA CREDIT / CREATIVITY (explained for the rubric):
     * ------------------------------------------------------
     * - Added additional polish to the user experience by including
     *   smoother transitions with spinners and countdown timers reused
     *   across multiple activities.
     * - The ListingActivity includes an expanded set of prompts,
     *   including an uplifting one related to gratitude and personal values,
     *   which enhances the variety of reflections the user can experience.
     * - Program.cs includes a clear and user-friendly console menu,
     *   allowing the user to navigate the mindfulness activities in
     *   a structured and intuitive way.
     * - General usability improvements: pauses, clear messages, and
     *   a guided flow that makes the program feel more polished
     *   than the minimum implementation.
     *
     * These enhancements go beyond the base requirements but do not
     * change the original functionality of the assignment...
     */

    static void Main(string[] args)
    {
        bool exit = false;

        while (!exit)
        {
            Console.Clear();
            Console.WriteLine("Mindfulness Program");
            Console.WriteLine("-------------------");
            Console.WriteLine("1. Start Breathing Activity");
            Console.WriteLine("2. Start Reflecting Activity");
            Console.WriteLine("3. Start Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("\nSelect a choice from the menu: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    BreathingActivity breathing = new BreathingActivity();
                    breathing.Run();
                    PauseBeforeMenu();
                    break;

                case "2":
                    ReflectingActivity reflecting = new ReflectingActivity();
                    reflecting.Run();
                    PauseBeforeMenu();
                    break;

                case "3":
                    ListingActivity listing = new ListingActivity();
                    listing.Run();
                    PauseBeforeMenu();
                    break;

                case "4":
                    Console.WriteLine("\nThank you for using the Mindfulness Program. Take care!");
                    exit = true;
                    break;

                default:
                    Console.WriteLine("\nPlease enter a valid option (1–4).");
                    PauseBeforeMenu();
                    break;
            }
        }
    }

    private static void PauseBeforeMenu()
    {
        Console.WriteLine("\nPress Enter to return to the menu...");
        Console.ReadLine();
    }
}
