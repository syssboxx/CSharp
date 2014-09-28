using System;
using System.Collections.Generic;
using System.Linq;

class QuickSort
{
    static void Main()
    {
        int[] array = { 5, 3, 2, 8, 7, 8, 1, 9, 4 };

        //string [] stringArray = { "abc","abcd","bcdet","qwert","aszd","zsdew","ased" };

        List<int> arrayList =array.ToList();
        List<int> sortedList = new List<int>();

        //print unsorted array
        Console.Write("Unsorted array: ");
        PrintArray(arrayList);

        sortedList=QuickSortArray(arrayList);

        //print the sorted array
        Console.Write("Sorted array:   ");
        PrintArray(sortedList);
    }

    //print array
    public static void PrintArray(List<int> array)
    {
        foreach (int item in array)
	    {
		    Console.Write(item + " ");
	    }
        Console.WriteLine();
    }

    //partition
    static List<int> QuickSortArray(List<int> array)
    {
        List<int> right = new List<int>();
        List<int> left = new List<int>();

        if (array.Count < 2)
        {
            return array;
        }

        int pivotIndex=array.Count / 2;
        int pivot = array[pivotIndex]; //i choose pivot=mediane

        //Console.WriteLine(pivot);  //Debug

        for (int i = 0; i < array.Count; i++)
        {
            if (i!=pivotIndex)
            {
                if (array[i] < pivot)
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
    static List<int> ConcatenateArrays(List<int> left,int pivot,List<int> right)
    {
        List<int> sortedArray = new List<int>();
        sortedArray.AddRange(left);
        sortedArray.Add(pivot);
        sortedArray.AddRange(right);

       return sortedArray;
    }
}
