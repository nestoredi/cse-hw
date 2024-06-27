using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography.X509Certificates;


public class Journal
{
  public List<Entry> _entries; 
  public Entry entry = new Entry();
  public string file;
  
  public Journal ()
  {
    _entries = new List<Entry>();
  }
  public void AddEntry()
  {
      
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
      entry.Display();


      foreach (Entry ent in _entries)
      {
        Console.WriteLine(ent._date);
        Console.WriteLine(ent._entryText);
      }
      
      

  }
  public void DisplayAll()
  {
    //List<Entry> newEntry = new List<Entry>();
    
    foreach(Entry en in _entries)
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
  public void LoadFromFile()
  {
     List<Entry> ent= new List<Entry>();
    string file ="journal.txt";
    string[] lines = System.IO.File.ReadAllLines(file);
    foreach (string  line in lines)
    {
      Console.WriteLine(line);
    }
    
  }
 
  
  }
