using System;

public class SimpleGoal:Goal
{
   private bool _checked;

   public SimpleGoal(){
      _checked = false;
   }

   public SimpleGoal(string type, string name, string description, string points, string check):base(type, name, description, points){
      _checked = bool.Parse(check);

   }

   public override void DisplayGoal() {
        if (_checked == false){
            Console.WriteLine($"[ ] {GetName()} ({GetDescription()})");
        }
        else if (_checked == true){
            Console.WriteLine($"[X] {GetName()} ({GetDescription()})");
        }
    }

    public override int CheckGoal() {
        if (_checked == false) {
            _checked = true;
            return base.CheckGoal();
        }

        else if (_checked == true){
            Console.WriteLine("Goal already completed");
            return 0;
        }
        else {return 0;}
    }

    public override string GetGoalData(){
      string goalData = $"{GetGoalType()}, {GetName()}, {GetDescription()}, {GetPoints()}, {_checked}";
      return goalData;
    }
}