//Write a program that reads two numbers N and K and generates all the combinations of K distinct elements from the set [1..N]. 

//N = 5, K = 2 
// - >{1, 2}, {1, 3}, {1, 4}, {1, 5}, {2, 3}, {2, 4}, {2, 5}, {3, 4}, {3, 5}, {4, 5}


using System;

class GenerateAllCombinationsOfDistinctElements
{
    static int N;
    static int K;
    static int count = 0;

    //resursive solution

    static void Main()
    {
        Console.Write("Enter N=");
        N = int.Parse(Console.ReadLine());

        Console.Write("Enter K<N. K=");
        K = int.Parse(Console.ReadLine());

        int [] loops = new int[N];

        GenerateCombinations(loops,0,1);
        Console.WriteLine("Total {0} combinations", count);
    }

    public static void GenerateCombinations(int[] array, int currentPoition,int currentNumber)
    {

        //if the last element is reached break and print all the variations
        if (currentPoition == K)
        {
            PrintLoops(array);
            count++;
            return;
        }

        for (int i = currentNumber; i <= N; i++)
        {
            array[currentPoition] = i;
            GenerateCombinations(array,currentPoition + 1,i+1);
        }
    }

    public static void PrintLoops(int[] array)
    {
        for (int i = 0; i < K; i++)
        {
            Console.Write("{0} ", array[i]);
        }
        Console.WriteLine();

    }
}