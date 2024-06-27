using System;
using System.IO;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
class Program
{
    static void Main(string[] args)
{
        //Creates a new instance of Journal
        Entry _entries = new Entry();
        Journal journal = new Journal();
        
        

        //Welcome banner
        Console.WriteLine("Welcome to Your Daily Journal!");
    
        while (true) {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Add Entry");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");

            //Requests user selection for action to take
            Console.Write("Please select an option (1-5) ");
            string choice = Console.ReadLine();

            //Calls class methods per user selection
            switch (choice) {
                //Adds new entry
                case "1":
                journal.AddEntry();
                //entry.Display();
                

                break;

                // //Displays added entries
                 case "2":
                 journal.DisplayAll();
                 break;

                 //Loads entries from a file
                 case "3":
                 journal.LoadFromFile( );
                 break;

                //Saves entries to a file
                 case "4":
                 journal.SaveToFile();
                 break;

                //Exits program
                case "5":
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
