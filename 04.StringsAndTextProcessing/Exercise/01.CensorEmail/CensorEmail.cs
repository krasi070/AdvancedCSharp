using System;
using System.Text;

class CensorEmail
{
    static void Main()
    {
        string inputEmail = Console.ReadLine();
        int indexMonkeyA = inputEmail.IndexOf("@");
        Console.WriteLine(CensoringEmail(inputEmail, indexMonkeyA));
    }
    static StringBuilder CensoringEmail(string email, int index)
    {
        StringBuilder censoredEmail = new StringBuilder();
        for (int i = 0; i < email.Length; i++)
        {
            if (i < index)
            {
                censoredEmail.Append("*");
            }
            else
            {
                censoredEmail.Append(email[i]);
            }
        }
        return censoredEmail;
    }
}

