//Write a method that checks if the element at given position in given array of integers is bigger than its two neighbors (when such exist).

// TO TEST 
// 1 5 7 2 3 8 
// 5 1 7 2 8 3
//POSITION - 2, 3,0,5 

using System;

class CheckElementIfBiggerThanNeighbours
{
    static void Main()
    {
        Console.Write("Enter array size :");
        int size = int.Parse(Console.ReadLine());

        int[] array = new int[size];
        bool isBigger = false;

        ReadArray(array);

        Console.Write("Enter position to check :");
        int position = int.Parse(Console.ReadLine());

        isBigger = CheckIfBiggerThanNeigbours(array, position);
               
    }

    static void ReadArray(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write("array[{0}]=", i);
            arr[i] = int.Parse(Console.ReadLine());
        }
    }

    static bool CheckIfBiggerThanNeigbours(int[] arr, int index)
    {
        // inner elements
        if ((index > 0) && (index < arr.Length - 1))
        {
            if ((arr[index] > arr[index + 1]) && (arr[index] > arr[index - 1]))
            {
                Console.WriteLine("The element is bigger than his 2 neighbours");
                return true;
            }
            else
            {
                Console.WriteLine("The element is not bigger than his 2 neighbours");
                return false;
            }
        }
        else
        {

            Console.WriteLine("ONLY 1 neighbour");
            if (index == 0)
            {
                if (arr[index] > arr[index + 1])
                {
                    Console.WriteLine("The element is bigger than its neighbour.");
                }
                else
                {
                    Console.WriteLine("The element is NOT bigger than its neighbour.");
                }
            }
            if (index == arr.Length-1)
            {
                if (arr[index] > arr[index - 1])
                {
                    Console.WriteLine("The element is bigger than its neighbour.");
                }
                else
                {
                    Console.WriteLine("The element is NOT bigger than its neighbour.");
                }
            }
            return false;
        }
    }
}