public class StationaryBic : Activity
{
 
 private double _speed;
 private double _time;
 public StationaryBic(string activity, string date,double speed,double time):base(activity,date,time)
 {
    _speed = speed;
    
    

 }
 public override double GetSumary()
 {
    
    return _speed ;
 }
    // public override double GetTime()
    // {
    //     return _time;
    // }
    
 }
