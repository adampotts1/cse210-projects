public class Message
{
    private string _activityName = "";
    private string _activityDescription = "";

    private int _activityDuration;


    private List<int> storedIndex = new List<int>();


    public Message()
    {
        _activityName = "";
        _activityDescription = "";
        _activityDuration = 0;

    }

    public Message(string activityname, string description)
    {
        _activityName = activityname;
        _activityDescription = description;

    }


    public void GetMessage()
    {
        Console.WriteLine(_activityName);
        Console.WriteLine(_activityDescription);
    }

    public void SetDuration(int time)
    {
        _activityDuration = time;
    }

    public void SetActivityName(string name)
    {
         _activityName = name;
    }

    public void SetDescription(string description)
    {
        _activityDescription = description;
    }

    public string GetActivityName()
    {
        return _activityName;
    }

    public string GetDescription()
    {
        return _activityDescription;
    }

    public int GetDuration()
    {
        return _activityDuration;
    }

    public void countDownTimer()
    {
        Console.Write("You may begin in: ");
        int timerNumber = 6;
        Console.Write(timerNumber);
        for (int i = 0; i < 5; i++)
        {
            Console.Write("\b \b");
            int count = timerNumber - 1;
            Console.Write(count);
            timerNumber = count;
            Thread.Sleep(1000);
        }
        
    }
    
    public void StartProgram()
    {
        Console.Clear();
        ReadyMessage();
    }

    public void GetMessage(string activityName, string activityDescription)
    {
        Console.WriteLine($"Welcome to the {activityName}.");
        Console.WriteLine();
        Console.WriteLine(activityDescription);
        Console.WriteLine();
        Console.Write("How long, in seconds, would you like for your session? ");
        string duration = Console.ReadLine();
        Console.WriteLine();
        int _duration = int.Parse(duration);
        _activityDuration = _duration;
    }

    public void loadingAnimation(double UserSpecifiedTime)
    {
        for (int i = 0; i < UserSpecifiedTime; i++)
        {   
        Console.Write(@"\");
        Thread.Sleep(250);
        Console.Write("\b \b"); // Erase the + character
        Console.Write("|"); // Replace it with the - character
        Thread.Sleep(250);
        Console.Write("\b \b"); // Erase the + character
        Console.Write("/");
        Thread.Sleep(250);
        Console.Write("\b \b"); // Erase the + character
        Console.Write("-");
        Thread.Sleep(250);
        Console.Write("\b \b"); // Erase the + character
        
        }
    }

    public void ReadyMessage()
    {
        Console.WriteLine("Get Ready...");
        loadingAnimation(5);
    }

    public void EndingMessagePrompt()
    {
        Console.WriteLine();
        Console.WriteLine("Well done!!");
        loadingAnimation(5);

        Console.WriteLine($"You have completed another {_activityDuration} seconds of the {_activityName}");
        loadingAnimation(5);
        Console.Clear();

    }
  
}