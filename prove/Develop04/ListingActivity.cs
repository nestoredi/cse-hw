using System;

public class ListingActivity
{
    protected int count;
    protected List<string> _prompts;

    public ListingActivity()
    {
         _prompts = new List<string>{
            "Think of a time when you stood up for someone else",
            "Think of a time when you did something really difficult",
            "Think of a time when you helped someone in need",
            "Think of a time when you did something truly selfless"
         };
    }
    public void Run()
    {
        Console.WriteLine("Write a activity :");

    }
     public string GeneratorPrompt()
     {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
     }
}