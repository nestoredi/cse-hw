public abstract class Activity
{
    private string _activity;
    private string _date;
    private double _time;
    public Activity(string activity,string date,double time)
    {
        _activity = activity;
        _date = date;
        _time = time;

    }
    public string GetActivity()
    {
        return _activity;
    }
    public string GetDate()
    {
        return _date;
    }
    public double GetTime()
    {
        return _time;
    }

    public abstract double GetSumary();
    
}