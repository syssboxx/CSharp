//Write a program that finds the maximal increasing sequence in an array. Example: {3, 2, 3, 4, 5, 2, 2, 4}  {2, 3, 4}.


using System;
using System.Collections.Generic;

class MaximalIncreasingSequence
{
    static void Main()
    {
        int[] array = { 3, 2, 3, 4, 5, 2, 2, 4, 5, 6, 7 };

        int countIncreasingElements = 1;
        int maximalIncreasingSequence = 0;
        int startSequence = 0;
        int endSequence = 0;


        for (int i = 1; i < array.Length; i++)
        {
            //Console.Write(array[i]+" ");
            if (array[i-1]<array[i])
            {
                countIncreasingElements++; 
            }
            else
            {
                countIncreasingElements = 1;
            }
            if (maximalIncreasingSequence<countIncreasingElements)
            {
                maximalIncreasingSequence = countIncreasingElements;
                endSequence = i;

            }
            startSequence = endSequence - maximalIncreasingSequence+1;
         }
        Console.Write("The maximal sequence of {0} increasing is ",maximalIncreasingSequence);

        for (int i = startSequence; i <=endSequence; i++)
        {
            Console.Write(array[i]+" ");
        }
        Console.WriteLine();
    }
}