//Write a program that finds the sequence of maximal sum in given array. Example:
//	{2, 3, -6, -1, 2, -1, 6, 4, -8, 8}  {2, -1, 6, 4}


using System;

class SequenceOfMaximumSum
{
    static void Main()
    {
        //algorithm of Kadane
        //calculate the sum of the first element end the next
        //if the current element is bigger than the sum the sum is set to its value and its index is the start index of the searched sequence
        //the end index is when the sum is not maximal anymore  
 
        int[] array = { 2, 3, -6, -1, 2, -1, 6, 4, -8, 8 };

        int startIndex = 0;
        int endIndex = 0;
        int startIndexTemp = 0;
        int currentSum = 0;
        int maxSum = int.MinValue;

        for (int i = 0; i < array.Length; i++)
        {
            currentSum = currentSum+array[i];
            if (array[i]>currentSum)
            {
                currentSum = array[i];
                startIndexTemp = i;
            }

            if (currentSum>maxSum)
            {
                maxSum = currentSum;
                startIndex = startIndexTemp;
                endIndex = i;
            }
        }

        for (int j = startIndex; j <= endIndex; j++)
        {
            Console.Write(array[j]+" ");
        }
        Console.WriteLine();
        Console.WriteLine("The maximal sum is {0}",maxSum);
    }
}
