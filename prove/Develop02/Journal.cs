using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography.X509Certificates;


public class Journal
{
  public List<Entry> _entries; 
  public Entry entry = new Entry();
  public string file;
  

  public void AddEntry()
  {
      List<Entry>_entries  = new List<Entry>();
      Entry entry = new Entry();
      PromptGenerator prompt = new PromptGenerator();
      string frase  = prompt.GetRandomPrompt();
      Console.WriteLine(frase);
      DateTime theCurrentTime = DateTime.Now;
      string dateText = theCurrentTime.ToShortDateString();
      Console.WriteLine(dateText);
      Console.WriteLine("Enter the journal entry ; ");
      entry._entryText= Console.ReadLine();
      entry._date = dateText;
      _entries.Add(entry) ;
      Console.WriteLine(entry.ToString());
      Console.WriteLine(_entries.ToString());


      foreach (Entry ent in _entries)
      {
        Console.WriteLine(ent._date);
        Console.WriteLine(ent._entryText);
      }
      
      

  }
  public void DisplayAll()
  {
    List<Entry> newEntry = ReadFromFile();
    foreach(Entry en in newEntry)
    {
      Console.WriteLine(en._entryText);
    }
   }
  public void SaveToFile()
  {
     file = "journal.txt";
    using (StreamWriter outputFile = new StreamWriter (file))
    {
      foreach (Entry ent in _entries)
      {
        outputFile.WriteLine($"{ent._entryText} , {ent._date}");
      }
    }
  }
  public void LoadFromFile(string file)
  {

  }
  public static List<Entry> ReadFromFile()
  {
    List<Entry> ent= new List<Entry>();
    string file ="journal.txt";
    string[] lines = System.IO.File.ReadAllLines(file);
    foreach (string  line in lines)
    {
      Console.WriteLine(line);
    }
    return ent;
  }
}