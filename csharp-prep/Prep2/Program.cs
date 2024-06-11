using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your percentage : ");

        string grade = Console.ReadLine();
        int percentage = int.Parse(grade);

        string letter = "";
        if (percentage >= 90)
        {
            letter = "A";
        }
        else if (percentage>= 80)
        {
            letter = "B";  
        }
        else if (percentage>= 70)
        {
            letter = "C";
        }
        else if (percentage >= 60)
        {
            letter = "D";

        }
        else 
        {
            letter = "F";
        }
        Console.WriteLine($" your grade is {letter}");
        if (percentage >= 70 )
        {
            Console.WriteLine(" You passed. Congrats!!!");
        }
        else
        {
            Console.WriteLine(" Next time better luck");
        }
    }
}