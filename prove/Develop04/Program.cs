using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        
        //Welcome banner
        Console.WriteLine("Welcome to Your Mindfullness program!");
    
        while (true) {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Start Breathing Activity");
            Console.WriteLine("2. Start Reflecting Activity");
            Console.WriteLine("3. Start listing Activity");
            Console.WriteLine("4. Quit");
            

            //Requests user selection for action to take
            Console.Write("Please select an option (1-4) ");
            string choice = Console.ReadLine();

            //Calls class methods per user selection
            switch (choice) {
                //Breathing act.
                case "1":
                Console.WriteLine("please enter your Activity time ") ;
                int duration = int.Parse(Console.ReadLine());
                string descrp = "Is your breathing moment"; 
                Activity activity = new Activity("Breathing",descrp,duration);
                activity.DisplayStartingMessage();
                //activity.ShowCountDown(duration);
                BreathingActivity b =new BreathingActivity("Breathing",descrp,duration);
                b.run(duration);
                activity.DisplayEndingMessage();

                break;

                //Reflecting act.
                case "2":
                Console.WriteLine("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
                ReflectingACtivity r = new ReflectingACtivity();
                r.DisplayPrompt();
                r.DisplayQuest();
                Console.WriteLine("please enter your Activity time ") ;
                string descrip = "Is your reflecting moment";
                int durat = int.Parse(Console.ReadLine()); 
                Activity a = new Activity("Breathing",descrip,durat);
                Console.WriteLine(descrip);
                a.Spinner(durat);
                
                
                
                break;

                //Listing act.
                case "3":
                Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
                ListingActivity l = new ListingActivity();
                string fra = l.GeneratorPrompt();
                Console.WriteLine("please enter your Activity time ") ;
                int dur = int.Parse(Console.ReadLine());
                string na = "Listin";
                string des = " What activity do you want ";
                Activity a1 = new Activity(na,des,dur);
                a1.Spinner(dur);
                

                
                break;

                //Quit
                case "4":
                Console.WriteLine(" bye ");
                return;

                                //Handles invalid input
                default:
                Console.WriteLine("Invalid selection, please enter a number 1-5.");
                break;
            }
        }
    }
}