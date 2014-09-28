//Write a program that finds the most frequent number in an array. Example:
//	{4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3}  4 (5 times)

using System;


class MostFrequentNumber
{
    static void Main()
    {
        int[] array = { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 };
        //int[] array = { 1,2,3,4,5,6,7,8 };
        
        Console.Write("Initial array : ");
        foreach (int element in array)
        {
            Console.Write(element + " ");
        }
        Console.WriteLine();

        int number = 0;
        int mostFrequentNumber=0;
        int frequency = 1;
        int maxFrequency = 1;

        
        for (int i = 0; i < array.Length; i++)
        {
            frequency = 1;
            number = array[i];
            for (int j = i+1; j < array.Length; j++)
            {
                if (number==array[j])
                {
                    frequency++;
                }
 
            }
            if (frequency > maxFrequency)
            {
                maxFrequency = frequency;
                mostFrequentNumber = number;
            } 
      }
        if (mostFrequentNumber>1)
        {
            Console.WriteLine("The most frequent number is {0} - appears {1} times", mostFrequentNumber, maxFrequency); 
        }
        else
        {
            Console.WriteLine("All elements appears {0} times", maxFrequency);
        }
         
    }
}