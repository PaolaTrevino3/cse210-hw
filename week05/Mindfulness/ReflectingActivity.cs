using System;

public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    public ReflectingActivity()
      : base("Reflecting Activity", "This activity will help you reflect on times when you have shown strength and resilience.")
    {
      _prompts = new List<string>
      {
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you showed courage.",
        "Think of a time when you learned from a mistake."
      };

      _questions = new List<string>
      {
        "Why was this experience meaningful to you?",
        "What did you learn about yourself?",
        "How did you feel when it was complete?",
        "How can you use this experience in the future?",
        "What strength did you show during this moment?"
      };
    }

    public void Run()
    {
    DisplayStartingMessage();

    Console.WriteLine();
    Console.WriteLine("Consider the following prompt:");
    Console.WriteLine();
    Console.WriteLine($"--- {GetRandomPrompt()} ---");
    Console.WriteLine();
    Console.WriteLine(" When you have something in mind, press enter to continue");
    Console.ReadLine();

    Console.WriteLine("Now ponder on each of the following questions as they relate to this experience");
    Console.Write(" You might begin in: ");
    ShowCountDown(5);
    Console.Clear();

    DateTime endTime = DateTime.Now.AddSeconds(_duration);

    while (DateTime.Now <endTime)
        {
            Console.WriteLine(GetRandomQuestion());
            ShowSpinner(6);
            Console.WriteLine();
        }
        DisplayEndingMessage();
    }

    private string GetRandomPrompt ()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }

    private string GetRandomQuestion()
    {
        Random random = new Random();
        int index = random.Next(_questions.Count);
        return _questions[index];
    }

}