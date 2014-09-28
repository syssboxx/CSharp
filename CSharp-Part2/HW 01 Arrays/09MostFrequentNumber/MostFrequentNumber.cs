//Write a program that finds the most frequent number in an array. Example:
//	{4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3}  4 (5 times)

using System;


class MostFrequentNumber
{
    static void Main()
    {
        int[] array = { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 };
        int counter = 1;
        int maxFrequency = 0;
        int mostFrequentNumber = 0;

        Console.Write("Initial array : ");
        foreach (int number in array)
        {
            Console.Write(number+" ");
        }
        Console.WriteLine();

        
        for (int i = 1; i < array.Length-1; i++)
        {
            //sort the array
            Array.Sort(array);

            //find the most frequent successive number
            if (array[i]==array[i+1])
            {
                counter++;
            }
            else
            {
                counter = 1;
            }
            if (counter>maxFrequency)
            {
                maxFrequency = counter;
                mostFrequentNumber = array[i];
            }

        }
        Console.Write("Sorted array : ");
        foreach (int number in array)
        {
            Console.Write(number+" ");
        }
        Console.WriteLine();

        Console.WriteLine("The most frequent number is {0} - appears {1} times",mostFrequentNumber,maxFrequency);
       

        
    }
}