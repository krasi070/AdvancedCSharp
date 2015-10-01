using System;
using System.Collections.Generic;

class Phonebook
{
    static void Main()
    {
        Dictionary<string, string> phonebook = new Dictionary<string, string>();
        List<string> list = new List<string>();
        List<string> searches = new List<string>();
        do
        {
            list.Add(Console.ReadLine());
        } while (list[list.Count - 1] != "search");
        list.RemoveAt(list.Count - 1);
        do
        {
            searches.Add(Console.ReadLine());
        } while (searches[searches.Count - 1] != "");
        searches.RemoveAt(searches.Count - 1);
        for (int i = 0; i < list.Count; i++)
        {
            if (phonebook.ContainsKey(list[i].Split('-')[0]))
            {
                phonebook[list[i].Split('-')[0]] += ", (" + list[i].Split('-')[1] + ")";
            }
            else
            {
                phonebook[list[i].Split('-')[0]] = list[i].Split('-')[1];
            }
        }
        for (int i = 0; i < searches.Count; i++)
        {
            if (phonebook.ContainsKey(searches[i]))
            {
                Console.WriteLine("{0} -> {1}", searches[i], phonebook[searches[i]]);
            }
            else
            {
                Console.WriteLine("Contact {0} does not exist.", searches[i]);
            }
        }
    }
}
