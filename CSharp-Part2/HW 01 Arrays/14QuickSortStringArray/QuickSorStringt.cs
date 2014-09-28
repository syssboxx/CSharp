using System;
using System.Collections.Generic;
using System.Linq;

class QuickSort
{
    static void Main()
    {
        //int[] array = { 5, 3, 2, 8, 7, 8, 1, 9, 4 };

        string [] stringArray = { "abc","abcd","bcdet","qwert","aszd","zsdew","ased" };

        List<string> arrayList = stringArray.ToList();
        List<string > sortedList = new List<string>();

        //print unsorted array
        Console.Write("Unsorted array: ");
        PrintArray(arrayList);

        sortedList = QuickSortArray(arrayList);

        //print the sorted array
        Console.Write("Sorted array:   ");
        PrintArray(sortedList);
    }

    //print array
    public static void PrintArray(List<string> array)
    {
        foreach (string item in array)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }

    //partition
    static List<string> QuickSortArray(List<string> array)
    {
        List<string> right = new List<string>();
        List<string> left = new List<string>();

        if (array.Count < 2)
        {
            return array;
        }

        int pivotIndex = array.Count / 2;
        string pivot = array[pivotIndex]; //i choose pivot=mediane

        //Console.WriteLine(pivot);  //Debug

        for (int i = 0; i < array.Count; i++)
        {
            if (i != pivotIndex)
            {
                if (array[i].CompareTo(pivot)<0)
                {
                    left.Add(array[i]);
                }
                else
                {
                    right.Add(array[i]);
                }
            }
        }
        right = QuickSortArray(right);
        left = QuickSortArray(left);


        return ConcatenateArrays(left, pivot, right);

    }
    //concatenate elements
    static List<string> ConcatenateArrays(List<string> left, string pivot, List<string> right)
    {
        List<string> sortedArray = new List<string>();
        sortedArray.AddRange(left);
        sortedArray.Add(pivot);
        sortedArray.AddRange(right);

        return sortedArray;
    }
}
