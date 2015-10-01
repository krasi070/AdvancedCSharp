using System;
using System.Collections.Generic;
using System.Text;

class Palindromes
{
    static void Main(string[] args)
    {
        string inputStr = Console.ReadLine();
        inputStr += " ";
        string lowerStr = inputStr.ToLower();
        StringBuilder isPalindrome = new StringBuilder();
        StringBuilder isPalindrome2 = new StringBuilder();
        List<string> palindromes = new List<string>();
        int firstIndex = 0;
        int lastIndex = 0;
        int count = 0;
        for (int i = 0; i < inputStr.Length; i++)
        {
            firstIndex = i;
            if (lowerStr[i] >= 97 && lowerStr[i] <= 122)
            {
                for (int j = i; j < inputStr.Length; j++)
                {
                    if (lowerStr[j] < 97 || lowerStr[j] > 122)
                    {
                        lastIndex = j;
                        i = j;
                        break;
                    }
                }
            }
            for (int j = lastIndex - 1; j >= firstIndex; j--)
            {
                isPalindrome.Append(inputStr[j]);
            }
            for (int j = firstIndex; j < lastIndex; j++)
			{
                isPalindrome2.Append(inputStr[j]);
			}
            for (int j = 0; j < isPalindrome.Length; j++)
            {
                if (isPalindrome[j] == isPalindrome2[j])
                {
                    count++;
                }
            }
            if (count == isPalindrome.Length && isPalindrome.ToString() != string.Empty)
            {
                palindromes.Add(isPalindrome.ToString());
            }
            isPalindrome.Clear();
            isPalindrome2.Clear();
            count = 0;
        }
        Console.WriteLine(string.Join(", ", palindromes));
    }
}

