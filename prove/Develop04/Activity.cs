using System;
using System.ComponentModel;
using System.Reflection;
public class Activity
{
    protected string  _name ="";
    protected string  _description = "";
    protected int  _duration = 0;
    
    public   Activity(string name,string description,int duration)
    {
       _name = name;
        _description = description;
        _duration = duration;

        
       
    }
    
    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to your {_name}");
    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine("You finish you activity ");
    }
    public void Spinner(int seconds)
    {
      
      _duration = seconds;
      for(int i= _duration/4 ;i>0; i--)
      {
        Console.Write(i);
        Thread.Sleep(1000);
        Console.Write("\b  \b");
        Console.WriteLine("\n");
        string re= ">";
        Console.Write(re);
        Console.ReadLine();
      }
    }
    public void ShowCountDown(int seconds)
    {
     List<string> spin = new List<string>();
     spin.Add("|");   
     spin.Add("/");   
     spin.Add("-");   
     spin.Add("\\");   
     spin.Add("|");   
     spin.Add("/");   
     spin.Add("-");   
     spin.Add("\\");   
     spin.Add("|"); 

     foreach (string s in spin)
     {
      Console.WriteLine(s);
      Thread.Sleep(1000);
      Console.WriteLine(" Breathe in....");
      Thread.Sleep(3000);
      Console.WriteLine(" Breathe out...");
      
      
      Console.WriteLine("\b \b");
     }  
    }
}