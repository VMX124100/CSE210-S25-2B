using System;

public class Goal
{   private int _type;
    protected string _name;
    protected string _description;
    protected int _points;

    public Goal() {
    }

    public Goal(string type, string name, string description, string points){
        _type = int.Parse(type);
        _name = name;
        _description = description;
        _points = int.Parse(points);
    }

    public virtual int GetGoalType(){
        return _type;
    }
    public virtual void SetGoalType(int typeOfGoal){
        _type = typeOfGoal;
    }


    public virtual void SetGoal(){

        Console.WriteLine("What is the name of your goal?");
        _name = Console.ReadLine();
        Console.WriteLine("what is a short description of it?");
        _description = Console.ReadLine();
        Console.WriteLine("What is the amount of points associated with this goal?");
        _points = int.Parse(Console.ReadLine());

    }

    public virtual void DisplayGoal() {
        Console.WriteLine($"[ ] {_name} ({_description})");
    }

    public virtual int CheckGoal() {
        return _points;
    }

    public virtual string GetGoalData(){
        string goalData = $"{_type}, {_name}, {_description}, {_points}";
        return goalData;
    }

    public virtual string GetName () {
        return _name;
    }

    public virtual string GetDescription() {
        return _description;
    }

    public virtual int GetPoints() {
        return _points;
    }
}