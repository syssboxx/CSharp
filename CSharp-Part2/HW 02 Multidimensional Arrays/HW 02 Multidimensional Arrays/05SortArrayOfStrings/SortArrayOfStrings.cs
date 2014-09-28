//You are given an array of strings.
//Write a method that sorts the array by the length of its elements (the number of characters composing them).


using System;
using System.Collections.Generic;

class SortArrayOfStrings
{

    static void Main()
    {
        Console.Write("Enter number of elements :");
        int n=int.Parse(Console.ReadLine());
        string[] stringArray = new string[n];
        //stringArray={"mouse","dog","perroquet","cat","panda","tiger"};

        //read string array
        Console.WriteLine("Enter elements");
        for (int i = 0; i < stringArray.Length; i++)
        {
            stringArray[i] = Console.ReadLine();
        }

       //sort array
        Array.Sort(stringArray, (word1, word2) => (word1.Length.CompareTo(word2.Length)));

        //print sorted array
        Console.WriteLine("Sorted array by characters length :");
        foreach (var item in stringArray)
        {
            Console.Write(item+" ");
        }
    }
    

}
