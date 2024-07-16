using System.Runtime.CompilerServices;

public class Video
{
    public string _title;
    public string _author;
    public double _lenght;
    public List<Comment> comment = new List<Comment>();
    
    public void GetComments()
    {
        Console.WriteLine($"title :{_title} by {_author}");
        foreach (Comment c in comment)
        {
         c.DisplayComment();   
        } 
    }
}