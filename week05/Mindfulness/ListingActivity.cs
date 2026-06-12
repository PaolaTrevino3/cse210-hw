using System;

public class ListingActivity : Activity
{
    private List<String> _prompts;

    public ListingActivity()
    : base("Listing Activity", "This activity will help you reflect on the goo things in your life by listing as many things as you can.")
    {
       _prompts = new List<string>
       {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt peace recently?",
        "What are things you are grateful for today?"  
       };
    }

    public void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine();
        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine();
        Console.WriteLine($"--- {GetRandomPrompt()} ---");
        Console.WriteLine();
        Console.WriteLine("Ypu may begin in: ");
        ShowCountDown(5);
        Console.WriteLine();

        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        List<string> responses = new List<string>();

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string response = Console.ReadLine();
            responses.Add(response);
        }

        Console.WriteLine();
        Console.WriteLine($"You listed {responses.Count} items.");

        DisplayEndingMessage();
    }

    private string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
}