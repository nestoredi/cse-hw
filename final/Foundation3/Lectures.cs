public class Lectures : Event
{
    private string _speaker;
    private string _capacity;

    public Lectures(string title, string type,string description, string date,string time, string speaker,string capacity): base(title,type,description,date,time)
    {
        _speaker = speaker;
        _capacity = capacity;
    }
    public string standarDetails()
    {
        return $"{_title} by speaker {_speaker} the day {_date} at {_time} for {_description}";
    }
    public string shortDetails()
    {
        return $"{_title} by speaker {_speaker} the day {_date} at {_time} ";
    }
    public string fullDetails()
    {
        return $"{_title} by speaker {_speaker} the day {_date} at {_time} for {_description} only {_capacity} places, reserve yours";
    }
}