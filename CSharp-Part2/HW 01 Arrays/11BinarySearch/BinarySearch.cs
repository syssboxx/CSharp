//Write a program that finds the index of given element in a sorted array of integers by using the binary search algorithm (find it in Wikipedia).


using System;

class BinarySearch
{
    static void Main()
    {
        int[] array = {1,2,3,4,5,6,7,8,9,10 };

        Console.WriteLine("Enter key number :");
        int searchedKey = int.Parse(Console.ReadLine()); ;
        int middle = 0;
        int startArray=0;
        int endArray=array.Length-1;
        bool isFound = false;

        while (startArray <= endArray)
        {
            middle = (startArray+endArray)/2;

            if (array[middle]==searchedKey)
            {
                Console.WriteLine("The searched number is found on index {0}",middle);
                isFound = true;
                break;
            }
            else if (array[middle]>searchedKey)
            {
                endArray = middle - 1;
            }
            else
            {
                startArray = middle + 1;
            }

        }
        if (!isFound)
        {
            Console.WriteLine("The searched number is not found");
        }
    }
}
