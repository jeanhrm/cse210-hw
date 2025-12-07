using System;
// -------------------------------------------------------
// EXCEEDS CORE REQUIREMENTS
//
// 1. EternalGoal tracks how many times it has been recorded
//    using a _timesRecorded variable. The details string
//    shows "Times Recorded: N" for each eternal goal.
//
// 2. When saving and loading goals, the program also
//    preserves the number of times an EternalGoal has been
//    recorded, so progress is not lost between sessions.
//
// 3. The GoalManager class centralizes all the menu logic,
//    uses polymorphism with a List<Goal>, and keeps the
//    code in Program.cs very small and clean.
// -------------------------------------------------------
class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        manager.Start();
    }
}