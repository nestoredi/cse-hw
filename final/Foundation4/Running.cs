public class Running : Activity
{
    private double _distance;
    private double _time;
    public Running(double distance,double time,string date,string activity): base (activity,date,time)
    {
        _distance = distance;
        _time = time;
    }
    // public override double GetTime()
    // {
    //     return _time;
    // }
    public override double GetSumary()
    {
        return _distance/_time *60 ;
    }

}