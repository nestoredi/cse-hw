using System.Data.SqlTypes;

public class GoalManager
{
    List<Goal> _goals ;
    
    public GoalManager()
    {
        new List<Goal>();
        Goal goal;
    }
    public void CreateGoal()
    {
      while (true) {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. simple goal");
            Console.WriteLine("2. eternal goal");
            Console.WriteLine("3. checklist goal");
            Console.WriteLine("4. quit");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Record Quit");

            //Requests user selection for action to take
            Console.Write("Please select an option (1-5) ");
            string choice = Console.ReadLine();

            //Calls class methods per user selection
            switch (choice) {
                //Adds new Goal
                case "1":
                Console.WriteLine("enter your simple goal :");
                string sg = Console.ReadLine();
                Console.WriteLine("enter your descript :");
                string descr = Console.ReadLine();
                Console.WriteLine("enter your points :");
                string p = Console.ReadLine();
                Goal goal = new Goal(sg,descr,p);

                

                
                break;

                //List Goal
                case "2":
                
                
                break;

                //Save Goals to Goal.txt
                case "3":
                
                
                break;

                

                //Exits program
                case "4":
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