using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int[] array = { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 };

        Dictionary<int, int> elementsDict = new Dictionary<int, int>();

        int maxFrequency = 0;
        int mostFrequentNumber = 0;

        for (int i = 0; i < array.Length; i++)
        {
            //int count = 0;
            if (elementsDict.ContainsKey(array[i]))
            {
                elementsDict[array[i]]++;
                
            }
            else //it's the first apparition of the number - i add it to the dictionary
            {
                elementsDict.Add(array[i], 1);
            }
        }

        foreach (var element in elementsDict)
        {
            if (element.Value>maxFrequency)
            {
                maxFrequency = element.Value;
                mostFrequentNumber = element.Key;
            }
        }

        Console.WriteLine("Most frequent number : {0} - appears {1} times",mostFrequentNumber,maxFrequency);
    }
}