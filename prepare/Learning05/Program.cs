using System;

class Program
{
    static void Main(string[] args)
    {
      List<Shape> shapes = new List<Shape>();
      Circle c1 = new Circle("Circle","white",5);
      shapes.Add(c1);

      Rectangle r1 = new Rectangle("Rectangle","red",4,6);
      shapes.Add(r1);

      Square s1 = new Square("Square","green", 6);
      shapes.Add(s1);

      foreach (Shape s in shapes)
      {
        string color = s.GetColor();
        string name = s.GetName();
        double area = s.GetArea();
        Console.WriteLine($"The name is {name} and the color is {color} and the ares is {area}");
      }
    }
}