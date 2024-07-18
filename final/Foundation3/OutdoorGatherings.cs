public class OutdoorGhaterings : Event
{
    private string _weather;

    public OutdoorGhaterings(string title, string type,string description, string date,string time,string weather): base(title,type,description,date,time)
    {
        _weather = weather;
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
        return $"{_title}  the day {_date} at {_time} for {_description}  , the time wil be : {_weather}";
    }
}
