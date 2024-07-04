using System;


public class MathAssignment : Assignment
{
    protected string _texbookSecction;
    protected string _problems;
    public MathAssignment(string studentName, string topic,string textbookSection,string problems) :base(studentName,topic)
    {
        _texbookSecction =textbookSection;
        _problems = problems;
    }

     public string GetHomeworkList()
    {
        return  $"Section {_texbookSecction} and problems {_problems}";
    }
    
    public void GetTextbookSecction(string textbookSection)
    {
        _texbookSecction = textbookSection;
    }
   
    public void GetProblems(string problems)
    {
        _problems= problems;
    }

   
}