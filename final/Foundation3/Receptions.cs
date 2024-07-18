public class Receptions: Event
{
    private string  _email;
    public Receptions(string title, string type,string description, string date,string time,string email): base(title,type,description,date,time)
    {
        _email = email;
    }
    public string standarDetails()
    {
        return $"{_title}  the day {_date} at {_time} for {_description}";
    }
    public string shortDetails()
    {
        return $"{_title}  the day {_date} at {_time} ";
    }
    public string fullDetails()
    {
        return $"{_title}  the day {_date} at {_time} for {_description}  , reserve yours at the email {_email}";
    }
}