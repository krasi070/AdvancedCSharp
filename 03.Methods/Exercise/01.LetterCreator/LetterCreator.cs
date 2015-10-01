using System;

class LetterCreator
{
    static void Main()
    {
        string receiver = Console.ReadLine();
        string sender = Console.ReadLine();
        PrintLetter(sender, receiver, DateTime.Now);
    }
    static void PrintLetter(string sender, string receiver, DateTime currTime)
    {
        Console.WriteLine("Dear {0},\n", receiver);
        Console.WriteLine("I hope I find you in good health.\nI need to inform you that the cheese has run away.\n");
        Console.WriteLine("Sincerely,\n{0}", sender);
        Console.WriteLine("{0}/{1}/{2}", currTime.Month, currTime.Day, currTime.Year);
    }
}

