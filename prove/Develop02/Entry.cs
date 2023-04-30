using System.IO;
using System.Collections.Generic;

public class Entry 
{
    public static string _fileName = "";

    public string _currentDate = "";

    public List<string> journalEntries = new List<string>();

    static string [] prompts = {
        "What was your best memory from today?",
        "Did an exciting event happen today?",
        "Do you have a major regret from today?",
        "How did you feel emotionally about your day today?",
        "If I had one thing I could do over today, what would it be?"   
    };

    public static List<string> _promptList = new List<string>(prompts);

    public List<Entry> _entryStorage = new List<Entry>();

    static Random random = new Random();
    
    public Entry()
    {
    }
    
    public string promptGenerator()
    {
        int index = random.Next(_promptList.Count);
        return (_promptList[index]);
    }

    public void savetoFile(List<string> storeCurrentEntry)
    {
        using (StreamWriter outputfile = new StreamWriter(_fileName, true))
        {
            string date = storeCurrentEntry[0];
            string promptQuestion = storeCurrentEntry[1];
            string userEntry = storeCurrentEntry[2];
            outputfile.WriteLine(date);
            outputfile.WriteLine(promptQuestion);
            outputfile.WriteLine(userEntry);
            outputfile.WriteLine();
            journalEntries.Add(_fileName)        

        }

         using (StreamWriter outputfile = new StreamWriter("allentry.csv", true))
        {
            string date = storeCurrentEntry[0];
            string promptQuestion = storeCurrentEntry[1];
            string userEntry = storeCurrentEntry[2];
            outputfile.WriteLine(date);
            outputfile.WriteLine(promptQuestion);
            outputfile.WriteLine(userEntry);
            outputfile.WriteLine();
            
        }
    }

}
