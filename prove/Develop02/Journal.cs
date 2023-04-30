using System;
public class Journal
{

    public static string  _getFileName = @"allentry.csv";

    public static string _getFileNameForLoading = @"allentry.csv";
 
    string[] lines = System.IO.File.ReadAllLines(_getFileName);

    string[] linesLoad = System.IO.File.ReadAllLines(_getFileNameForLoading);


    

    public Journal()
    {
    }

    public void displayJournal()
    {
        foreach (string line in lines)
        {
            Console.WriteLine(line);
        } 

    }

    public void displayJournalLoading()
    {
        foreach (string line in linesLoad)
        {
            Console.WriteLine(line);
        } 

    }
}