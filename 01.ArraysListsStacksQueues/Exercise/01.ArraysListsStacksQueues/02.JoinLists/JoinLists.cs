using System;
using System.Collections.Generic;

class JoinLists
{
    static void Main()
    {
        string fstStr = Console.ReadLine();
        string sndStr = Console.ReadLine();
        string joinedStr = fstStr + " " + sndStr;
        List<int> joinedList = new List<int>();
        int index = 0;
        while (true)
        {
            if (index != joinedStr.Split().Length)
            {
                joinedList.Add(int.Parse(joinedStr.Split()[index])); 
            }
            else
            {
                break;
            }
            index++;
        }
        for (int i = 0; i < joinedList.Count; i++)
        {
            for (int j = 0; j < joinedList.Count; j++)
            {
                if ((i != j) && (joinedList[i] == joinedList[j]))
	            {
                    joinedList.RemoveAt(j);
                    j--;
	            }
            }
        }
        joinedList.Sort();
        Console.WriteLine(string.Join(" ", joinedList));
    }
}

