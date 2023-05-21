using System;

class Program
{
    static void Main(string[] args)
    {
        Goal Main = new Goal();
        Simple SGoal = new Simple();
        Eternal EGoal = new Eternal();
        Checklist CGoal = new Checklist();
        GoalTracker GT = new GoalTracker();
        int initiateProgram = 1;
        while (initiateProgram == 1)
        {
            int currentPoints = (GT.GetUserScore());
            string currentLevel = (GT.GetUserLevel());
            Console.WriteLine();
            Console.WriteLine($"You have {currentPoints} points.");
            Console.WriteLine($"Your current level: {currentLevel}");
            Console.WriteLine();
            Console.WriteLine("Menu Options: ");
            Console.WriteLine(" 1. Create New Goal");
            Console.WriteLine(" 2. List Goals");
            Console.WriteLine(" 3. Save Goals");
            Console.WriteLine(" 4. Load Goals");
            Console.WriteLine(" 5. Record Event");
            Console.WriteLine(" 6. Quit");
            Console.Write("Select a choice from the menu: ");
            string _userChoice = Console.ReadLine();
            int userChoice = int.Parse(_userChoice);



            if (userChoice == 1)
            {
                Console.WriteLine("The types of Goals are: ");
                Console.WriteLine(" 1. Simple Goal");
                Console.WriteLine(" 2. Eternal Goal");
                Console.WriteLine(" 3. Checklist Goal");
                Console.Write("Which type of goal would you like to create? ");
                string GoalType = Console.ReadLine();
                int goalType = int.Parse(GoalType);
                if (goalType == 1)
                {
                    SGoal.setGoalType("Simple");
                    SGoal.Display();
                    string saveMe = SGoal.GetStringRepresentation();
                    GT.AddGoal(saveMe);

                }
                else if (goalType == 2)
                {
                    EGoal.setGoalType("Eternal");
                    EGoal.Display();
                    string saveMe = EGoal.GetStringRepresentation();
                    GT.AddGoal(saveMe);

                }
                else if (goalType == 3)
                {
                    CGoal.setGoalType("Checklist");
                    CGoal.Display();
                    string saveMe = CGoal.GetStringRepresentation();
                    GT.AddGoal(saveMe);

                }

            }

            else if (userChoice == 2)
            {
                GT.ShowList();
            }

            else if (userChoice == 3)
            {
                GT.SaveGoals();
            }

             else if (userChoice == 4)
            {
                GT.LoadGoals();
            }

             else if (userChoice == 5)
            {
                GT.RecordEvent();
            }

             else if (userChoice == 6)
            {
                initiateProgram = 0;
            }

        }
          
    }
}