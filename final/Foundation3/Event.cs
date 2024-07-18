public class Event
{
    protected string _title;
    protected string _type;
    protected string _description;
    protected string _date;
    protected string _time;
    public Event(string title,string type,string description,string date,string time)
    {
        _title = title;
        _type = type;
        _description= description;
        _date = date;
        _time = time;
    }
    public string GetTitle()
    {
        return _title;
    }
    public string GetTyp()
    {
        return _type;
    }
    public string GetDescrip()
    {
        return _description;
    }
    public string GetDate()
    {
        return _date;
    }
    public string GetTime()
    {
        return _time;
    }

}