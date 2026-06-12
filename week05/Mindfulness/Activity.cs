using System;

public class Activity
{
    private string _name;
    private string _description;
    protected int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
        _duration = 0;
    }

    public void DisplayStartingMessage()

    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}.");
        Console.WriteLine();
        Console.Write("How long, in seconds, Will you like for your session??");
        _duration = int.Parse(Console.ReadLine());

        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(3);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine();
        Console.WriteLine($"Well done!");
        ShowSpinner(3);
        Console.WriteLine();
        Console.WriteLine($" you have completed another {_duration} seconds of the {_name}.");
        ShowSpinner(3);
    }

    public void ShowSpinner (int seconds)
    {
        List<string> animations = new List<string>();
        animations.Add("|");
        animations.Add("/");
        animations.Add("-");
        animations.Add("\\");

        DateTime endTime = DateTime.Now.AddSeconds(seconds);

        int i = 0;

        while (DateTime.Now < endTime)
        {
            string s = animations[i];
            Console.Write(s);
            Thread.Sleep(250);
            Console.Write("\b \b");

            i++;

            if (i >= animations.Count)
            {
                i = 0;
            }
        }
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}

