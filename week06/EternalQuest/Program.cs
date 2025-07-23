class Program
{
    static void Main(string[] args)
    {
        int userChoice = 0;
        List<Goal> goals = new List<Goal>();
        int _totalPoints = 0;

        Console.Clear();


        while (userChoice != 6)
        {
            Console.WriteLine($"\nYou have {_totalPoints} points in total.\n");
            Console.WriteLine("Menu Options:");
            Console.WriteLine("\t1. Create New Goal");
            Console.WriteLine("\t2. List Goals");
            Console.WriteLine("\t3. Save Goals");
            Console.WriteLine("\t4. Load Goals");
            Console.WriteLine("\t5. Record Event");
            Console.WriteLine("\t6. Quit");
            Console.Write("Select a choice from the menu: ");

            userChoice = int.Parse(Console.ReadLine());

            switch (userChoice)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("\nThe types of goals are:");
                    Console.WriteLine("\t1. Simple Goal");
                    Console.WriteLine("\t2. Eternal Goal");
                    Console.WriteLine("\t3. Checklist Goal");
                    Console.Write("Which type of goal would you like to create?: ");
                    int typeOfGoal = int.Parse(Console.ReadLine());
                    {
                        switch (typeOfGoal)
                        {
                            case 1:
                                var simpleGoal = new SimpleGoal();
                                simpleGoal.SetGoalType(typeOfGoal);
                                simpleGoal.SetGoal();
                                goals.Add(simpleGoal);
                                Thread.Sleep(3000);
                                Console.Clear();
                                break;
                            case 2:
                                var eternalGoal = new EternalGoal();
                                eternalGoal.SetGoalType(typeOfGoal);
                                eternalGoal.SetGoal();
                                goals.Add(eternalGoal);
                                Thread.Sleep(3000);
                                Console.Clear();
                                break;
                            case 3:
                                var checklistGoal = new ChecklistGoal();
                                checklistGoal.SetGoalType(typeOfGoal);
                                checklistGoal.SetGoal();
                                goals.Add(checklistGoal);
                                Thread.Sleep(5000);
                                Console.Clear();   
                                break;
                        }
                    }
                    break;

                case 2:

                    Console.Clear();

                    if (goals.Count == 0)
                    {
                        Console.WriteLine("No goals available. Please create a goal first.");
                        Thread.Sleep(3500);

                        break;
                    }
                    Console.WriteLine("The goals are:");
                    for (int i = 0; i < goals.Count; i++)
                    {
                        Console.Write($"{i + 1}. ");
                        goals[i].DisplayGoal();
                    }
                    Thread.Sleep(3000);
                    break;

                case 3:
                    Console.Clear();
                    List<string> goalsToFile = new List<string> { _totalPoints.ToString()};
                    foreach (Goal item in goals){
                        goalsToFile.Add(item.GetGoalData());
                    }
                    Console.Write("Enter filename to save: ");
                    string fileName = Console.ReadLine();
                    File.WriteAllLines(fileName, goalsToFile);
                    break;

                case 4:
                    Console.Clear();
                    goals.Clear();
                    Console.Write("Enter filename to load: ");
                    string loadFileName = Console.ReadLine();
                    string[] goalsFromFile = File.ReadAllLines(loadFileName);

                    _totalPoints = int.Parse(goalsFromFile[0]);
                    foreach (string line in goalsFromFile.Skip(1))
                    {
                        string[] elements = line.Split(", ");
                        switch (elements[0])
                        {
                            case "1":
                                goals.Add(new SimpleGoal(elements[0], elements[1], elements[2], elements[3], elements[4]));
                                break;
                            case "2":
                                goals.Add(new EternalGoal(elements[0], elements[1], elements[2], elements[3]));
                                break;
                            case "3":
                                goals.Add(new ChecklistGoal(elements[0], elements[1], elements[2], elements[3], elements[4], elements[5], elements[6]));
                                break;
                        }
                    }
                    break;

                case 5:
                    Console.Clear();

                    if (goals.Count == 0)
                    {
                        Console.WriteLine("No goals available. Please create a goal first.");
                        Thread.Sleep(3500);

                        break;
                    }

                    Console.WriteLine("The goals are:");
                    
                    for (int i = 0; i < goals.Count; i++){
                        Console.WriteLine($"{i + 1}. {goals[i].GetName()}");
                    }

                    Console.Write("\nWhich goal did you accomplish?: ");
                    int goalIndex = int.Parse(Console.ReadLine());
                    Console.WriteLine($"\nCongratulations! You earned {goals[goalIndex - 1].GetPoints()} points.");
                    int pointsEarned = goals[goalIndex - 1].CheckGoal();
                    _totalPoints += pointsEarned;
                    break;

                default:
                    if (userChoice == 6)
                    {
                        Console.WriteLine("Thank you for using the Goal Tracker. Goodbye!");
                        return;
                    }
                    Console.Clear();
                    Console.WriteLine("Invalid choice. Please try again.");
                    Thread.Sleep(3500);
                    Console.Clear();
                    break;
            }
        }
    }
}