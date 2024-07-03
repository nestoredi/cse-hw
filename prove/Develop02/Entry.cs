using System;

public class Entry {
public string _date ;
public string _entryText {get;}





    //Displays the content of an entry
    public void DisplayEntry()
    {
        Console.WriteLine($"Date: {_date }");
        Console.WriteLine($"Content: {_entryText}\n");
    }

}