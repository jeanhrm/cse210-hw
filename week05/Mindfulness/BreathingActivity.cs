using System;

public class BreathingActivity : Activity
{
    public BreathingActivity()
        : base(
            "Breathing",
            "This activity will help you relax by guiding you through slow breathing. Clear your mind and focus on your breath.")
    {
    }

    public override void Run()
    {
        StartActivity();

        int duration = GetDuration();
        DateTime endTime = DateTime.Now.AddSeconds(duration);
        bool breatheIn = true;

        while (DateTime.Now < endTime)
        {
            if (breatheIn)
            {
                Console.Write("\nBreathe in... ");
            }
            else
            {
                Console.Write("\nBreathe out... ");
            }

            ShowCountdown(4);
            breatheIn = !breatheIn;
        }

        EndActivity();
    }
}
