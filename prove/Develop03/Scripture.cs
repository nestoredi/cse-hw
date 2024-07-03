
using System;
using System.Collections.Generic;
using System.IO;

public class Scripture
{
    List<Word> _words;
    Word word1 = new Word( "I, the Lord,");
        Word word2 = new Word("am bound when ");
        Word word3 = new Word(" ye do what ");
        Word word4 = new Word(" I say; ");
        Word word5 = new Word(" but when ye do not ");
        Word word6 = new Word(" what I say, ye ");
        Word word7 = new Word(" have no promise");

    public Scripture()
    {
        _words = new List<Word>();
       
        _words.Add(word1);
        _words.Add(word2);
        _words.Add(word3);
        _words.Add(word4);
        _words.Add(word5);
        _words.Add(word7);
        
        
        

    }
    

    public void GetDisplay()
    {
          Reference reference = new Reference("D&C :",82,10);
            Console.WriteLine(reference.GetDisplay());
        foreach (Word w in _words)
        {
           Console.Write(w.GetDisplayText());
        }
         
    }
    public void HideRandomWords()
    {
        
        Random random = new Random();
        int number = random.Next(_words.Count);
        Word word =new Word("__");
         foreach (Word w in _words)
        {
           if (w == _words[number])
           {
            
            Console.Write("__");
           }
           
           else
           {
           Console.Write(w.GetDisplayText());
           }
        }
       
    }
}
