//Write a method that return the maximal element in a portion of array of integers starting at given index. 
//Using it write another method that sorts an array in ascending / descending order.

using System;

class FindMaximalElementInPartOfArray
{
    
    static int maxIndex;

    static void Main()
    {
        int[] array1 = new int[8];
        int option = 0;
        int startIndex = 0;

        array1 = GenerateArray(array1);
        PrintArray(array1);

        Console.WriteLine("Enter a start index for finding the max element: ");
        startIndex = int.Parse(Console.ReadLine());
        startIndex--;

        Console.WriteLine("Max index in part of array from index {0} to end is {1}", startIndex, MaxFromIndex(array1, startIndex));

        do
        {
            Console.WriteLine("To sort the array choose :\n 1. Ascending\n 2. Descending ");
            option = int.Parse(Console.ReadLine());
        }
        while ((option != 1) && (option != 2));
        if (option == 1)
        {
            array1 = SortAscending(array1);
        }
        else
        {
            array1 = SortDescending(array1);
        }

        PrintArray(array1);

    }

    static int[] GenerateArray(int[] array)
    {
        Random randomNumber = new Random();
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = randomNumber.Next(16);
        }
        return array;
    }

    static void PrintArray(int[] array)
    {
        Console.Write("Your array is : ");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();

    }

    static int MaxFromIndex(int[] array, int index)
    {
        int max = 0;
        for (int i = index; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
                maxIndex = i;
            }
        }

        return max;
    }

    static int[] SortAscending(int[] array)
    {
        array = SortDescending(array);
        Array.Reverse(array);

        return array;
    }

    static int[] SortDescending(int[] array)
    {
        for (int i = 0; i < array.Length - 1; i++)
        {
            int temp = MaxFromIndex(array, i);
            array[maxIndex] = array[i];
            array[i] = temp;
        }

        return array;
    }

}
