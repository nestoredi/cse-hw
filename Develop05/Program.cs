using System;
using System.Collections.Generic;

   class Program
{
    static void Main(string[] args)
{
     List<Goal> _goals = new List<Goal>():
     //Welcome banner
        Console.WriteLine("Welcome to Your Goal planner!");
    
        while (true) {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Create new Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Record Quit");

            //Requests user selection for action to take
            Console.Write("Please select an option (1-5) ");
            string choice = Console.ReadLine();

            //Calls class methods per user selection
            switch (choice) {
                //Adds new Goal
                case "1":
                goals.CreateGoal();

                
                break;

                //List Goal
                case "2":
                goals.ListGoalNames();
                goals.ListGoalDetails();
                
                break;

                //Save Goals to Goal.txt
                case "3":
                goals.SaveGoals();
                
                break;

                //Load Goals
                case "4":
                goals.LoadGoals();
                
                break;
               
                //Saves entries to a file
                case "5":
                goals.RecordEvent();
                
                break;

                //Exits program
                case "6":
                Console.WriteLine("Goodbye!");
                return;

                //Handles invalid input
                default:
                Console.WriteLine("Invalid selection, please enter a number 1-5.");
                break;
            }
        }
}
}