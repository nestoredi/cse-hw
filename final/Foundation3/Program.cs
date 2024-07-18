using System;

class Program
{
    static void Main(string[] args)
    {
        Lectures event1 = new Lectures("The first vision","1","Doctrinal talk","July 25,2024","8.00 pm","Jhon Smith","100");
        Console.WriteLine(event1.fullDetails());
        Console.WriteLine(event1.shortDetails());
        Console.WriteLine(event1.standarDetails());
        Receptions event2 = new Receptions("Jhonson Weading","2","Celestial marriage","July 25,2024","8.00 pm","events@evemtscom");
        Console.WriteLine(event2.fullDetails());
        Console.WriteLine(event2.shortDetails());
        Console.WriteLine(event2.standarDetails());
        OutdoorGhaterings event3 = new OutdoorGhaterings("Jhonson Weading","2","Celestial marriage","July 25,2024","8.00 pm","the temp is 22 deg Celsius, not rain");
        Console.WriteLine(event3.fullDetails());
        Console.WriteLine(event3.shortDetails());
        Console.WriteLine(event3.standarDetails());

    }
}