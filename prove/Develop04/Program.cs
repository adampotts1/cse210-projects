using System;

class Program
{
    static void Main(string[] args)
    {
        Breathing BClass = new Breathing();
        Reflection RClass = new Reflection();
        ListingClass LClass = new ListingClass();
        int menuStart = 1;

        while (menuStart == 1){

            Console.WriteLine("Menu Options: ");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select a choice from the menu: ");
            string _userChoice = Console.ReadLine();
            int userChoice = int.Parse(_userChoice);

            if (userChoice == 1)
            {
                Console.Clear();
                BClass.GetBreathingMessage();
                Console.WriteLine();
                BClass.StartProgram();
                BClass.BreathingMainPrompt();
                BClass.EndingMessagePrompt();
                
            }

            else if (userChoice == 2)
            {
                Console.Clear();
                RClass.GetReflectionMessage();
                Console.WriteLine();
                RClass.StartProgram();
                RClass.ReflectionMain();
                RClass.EndingMessagePrompt();
            }

            else if (userChoice == 3)
            {
                Console.Clear();
                LClass.GetListingMessage();
                Console.WriteLine();
                LClass.StartProgram();
                LClass.ListingMain();
                LClass.EndingMessagePrompt();
            }
        }          
    }
}