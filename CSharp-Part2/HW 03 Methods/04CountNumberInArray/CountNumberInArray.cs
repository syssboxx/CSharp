//Write a method that counts how many times given number appears in given array. 
//Write a test program to check if the method is working correctly.


using System;

class CountNumberInArray
{
    static void Main()
    {
        Console.Write("Enter array size=");
        int size=int.Parse(Console.ReadLine());
        int[] array = new int[size];
        int counter=0;

        //read array
        ReadArray(array);

        Console.Write("Enter number to check =");
        int number = int.Parse(Console.ReadLine());

        //counts number of parition of number in the array
        counter=CountNumber(number, array);
        Console.WriteLine("Number {0} appears {1} times in the sequence",number,counter);
        
    }

    static void ReadArray(int [] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write("array[{0}]=",i);
            arr[i] = int.Parse(Console.ReadLine());
        }
    }

    static int CountNumber(int target, int[] arr)
    {
        int result = 0;
        for (int index = 0; index < arr.Length; index++)
        {
            if (arr[index]==target)
            {
                result++;
            }
        }
        return result;
    }
}
