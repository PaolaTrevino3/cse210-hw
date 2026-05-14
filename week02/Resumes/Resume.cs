using System;
using System.Collections.Generic;

public class Resume
{
    public string _Name = "";
    public List<Job> _Jobs = new List<Job>();

    public void Display()
    {
        Console.WriteLine($"Name: {_Name}");
        Console.WriteLine("Jobs:");

        foreach (Job job in _Jobs)
        {
            job.Display();
        }
    }
}