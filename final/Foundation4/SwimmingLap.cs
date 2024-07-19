public class SwimmingLap : Activity
{
    private double _laps;
    private double _time;

    public SwimmingLap(string activity,string date,double time,double laps):base(activity,date,time)
    {
        _laps = laps;
        _time =time;
    }
    public override double GetSumary()
    {
        return _laps*50/1000/_time;
    }
}