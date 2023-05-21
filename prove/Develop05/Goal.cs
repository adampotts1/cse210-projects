public class Goal
{
    private string _goalType;
    private string _goalName;
    private string _goalDescription;
    private int _goalPoints;

    private int _goalRepeatBonus;

    private int _completedRepeat;

    private int _repeatPoints;

    private string _filename;
    private string _goalSStatus;

    private string _goalEStatus;

    private string _goalCStatus;

    private int _loadSuccess;

    private int _userPoints;

    private string _goalRemarks;

    public Goal()
    {
        _goalRemarks = "[]";
        _goalSStatus = "false";
        _goalEStatus = "false";
    }

    public Goal(string goalName, string goalDescription, int goalPoint, string goalType)
    {
        _goalType = goalType;
        _goalName = goalName;
        _goalDescription = goalDescription;
        _goalPoints = goalPoint;
    }

    public virtual void Display()
    {
        setGoalName();
        setGoalDescription();
        setGoalPoints();
    }

    public void setGoalName()
    {
        Console.Write("What is the name of your goal? ");
        _goalName = Console.ReadLine();
    }

    public void setGoalDescription()
    {
        Console.Write("What is a short description of it? ");
        _goalDescription = Console.ReadLine();
    }

    public void setGoalPoints()
    {
        Console.Write("What is the amount of points associated with this goal? ");
        string GoalPoints = Console.ReadLine();
        int goalPoints = int.Parse(GoalPoints);
        _goalPoints = goalPoints;
    }

    public void setGoalRepeat()
    {
        Console.Write("How many times does this goal need to be accomplished for a bonus? ");
        string RepeatTimes = Console.ReadLine();
        int repeatTimes = int.Parse(RepeatTimes);
        _goalRepeatBonus = repeatTimes;
    }
    
    public void setRepeatPoints()
    {
        Console.Write("What is the bonus for accomplishing it that many times? ");
        string RepeatPoints = Console.ReadLine();
        int repeatPoints = int.Parse(RepeatPoints);
        _repeatPoints = repeatPoints;
    }

    public void setCompletedRepeat(int data)
    {
        _completedRepeat = _completedRepeat + data;
    }


    public void setGoalType(string type)
    {
        _goalType = type;
    }

    public void setFileName(string name)
    {
        _filename = name;
    }

    public void setLoadSuccess(int data)
    {
        _loadSuccess = data;
    }

    public void setUserPoints(int data)
    {
        _userPoints = _userPoints + data;
    }

    public void setSStatus()
    {
        _goalSStatus = "true";
    }

    public void setEStatus()
    {
        _goalEStatus = "true";
    }

    public void setCStatus()
    {
        _goalCStatus = "true";
    }

    public void setGoalRemarks()
    {
         _goalRemarks = "[X]";
    }
    
    public void resetGoalRemarks()
    {
        _goalRemarks = "[]";
    }


    public string GetCStatus()
    {
        return _goalCStatus;
    }

    public virtual string GetSStatus()
    {
        return _goalSStatus;
    }

    public virtual string GetEStatus()
    {
        return _goalEStatus;
    }

    public string GetGoalRemarks()
    {
        return _goalRemarks;
    }
  

    public virtual int GetUserPoints()
    {
        return _userPoints;
    }

    public int GetLoadSuccess()
    {
        return _loadSuccess;
    }

    public string GetFileName()
    {
        return _filename;
    }


    public int getcompletedRepeat()
    {
        return _completedRepeat;
    }

    public string getGoalType()
    {
        return _goalType;
    }


    public int GetRepeatPoints()
    {
        return _repeatPoints;
    }

    public int GetRepeatBonus()
    {
        return _goalRepeatBonus;
    }

    public string GetGoalName()
    {
        return _goalName;
    }

    public string GetGoalDescription()
    {
        return _goalDescription;
    }

    public int GetGoalPoints()
    {
        return _goalPoints;
    }

    public virtual string GetStringRepresentation() 
    {
        return $"{_goalType}:{_goalName},{_goalDescription},{_goalPoints}";
    }
}