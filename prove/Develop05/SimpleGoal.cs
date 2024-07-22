public class SimpleGoal : Goal
{
    protected string name;
    protected string description;
    protected string points;

    public SimpleGoal (string name,string description,string points): base(name,description,points)
    {
        
    }
    public override string GetName()
    {
        return $"Simple goal is {name}" ;
    }
    public override string GetPoints()
    {
        return points;
    }
    public override string GetDescription()
    {
        return description;
    }
}