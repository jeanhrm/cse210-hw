using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        activities.Add(new Running(new DateTime(2025, 12, 3), 30, 3.0));   // 3 km
        activities.Add(new Cycling(new DateTime(2022, 12, 3), 30, 20.0)); // 20 kph
        activities.Add(new Swimming(new DateTime(2022, 12, 3), 30, 20));  // 20 largos

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
