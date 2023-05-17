public class Reflection : Message
{
    private List<string> _reflectionMessageList = new List<string>();

    private List<string> _promptQuestions = new List<string>();

    private Random random = new Random();


    public Reflection() : base()
    {
        string activityName = "Reflecting Activity";
        string activityDescription = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
        SetActivityName(activityName);
        SetDescription(activityDescription);
        GenerateList(); 
    }

    private void GenerateList()
    {
        _reflectionMessageList.Add("Think of a time when you stood up for someone else.");
        _reflectionMessageList.Add("Think of a time when you did something really difficult.");
        _reflectionMessageList.Add("Think of a time when you helped someone in need.");
        _reflectionMessageList.Add("Think of a time when you did something truly selfless.");
        _promptQuestions.Add("Why was this experience meaningful to you?");
        _promptQuestions.Add("Have you ever done anything like this before?");
        _promptQuestions.Add("How did you get started?");
        _promptQuestions.Add("How did you feel when it was complete?");
        _promptQuestions.Add("What made this time different than other times when you were not as successful?");
        _promptQuestions.Add("What is your favorite thing about this experience?");
        _promptQuestions.Add("What could you learn from this experience that applies to other situations?");
        _promptQuestions.Add("What did you learn about yourself through this experience?");
        _promptQuestions.Add("How can you keep this experience in mind in the future?");

    }

    public void GetReflectionMessage()
    {
        GetMessage(GetActivityName(), GetDescription());
    }

    public void ReflectionMain()
    {
        int index = random.Next(_reflectionMessageList.Count);
        if (_reflectionMessageList.Count == 0)
        {
            Console.WriteLine("You have answered all of choices. Restarting your list of choices...");
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine("Consider the following prompt: ");
            Console.WriteLine();
            Console.WriteLine($"---- {_reflectionMessageList[index]} ----");
            Console.WriteLine();
            Console.WriteLine("When you have something in mind, press enter to continue.");
            Console.ReadLine();
            Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
            countDownTimer();
            Console.Clear();
        }
 
        if (_reflectionMessageList.Count == 0)
        {
            GenerateList();
        }
        else
        {
            double userSpecifiedTime = (GetDuration()/2);
            int index2 = random.Next(_promptQuestions.Count);
            Console.Write($"> {_promptQuestions[index2]} ");
            _promptQuestions.Remove(_promptQuestions[index2]);
            loadingAnimation(userSpecifiedTime);
            Console.WriteLine();
            int index3 = random.Next(_promptQuestions.Count);
            Console.Write($"> {_promptQuestions[index3]} ");
            _promptQuestions.Remove(_promptQuestions[index3]);
            loadingAnimation(userSpecifiedTime);
            _reflectionMessageList.Remove(_reflectionMessageList[index]);
            Console.WriteLine();
        }
    }
    
}