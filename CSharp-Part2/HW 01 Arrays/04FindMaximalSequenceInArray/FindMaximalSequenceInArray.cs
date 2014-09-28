//Write a program that finds the maximal sequence of equal elements in an array.
//Example: {2, 1, 1, 2, 3, 3, 2, 2, 2, 1}  {2, 2, 2}.


using System;

    class FindMaximalSequenceInArray
    {
        static void Main()
        {
            int[] array = { 2, 1, 1, 2, 3, 3, 2, 2, 2, 1 };

            int maximalSequence = 0;
            int startElement = 0;
            int finalElement = 0;
            int count = 1;

            for (int i = 0; i < array.Length - 1; i++)
            {
                Console.WriteLine(array[i]);
                if (array[i] == array[i + 1])
                {
                    count++;
                }
                else
                {
                    count = 1;
                }
                
                if (count > maximalSequence)
                {
                    maximalSequence = count;
                    finalElement = i+1;
                }
            }
            startElement = finalElement - maximalSequence;
            Console.Write("The maximal sequence of {0} equals elements in the array is ", maximalSequence);
            for (int i = finalElement; i > startElement; i--)
            {
                Console.Write(array[i]);
            }
            Console.WriteLine();
        }
    }

