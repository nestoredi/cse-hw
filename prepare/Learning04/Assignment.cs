using System;


public class Assignment
{
    protected string _studentName = "" ;
    protected string _topic ="";
    public Assignment(string studentName,string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }
    public string GetSumar()
    {
        return  $" the {_topic} by {_studentName}";
    }
    
    public string GetName()
    {
        return _studentName;
    }
   
    public string GetTopic()
    {
        return _topic;
    }
}