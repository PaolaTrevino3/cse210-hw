using System;

/// Creativity
/// - added labeling system based on the users score.
/// -the program displays the users current label in the menu.
/// -added encouraging messages when goals are recorded.
class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        manager.Start();
    }
}