//Write a program that reads two integer numbers N and K and an array of N elements from the console. 
//Find in the array those K elements that have maximal sum.


using System;
class MaximalSumInArray
{
    static void Main()
    {
        Console.WriteLine("Enter number of elements of the array");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter numbers of elements to find maximal sum");
        int k = int.Parse(Console.ReadLine());

        int[] array = new int[n];

        //to test 
        //int[] array = {12,5,8,6,7,1,2} -> max sum 25 {12 5 8}

        //read an array
        Console.WriteLine("Fill the array :");
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        //for sum of non conseccutive elements
        //sort the array first and than print only the last k elements
        int maxSum = 0;
        Array.Sort(array);

        for (int i = array.Length - k; i < array.Length; i++)
        {
            maxSum = maxSum + array[i];
            Console.Write(array[i] + " ");
        }
        Console.Write(" Maximal sum={0}", maxSum);
        Console.WriteLine();

        //find sum of consecCutive elements ONLY and save them in a string
        /*
         * 
        int maximalSum = int.MinValue;
        string maxSequence = "";
        for (int i = 0; i < array.Length; i++)
        {
            string sequence = "";
            int sum = 0;

            //the element goest out of the array
            if (i>array.Length-k)
            {
                break;
            }
                   
            for (int j = i; j < i+k; j++)
            {
                sum = sum+array[j];
                sequence = sequence +" "+(array[j]).ToString();
            }
            
            if (sum>maximalSum)
            {
                maximalSum = sum;
                maxSequence = sequence;
            }
        }
        Console.Write("The maximal sum of {0} successive elements is {1} of ({2})",k,maximalSum,maxSequence);
        Console.WriteLine();
         * */

        
    }
}

