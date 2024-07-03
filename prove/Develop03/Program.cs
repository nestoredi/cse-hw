using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;


class Program
{
    
    static void Main(string[] args)
    {
       Reference reference = new Reference("D&C :",82,10);
       Console.WriteLine(reference.GetDisplay());
       
        Scripture scripture = new Scripture();
      
       //scripture.GetDisplay();
         //Welcome banner
        Console.WriteLine("Welcome to Your memorizer scripture!");
        scripture.GetDisplay();
        while (true) {
            
            Console.WriteLine(" Menu: enter to run it ");
            Console.WriteLine(" quit to finish");
          

            //Requests user selection for action to take
            
            Console.Write("Please select an option ) ");
            string choice = Console.ReadLine();

            //Calls class methods per user selection
            switch (choice) {
                //Hide words
                case "":
                scripture.HideRandomWords();
                break;

               

                //Exits program
                case "quit":
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