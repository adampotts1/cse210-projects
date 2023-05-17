public class Breathing : Message
{
    private string _breathInPrompt = "";
    private string _breathOutPrompt = "";

    public Breathing() : base()
    {
        string activityName = "Breathing Activity";
        string activityDescription = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
        SetActivityName(activityName);
        SetDescription(activityDescription);
        _breathInPrompt = "Breath in...";
        _breathOutPrompt = "Now breath out...";
    }

    public void GetBreathingMessage()
    {
        GetMessage(GetActivityName(), GetDescription());
    }

    public void BreathingMainPrompt()
    {
        int durationDivided;
        if (GetDuration() <= 10) 
        {
            durationDivided = 10;
        
        }

        else
        {
            durationDivided = GetDuration();
        }
        

        for (int k = 0; k < (durationDivided / 10); k++)
        {
        Console.WriteLine();
        animateTyping(_breathInPrompt, 100);
        int BreathInCount = 5;
            for (int j = 0; j < 4; j++)
            {
                if (BreathInCount != 0){
                BreathInCount = BreathInCount - 1;
                Console.Write(BreathInCount);
                Thread.Sleep(1000);
                Console.Write("\b \b");
                }
                
            }
        Console.WriteLine();
        animateTyping(_breathOutPrompt, 100);
        int BreathOutCount = 7;
            for (int j = 0; j < 6; j++)
            {
                    if (BreathOutCount != 0)
                    {
                    BreathOutCount = BreathOutCount - 1;
                    Console.Write(BreathOutCount);
                    Thread.Sleep(1000);
                    Console.Write("\b \b");
                    }

            }
        Console.WriteLine();
        }
        
    }

    private void animateTyping(string text, int delay = 25)
    {
        for (int i = 0; i < text.Length; i++)
        {
            Console.Write(text[i]);
            Thread.Sleep(delay);
        }
    }

}