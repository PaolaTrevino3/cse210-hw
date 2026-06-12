using System;

/// Creativity:
/// -Added extra prose in the reflecting and listening activities.
/// -added a peaceful motivational message when user quit the program.
/// -used both spinner and countdown animation with backspaces.

class Program
{
    static void Main(string[] args)
    {
       int choice = 0;

       while (choice != 4)
        {
            Console.Clear();
            Console.WriteLine("Menu Options.");
            Console.WriteLine(" 1. Start breathing activity");
            Console.WriteLine(" 2. Start reflecting activity");
            Console.WriteLine(" 3. Start listing activity.");
            Console.WriteLine(" 4. Quit");
            Console.Write("Select a choice from the menu: ");

            choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                BreathingActivity breathingActivity = new BreathingActivity();
                breathingActivity.Run();
            }
            else if (choice == 2)
            {
                ReflectingActivity reflectingActivity = new ReflectingActivity();
                reflectingActivity.Run();
            }
            else if (choice == 3)
            {
                ListingActivity listingActivity = new ListingActivity();
                listingActivity.Run();
            }
            else if (choice == 4)
            {
                Console.WriteLine("Take a deep breath. You did something good for yourself today.");
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
                Thread.Sleep(2000);
            }
        }
    }
}