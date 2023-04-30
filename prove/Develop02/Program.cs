using System;
using System.IO;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        
        int menuChoice = 1;

        string menuEntry = "";
        string currentDateTime = "";

        List<string> storeCurrentEntry = new List<string>();

        Name systemDate = new Name();
        Entry userInput = new Entry();
        

        while (menuChoice == 1) 
        {
            Console.WriteLine("Welcome to Your Journal");
            Console.WriteLine("Please select one of the following options: ");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write(": ");
            string strUserChoice = Console.ReadLine(); 
            int userChoice = int.Parse(strUserChoice);

            if (userChoice == 1) {
                storeCurrentEntry.Clear();
                Console.Write("Current Date: ");
                systemDate.displayDateTime();
                Console.WriteLine("");
                string activeDate = systemDate._dateTime;
                storeCurrentEntry.Add(activeDate);
                currentDateTime = activeDate;

                string promptQuestion = userInput.promptGenerator();
                storeCurrentEntry.Add(promptQuestion);
                Console.WriteLine(promptQuestion);
                Console.WriteLine("");
                string userAnswer = Console.ReadLine();
                storeCurrentEntry.Add(userAnswer);
                menuEntry = userAnswer;

                Console.WriteLine("");
                Console.WriteLine("Save your progress?");
            }

            else if (userChoice == 2) {
                Journal displayJournal = new Journal();
                displayJournal.displayJournal();
            }

            else if (userChoice == 3) {
                Console.WriteLine("Choose a saved file: ");
                Console.WriteLine("");
                if ((userInput.journalEntries.Any())) {
                    foreach (string journal in userInput.journalEntries) {
                    Console.WriteLine(journal);
                    Console.WriteLine("");
                    }
                } else {
                    Console.WriteLine("There are no entries.");
                    break;
                }
                Console.Write("Please select the file: ");
                string userChoiceLoad = Console.ReadLine();
                Journal._getFileNameForLoading = userChoiceLoad;
                Journal displayLoad = new Journal();
                displayLoad.displayJournalLoading();

            }

            else if (userChoice == 4) {
                Console.WriteLine("Do you want to save your current progress?");
                Console.Write("Yes / No? ");
                string _userSaveChoice_ = Console.ReadLine(); 
                string userSaveChoice = _userSaveChoice_.ToLower();//
                Console.WriteLine("");

                if (userSaveChoice == "yes") 
                {
                    Console.WriteLine("Do you want the current Date and Time to be the file name? ");
                    Console.Write("Yes / No? ");
                    string _userFileNameDefine_ = Console.ReadLine();
                    string userFileNameDefine = _userFileNameDefine_.ToLower();

                    if (userFileNameDefine == "yes")
                    {
                        Entry._fileName = systemDate._dateDayYear;
                        userInput.savetoFile(storeCurrentEntry);
                    } 
                    else if (userFileNameDefine == "no")
                    {
                        Console.Write("What is your preferred filename? ");
                        string preferredFileName = Console.ReadLine();
                        Entry._fileName = preferredFileName;
                        userInput.savetoFile(storeCurrentEntry);
                    }
                }
            }
            
            else if (userChoice == 5) {
            menuChoice = 0;
            }
        }
    }
}
