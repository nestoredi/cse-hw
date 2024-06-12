using System;

class Program
{
    static void Main(string[] args)
    {
         string answer = "yes";
        while (answer == "yes")
        {
            //Console.WriteLine("Do you want to continue : ");
            //answer = Console.ReadLine();
            int guess = -1;
             Random randomGenerator = new Random();
            int number = randomGenerator.Next(1,100);
            while (guess != number )
            {
               Console.Write("Enter your guess between 1 to 100");
               guess = int.Parse( Console.ReadLine()); 
               if (number > guess) 
               {
                Console.WriteLine("Higher");
               }
               else if (number < guess)
               {
                Console.WriteLine("Lower");
               }
               else
               {
                Console.WriteLine("You guessed it");
                Console.WriteLine($"Your number is {number}");
                

               }
            }
           
         //answer = "no";  
         Console.WriteLine("Do you want to continue ? ");
         answer = Console.ReadLine();
        }
    }
}