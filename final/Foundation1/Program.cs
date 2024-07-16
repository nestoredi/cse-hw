using System;

class Program
{
    static void Main(string[] args)
    {
        Comment com1 = new Comment();
        com1._comment = "Really good video";
        Comment com2 = new Comment();
        com2._comment = "Really good video";
        Comment com3 = new Comment();
        com3._comment = "Really good video";
        Video video = new Video();
        video.comment.Add(com1);
        video.comment.Add(com2);
        video.comment.Add(com3);
        video._title = "Moon";
        video._author ="Jhon Smith";
        video._lenght = 54;
        video.GetComments();
    }
}