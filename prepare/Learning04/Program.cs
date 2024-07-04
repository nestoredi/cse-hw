using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment1 = new Assignment("Nestor Crossa","Calculus");
        
        Console.WriteLine(assignment1.GetSumar());
        MathAssignment assigment2 = new MathAssignment("Gian Crossa","Fractions","10.2","21-23");
        Console.WriteLine(assigment2.GetSumar());
        Console.WriteLine(assigment2.GetHomeworkList());
        WritingAssignment assignment3 = new WritingAssignment("Eduardo Crossa","II war","5.3");
        Console.WriteLine(assignment3.GetSumar());
        Console.WriteLine(assignment3.GetWritingInformation());

        
    }
}