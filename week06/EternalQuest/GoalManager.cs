using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;

    public void Start()
    {
        int choice = 0;

        while (choice != 6)
        {
            Console.WriteLine($"\nYour Current Score: {_score}\n");

            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");

            Console.Write("Select a choice: ");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    CreateGoal();
                    break;
                case 2:
                    ListGoalDetails();
                    break;
                case 3:
                    SaveGoals();
                    break;
                case 4:
                    LoadGoals();
                    break;
                case 5:
                    RecordEvent();
                    break;
            }
        }
    }

    private void CreateGoal()
    {
        Console.WriteLine("\nTypes of Goals:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");

        Console.Write("Which type? ");
        int type = int.Parse(Console.ReadLine());

        Console.Write("Short Name: ");
        string name = Console.ReadLine();

        Console.Write("Description: ");
        string desc = Console.ReadLine();

        Console.Write("Points: ");
        int pts = int.Parse(Console.ReadLine());

        if (type == 1)
        {
            _goals.Add(new SimpleGoal(name, desc, pts));
        }
        else if (type == 2)
        {
            _goals.Add(new EternalGoal(name, desc, pts));
        }
        else if (type == 3)
        {
            Console.Write("How many times to complete? ");
            int target = int.Parse(Console.ReadLine());

            Console.Write("Bonus Points: ");
            int bonus = int.Parse(Console.ReadLine());

            _goals.Add(new ChecklistGoal(name, desc, pts, target, bonus));
        }
    }

    private void ListGoalDetails()
    {
        Console.WriteLine("\nYour Goals:");
        foreach (Goal g in _goals)
        {
            Console.WriteLine(g.GetDetailsString());
        }
    }

    private void SaveGoals()
    {
        using (StreamWriter output = new StreamWriter("goals.txt"))
        {
            output.WriteLine(_score);
            foreach (Goal g in _goals)
            {
                output.WriteLine(g.GetStringRepresentation());
            }
        }
        Console.WriteLine("Goals saved.");
    }

    private void LoadGoals()
    {
        _goals.Clear();

        string[] lines = File.ReadAllLines("goals.txt");
        _score = int.Parse(lines[0]);

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split("|");

            string type = parts[0];
            string name = parts[1];
            int points = int.Parse(parts[2]);

            if (type == "SimpleGoal")
            {
                bool complete = bool.Parse(parts[3]);
                var sg = new SimpleGoal(name, "description", points);

                if (complete)
                    sg.RecordEvent();

                _goals.Add(sg);
            }
            else if (type == "EternalGoal")
            {
                int recorded = int.Parse(parts[3]);
                var eg = new EternalGoal(name, "description", points);

                for (int r = 0; r < recorded; r++)
                    eg.RecordEvent();

                _goals.Add(eg);
            }

            else if (type == "ChecklistGoal")
            {
                int amount = int.Parse(parts[3]);
                int target = int.Parse(parts[4]);
                int bonus = int.Parse(parts[5]);

                var cg = new ChecklistGoal(name, "description", points, target, bonus);

                for (int c = 0; c < amount; c++)
                    cg.RecordEvent();

                _goals.Add(cg);
            }
        }

        Console.WriteLine("Goals loaded.");
    }

    private void RecordEvent()
    {
        Console.WriteLine("\nWhich goal did you complete?");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetShortName()}");
        }

        int index = int.Parse(Console.ReadLine()) - 1;

        Goal goal = _goals[index];

        goal.RecordEvent();

        int points = goal.GetPoints();

        if (goal is ChecklistGoal cg)
        {
            if (cg.IsComplete())
                points += cg.GetBonus();
        }

        _score += points;

        Console.WriteLine($"You earned {points} points!");
    }
}
