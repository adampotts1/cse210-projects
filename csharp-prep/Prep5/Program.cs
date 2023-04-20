using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int squareNumber = UserSquareNumber(userNumber);
        
        DisplayResult(userName, squareNumber);

    }

//Display Name Function
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome the the program! ");

    }
// PromptUserName Function
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();

        return name;
    }
// PromptUserNumber Function
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());

        return number;
    }
// UserNumber squared function
    static int UserSquareNumber(int number)
    {
        int square = number * number;
       
        return square;
    }
// DisplayResult Funtion
    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}");
    }
}