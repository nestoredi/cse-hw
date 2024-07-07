using System;

public class BreathingActivity : Activity
{
    public BreathingActivity(string name,string description,int duration): base(name,description,duration)
    {

    }
    public void run(int seconds)
    {
      seconds = _duration;

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

     for (int i = 0 ; i < _duration/8; i++)
     {
      
     
      foreach (string s in spin)
      {
      Console.Write(s);
      Thread.Sleep(1000);
      Console.WriteLine(" Breathe in....");
      Thread.Sleep(3000);
      Console.WriteLine(" Breathe out...");
      
      
      Console.WriteLine("\b \b");
     }
     }  
      
       
        
    }
}