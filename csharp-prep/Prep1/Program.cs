using System;

class Program
{
    static void Main(string[] args)
    {
        // ask for your name
        Console.Write("What is your first name?: ");
        string first = Console.ReadLine();
        Console.Write("What is your last name? : ");
        string last = Console.ReadLine();

        Console.WriteLine($" your  name is {last} , {first} {last}");
    }
}