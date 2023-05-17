using System;
public class ListingClass : Message
{
    private List<string> _ListPromptList = new List<string>();

    private List<string> _userInput = new List<string>();

    Random random = new Random();

    public ListingClass() : base()
    {
        string activityName = "Listing Activity";
        string activityDescription = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        GenerateListPrompt();
        SetActivityName(activityName);
        SetDescription(activityDescription);
    }

    private void GenerateListPrompt()
    {
        _ListPromptList.Add("Who are people that you appreciate?");
        _ListPromptList.Add("What are personal strengths of yours?");
        _ListPromptList.Add("Who are people that you have helped this week?");
        _ListPromptList.Add("When have you felt the Holy Ghost this month?");
        _ListPromptList.Add("Who are some of your personal heroes?");
    }

    public void GetListingMessage()
    {
        GetMessage(GetActivityName(), GetDescription());
    }

    public void ListingMain()
    {
        
        Console.WriteLine();
        int index = random.Next(_ListPromptList.Count); 
        Console.WriteLine("List as many responses you can to the following prompt");
        Console.WriteLine($"--- {_ListPromptList[index]} ---");
        countDownTimer();
        Console.WriteLine();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string userEntry = Console.ReadLine();
            _userInput.Add(userEntry);
        }
        Console.WriteLine($"You listed {_userInput.Count} items!");
    }

}