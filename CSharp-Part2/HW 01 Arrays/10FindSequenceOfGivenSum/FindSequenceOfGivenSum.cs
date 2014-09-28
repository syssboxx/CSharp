//Write a program that finds in given array of integers a sequence of given sum S (if present). 
// Example:	 {4, 3, 1, 4, 2, 5, 8}, S=11  {4, 2, 5}

using System;

class FindSequenceOfGivenSum
{
    static void Main()
    {
        //int[] array = { 4, 3, 1, 4, 2, 5, 8 };
        
        int startElement = 0;
        int finalElement = 0;
        bool wantedSumExist = false;
        int final = 0;

        int[] array = new int[10];
        //generate random array with 10 elements
        Random randomGenarator = new Random();

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = randomGenarator.Next(0, 11);
        }

        //print random array
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i]+" ");
        }
        Console.WriteLine();

        Console.WriteLine("Enter sum :");
        int wantedSum = int.Parse(Console.ReadLine());

        int sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum = array[i];
            for (int j = i+1; j < array.Length; j++)
            {
                sum = sum + array[j];
                if (sum >= wantedSum)
                {
                    final = j;
                    break;
                }
            }
            //Console.WriteLine(sum); - all the sums
            if (sum==wantedSum)
            {
                wantedSumExist = true;
                startElement = i;
                finalElement = final;
             }
            
         }
        //print the new sequence
        if (wantedSumExist)
        {
            for (int i = startElement; i <= finalElement; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
        else if (!wantedSumExist)
        {
            Console.WriteLine("There's no SUM=={0}",wantedSum);
        }
        
     
    }
}
