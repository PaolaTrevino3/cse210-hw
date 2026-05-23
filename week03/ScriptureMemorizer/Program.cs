
using System.ComponentModel;


/// Creativity:
/// -the program randomly hides three words at a time.
/// -added multiple scripture options
/// -a random scripture is selected each time the program runs.
/// -add a motivational ending message when all the words are hidden. Diarrhea
class Program
{
    static void Main(string[] args)
    {
       List<Scripture> scriptures = new List<Scripture>()
       
       Reference reference1 = new Reference("Proverbs", 3, 5, 6);
       Scripture scripture1 = new Scripture(reference1, "Trust in the Lord with all thine heart and lean not unto thine own understanding.");

       Reference reference2 = new Reference("John", 14, 6);
       Scripture scripture2 = new Scripture(reference2, " Jesus saith unto him I am the way the truth and the life.");

       Reference reference3 = new Reference("Philippians", 4, 13);
       Scripture scripture3 = new Scripture(reference3, "I can do all things through Christ which strengtheneth me.");

       scriptures.Add(scripture1);
       scriptures.Add(scripture2);
       scriptures.Add(scripture3);

       Random random = new Random();
       Scripture selectedScripture = scriptures[random.Next(scriptures.Count)];

       while (!selectedScripture.IsCompletelyHidden())
       {
           Console.Clear();
           Console.WriteLine(selectedScripture.GetDisplayText());
           Console.WriteLine()
           Console.Write("Press Enter to hide words or type 'quit' to finish: ");
           
           string input = Console.ReadLine();
           
           if (input.ToLower() == "quit")
           {
               break;
           }
           
           selectedScripture.HideRandomWords(3);
       }
       
       Console.Clear();
       Console.WriteLine(selectedScripture.GetDisplayText());
       Console.WriteLine();
       Console.WriteLine("Great job! The scripture is completely hidden.");
    }   
}