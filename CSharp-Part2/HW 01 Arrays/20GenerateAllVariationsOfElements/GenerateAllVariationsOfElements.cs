//Write a program that reads two numbers N and K and generates all the variations of K elements from the set [1..N]. 

//	N = 3, K = 2
//->{1, 1}, {1, 2}, {1, 3}, {2, 1}, {2, 2}, {2, 3}, {3, 1}, {3, 2}, {3, 3}


using System;

class GenerateAllVariationsOfElements
{
    //resursive solution
    
    static int N;
    static int K;
    static int count = 0;

        static void Main()
    {
        Console.Write("Enter N=");
        N = int.Parse(Console.ReadLine());

        Console.Write("Enter K<N. K=");
        K = int.Parse(Console.ReadLine());

        int[] loops = new int[K];

        GenerateVariations(loops, 0);
        Console.WriteLine("Total {0} variations", count);
    }

    public static void GenerateVariations(int[] array, int currentPoition)
    {

        //if the last element is reached break and print all the variations
        if (currentPoition == K)
        {
            PrintLoops(array);
            count++;
            return;
        }

        for (int i = 1; i <= N; i++)
        {
            array[currentPoition] = i;
            GenerateVariations(array, currentPoition + 1);
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

    //non resursive solution 

/*static void Main()
{
    Console.Write("Enter N=");
    int N = int.Parse(Console.ReadLine());

    Console.Write("Enter K<N. K=");
    int K = int.Parse(Console.ReadLine());

    int[] loops = new int[K];

    int count = 0;

    for (int i = 0; i < Math.Pow(N,K); i++)
    {
        int conv = i;
        for (int j = 0; j < K; j++)
        {
            loops[K - j - 1] = conv % N;
            conv = conv / N;
        }
        Console.Write("{0} ",loops[0]+1);
        for (int j = 1; j < K; j++)
        {
            Console.Write("{0}", loops[j]+1);
        }
        Console.WriteLine();
        count++;
    }
       
   Console.WriteLine("Total {0} variations", count);
 }
}  
 */



