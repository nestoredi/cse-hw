using System;

class Program
{
    static void Main(string[] args)
    {
       Job job1 = new Job();
       job1._jobTitle = "Senior developer";
       job1._company = "Cisco";
       job1._starYear = 2018;
       job1._endYear = 2023;

       Job job2 = new Job();
       job2._jobTitle = "Junior developer";
       job2._company = "Oracle";
       job2._starYear = 2015;
       job2._endYear = 2018;

       Resume myResume = new Resume();
       myResume._name = "Scott Red";
       myResume._jobs.Add(job1);
       myResume._jobs.Add(job2);

       myResume.Display();

    }
}