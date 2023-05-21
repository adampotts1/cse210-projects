using System.IO;
public class GoalTracker : Goal
{
    private List<string> GoalsList = new List<string>();
    private int _userScore;

    private List<string> GoalStatus = new List<string>();

    private string _userLevel = "";

    public GoalTracker()
    {
        setUserLevel(_userScore);
    }

    public void AddGoal(string data)
    {
        GoalsList.Add(data);
        GoalStatus.Add("false");
    }

    public void ShowList()
    {

        if (GoalsList.Count != 0)
        {
            foreach (string goal in GoalsList)
        {
            int statusIndex = ((GoalsList.IndexOf(goal)));
            int numberCount = ((GoalsList.IndexOf(goal)) + 1);
            string[] parts = goal.Split(":");
            string type = parts[0];
            string details = parts[1];

            string[] parts2 = details.Split(",");
            string name = parts2[0];
            string description = parts2[1];
            string points = parts2[2];
            string goalStatus = GoalStatus[statusIndex];
            
            if (GetLoadSuccess() == 0)
            {
                setUserLevel(_userScore);
                if (type == "Simple")
                {
                    if (goalStatus == "true")
                    {
                        setGoalRemarks();
                    }
                    Console.WriteLine($"{numberCount}. {GetGoalRemarks()} {name} ({description}) ");
                    resetGoalRemarks();
                }
                else if (type == "Eternal")
                {
                    Console.WriteLine($"{numberCount}. {GetGoalRemarks()} {name} ({description}) ");
                }
                else if (type == "Checklist")
                {
                    string repeat = parts2[3];
                    int _repeat = int.Parse(repeat);
                    if ((getcompletedRepeat()) == _repeat)
                    {
                        setGoalRemarks();
                    }
                    Console.WriteLine($"{numberCount}. {GetGoalRemarks()} {name} ({description}) -- Currently completed: {(getcompletedRepeat())}/{repeat}");
                }
            }
            else
            {
                setUserLevel(_userScore);
                if (type == "Simple")
                {
                    if (goalStatus == "true")
                    {
                        setGoalRemarks();
                    }
                    Console.WriteLine($"{numberCount}. {GetGoalRemarks()} {name} ({description}) ");
                    resetGoalRemarks();
                }
                else if (type == "Checklist")
                {

                    string repeat = parts2[3];
                    int _repeat = int.Parse(repeat);
                    string completedRepeat = parts2[5];
                    int _completedRepeat = int.Parse(completedRepeat);
                    if (_completedRepeat == _repeat)
                    {
                        setGoalRemarks();
                    }
                    Console.WriteLine($"{numberCount}. {GetGoalRemarks()} {name} ({description}) -- Currently completed: {(completedRepeat)}/{repeat}");
                    resetGoalRemarks();
                }
                else if (type == "Eternal")
                {
                    Console.WriteLine($"{numberCount}. {GetGoalRemarks()} {name} ({description}) ");
                }
                
            }
            
        }
        }
        else 
        {
            Console.WriteLine("Your current goal is empty.  Create or Load Goals to get started.");
        }
    }

    public void SaveGoals()
    {
        Console.WriteLine("What is the file name? ");
        string FileName = Console.ReadLine();
        string FileName2 = "goalStatus.txt";
        if (FileName.Length != 0)
        {
            using (StreamWriter writer = new StreamWriter(FileName))
        {
            writer.WriteLine(_userScore);
            foreach (string goal in GoalsList)
            {
                writer.WriteLine(goal);
            }
            GoalsList.Clear();

            using (StreamWriter writer1 = new StreamWriter(FileName2))
            {
                writer1.WriteLine(_userScore);
                foreach (string status in GoalStatus)
                {
                    writer1.WriteLine(status);
                }
                GoalStatus.Clear();
            }
        }
        } 
        else 
        {
            Console.WriteLine("Please enter a name.");
        }

    }

    public void LoadGoals()
    {
        setUserLevel(_userScore);
        GoalsList.Clear();
        GoalStatus.Clear();
        Console.WriteLine("What is file name? ");
        string FileName = Console.ReadLine();
        setFileName(FileName);
        using (StreamReader reader = new StreamReader(FileName))
        {
            string line;
            reader.ReadLine();
            while ((line = reader.ReadLine()) != null)
            {
                GoalsList.Add(line);
            }
            
        }

        using (StreamReader reader = new StreamReader("GoalStatus.txt"))
        {
            string line;
            string score = reader.ReadLine();
            while ((line = reader.ReadLine()) != null)
            {
                GoalStatus.Add(line);
            }

            int _score = int.Parse(score);
            _userScore = _score;
            
        }

        setLoadSuccess(1);  
    }

    public void RecordEvent()
    {
        string chckListName = "";
        string chkListdscrptn ="";
        string chkListpoints = "";
        string chkListrpt = "";
        string chklistrptp = "";
        string chkListType = "";
        string _loadedattempts = "";
        
        int changeIndex = 0;
        Console.WriteLine("The goals are: ");
        foreach (string goal in GoalsList)
        {
            
            int numberCount = ((GoalsList.IndexOf(goal)) + 1);
            string[] parts = goal.Split(":");
            string[] details = parts[1].Split(",");
            string type = parts[0];

            string name = details[0];
            string description = details[1];
            string points = details[2]; 
            string repeat = "";
            string repeatPoints = "";
            if (type == "Checklist")
            {
                int currentIndex = GoalsList.IndexOf(goal);
                chkListType = "Checklist";
                chckListName = details[0];
                chkListdscrptn = details[1];
                chkListpoints = details[2];
                chkListrpt = details[3];
                chklistrptp = details[4];
                changeIndex = currentIndex;
                repeat = details[3];
                repeatPoints = details[4];
                _loadedattempts = details[5];
            }

            Console.WriteLine($" {numberCount}. {name}");
        }

        Console.Write("Which goal did you accomplish? ");
        string _userRecord = Console.ReadLine();
        int userRecord = int.Parse(_userRecord);
        int acquiredPoints = correspondingPoint(userRecord, _loadedattempts);
        _userScore = _userScore + acquiredPoints;
        Console.WriteLine($"Congratulations! You have earned {acquiredPoints}");
        Console.WriteLine($"You now have {_userScore}");
        if (chkListType == "Checklist")
        {
            int loadedattempts = int.Parse(_loadedattempts);
            int chklistAttmpts = (getcompletedRepeat());
            int totalAttmpts = loadedattempts + chklistAttmpts;
            GoalsList[changeIndex] = $"{chkListType}:{chckListName},{chkListdscrptn},{chkListpoints},{chkListrpt},{chklistrptp},{totalAttmpts}";
        }
        
    }

    public int correspondingPoint(int userRecordedChoice, string currentRepeat)
    {
        int pointSelected = 0;

        foreach (string goal in GoalsList)
        {
            int numberCount = ((GoalsList.IndexOf(goal)) + 1);
            string[] parts = goal.Split(":");
            string[] details = parts[1].Split(",");
            string type = parts[0];

            string name = details[0];
            string description = details[1];
            string points = details[2]; 
            int completedRepeat = int.Parse(currentRepeat);

            if (userRecordedChoice == numberCount)
            {
                if (type == "Simple" || type == "Eternal")
                {
                    int _points = int.Parse(points);
                    pointSelected = _points;
                    GoalStatus[(GoalsList.IndexOf(goal))] = "true";
                }


                else if (type == "Checklist")
                {
                    
                    string _repeat = details[3];
                    int repeat = int.Parse(_repeat);
                    string _repeatPoints = details[4];
                    int repeatPoints = int.Parse(_repeatPoints);
                    int _points = int.Parse(points);
                    if (completedRepeat == (repeat - 1))
                    {
                        pointSelected = _points + repeatPoints;
                        setCompletedRepeat(1);

                    }
                    else
                    {
                        pointSelected = _points;
                        setCompletedRepeat(1);
                    }

                    
                }

            }
            
        }

        return pointSelected;
    }

    public void printList()
    {
        foreach (string goal in GoalsList)
        {
            Console.WriteLine(goal);
        }
    }

    public int GetUserScore()
    {
        return _userScore;
    }

    public void setUserLevel(int userScore)
    {
        if (userScore >= 0 && userScore < 1000)
        {
            _userLevel = "Newbie Goal Hunter";
        }

        else if (userScore >= 1000 && userScore < 2000)
        {
            _userLevel = "Rookie Goal Hunter";
        }

        else if (userScore >= 2000 && userScore < 3000)
        {
            _userLevel = "Expert Goal Hunter";
        }

        else if (userScore >= 3000 && userScore < 5000)
        {
            _userLevel = "Proficient Goal Hunterr";
        }

        else if (userScore >= 5000)
        {
            _userLevel = "The Unstoppable";
        }
    }

    public string GetUserLevel()
    {
        return _userLevel;
    }

}