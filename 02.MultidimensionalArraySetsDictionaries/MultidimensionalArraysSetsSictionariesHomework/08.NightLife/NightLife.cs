using System;
using System.Collections.Generic;
using System.Linq;

class NightLife
{
    static void Main()
    {
        List<string> input = new List<string>();
        do
        {
            input.Add(Console.ReadLine());
        } while (input[input.Count - 1] != "END");
        input.RemoveAt(input.Count - 1);
        SortedSet<string> setVenues = new SortedSet<string>();
        SortedSet<string> setPerformers = new SortedSet<string>();
        HashSet<string> results = new HashSet<string>(); 
        for (int i = 0; i < input.Count; i++)
        {
            for (int j = 0; j < input.Count; j++)
            {
                if (input[i].Split(';')[0] == input[j].Split(';')[0])
                {
                    if (input[i].Split(';')[1] == input[j].Split(';')[1])
                    {
                        setPerformers.Add(input[j].Split(';')[2]);
                    }
                }
            }
            results.Add(input[i].Split(';')[0] + ":" + input[i].Split(';')[1] + ":" + string.Join((", "), setPerformers));
            setPerformers.Clear();
        }
        List<string> resultsList = new List<string>();
        resultsList.AddRange(results);
        List<string> actualResults = new List<string>();
        for (int i = 0; i < resultsList.Count; i++)
        {
            for (int j = 0; j < resultsList.Count; j++)
            {
                if (resultsList[i].Split(':')[0] == resultsList[j].Split(':')[0])
                {
                    setVenues.Add(resultsList[j]);
                    if (i != j)
                    {
                        resultsList.RemoveAt(j);
                        j--;
                    }
                }
            }
            resultsList.InsertRange(i, setVenues);
            i += setVenues.Count;
            setVenues.Clear();
        }
        results.Clear();
        for (int i = 0; i < resultsList.Count; i++)
        {
            results.Add(resultsList[i]);
        }
        resultsList.Clear();
        resultsList.AddRange(results);
        for (int i = 0; i < resultsList.Count; i++)
        {
            if (i == 0)
            {
                Console.WriteLine("{0}\n->{1}: {2}", resultsList[i].Split(':')[0], resultsList[i].Split(':')[1], resultsList[i].Split(':')[2]);
            }
            else
            {
                if (resultsList[i].Split(':')[0] == resultsList[i - 1].Split(':')[0])
                {
                    Console.WriteLine("->{0}: {1}", resultsList[i].Split(':')[1], resultsList[i].Split(':')[2]);
                }
                else
                {
                    Console.WriteLine("{0}\n->{1}: {2}", resultsList[i].Split(':')[0], resultsList[i].Split(':')[1], resultsList[i].Split(':')[2]);
                }
            }
        }
    }
}

