using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();
        Running r1 = new Running(50,35,"July 25","run1");
        StationaryBic s1 = new StationaryBic("bic","July 18 2024",50,15);
        SwimmingLap w1 = new SwimmingLap("swimming","July 20",30,15);


        activities.Add(r1);
        activities.Add(s1);
        activities.Add(w1);

        foreach (Activity ac in activities)
        {
            string activ = ac.GetActivity();
            string date = ac.GetDate();
            double run = ac.GetSumary();
            double time = ac.GetTime();
            
            Console.WriteLine($"the day {date} your {activ} to a speed of  {run} in {time} min");
        }
    }
}