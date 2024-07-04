using System;

public class WritingAssignment : Assignment
{
    protected string _title;
    public WritingAssignment(string studentName, string topic,string title): base(studentName,topic)
    {
        _title = title;
    }

    public string GetWritingInformation()
    {
        string studentName = GetName();
        return $" {_title}, by {studentName}";
    }
}