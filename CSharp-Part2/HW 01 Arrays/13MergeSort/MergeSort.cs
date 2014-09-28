using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int [] unsortedArray = { 2, 5, 1, 4, 8, 5, 31, 7, 9, 34 };
        
        List<int> unsortedList = unsortedArray.ToList();

        List<int> sortedList = new List<int>();

        //print unsorted array
        Console.Write("Unsorted array: ");
        PrintArray(unsortedList);

        //merge sort
        sortedList = MergeSort(unsortedList);

        //print sorted array
        Console.Write("sorted array:   ");
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

    public static List<int> MergeSort(List<int> list)
    {
        if (list.Count<2)
        {
            return list;
        }

        int mediane = list.Count / 2;

        List <int> left =new List <int>();
        List <int> right=new List <int>();

        for (int i = 0; i < mediane; i++)
		{
		   left.Add(list[i]);
		}
        for (int i = mediane; i < list.Count; i++)
		{
            right.Add(list[i]);
		}

        left = MergeSort(left);
        right = MergeSort(right);
        return Combine(left,right);
    }

    public static List<int> Combine(List<int> left, List<int> right)
    {
        List<int> resultList = new List<int>();

        while ((left.Count > 0) && (right.Count > 0))
        {
            if (left[0] < right[0])
            {
                resultList.Add(left[0]);
                left.RemoveAt(0);
            }
            else
            {
                resultList.Add(right[0]);
                right.RemoveAt(0);
            }
        }
            
        for (int i = 0; i < left.Count; i++)
        {
            resultList.Add(left[i]);
        }

        for (int i = 0; i < right.Count; i++)
        {
            resultList.Add(right[i]);
        }
        return resultList;
    }
}
