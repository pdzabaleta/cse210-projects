using System;
// To my program, I gave the ability to provide the total score with option 1, load goals with option 2, and load detailed goals with option 3, as a creativity criterion.
class Program
{
    static void Main(string[] args)
    {
        
        GoalManager goalManager = new GoalManager();
        goalManager.ShowMenu();
    }
}