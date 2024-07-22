using System;
using System.Collections.Generic;

// Define the base class for all goals
public abstract class Goal
{
    public string _shortName;
    public  string _description;
    public string _points;
    public List<Goal> goals = new List<Goal>();
  public Goal(string shortName,string description, string points)
  {
    _shortName = shortName;
    _description = description;
    _points = points;


  }
  public abstract string GetName();
  public abstract string GetDescription();
  public abstract string GetPoints();
}