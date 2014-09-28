//SELECTION SOR

//Sorting an array means to arrange its elements in increasing order. 
//Write a program to sort an array. 
//Use the "selection sort" algorithm: Find the smallest element, move it at the first position, find the smallest from the rest, move it at the second position, etc.


using System;

class SelectionSort
{
    static void Main()
    {
        Console.WriteLine("Enter number of elements of the array:");
        int n = int.Parse(Console.ReadLine());

        int[] array = new int[n];

        int smallest = 0;
        int smallestIndex = 0;

        //initialize the array with random values
        Random randomGenerator=new Random();
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = randomGenerator.Next(0, 50);
        }

        //print the generated array
        Console.Write("Inital array : ");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i]+" ");
        }
        Console.WriteLine();

        //sort the array
        for (int i = 0; i <array.Length; i++)
        {
            //Console.WriteLine("array[{0}]:{1}", i, array[i]);
            smallestIndex = i;

            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[j] < array[smallestIndex])
                {
                    smallestIndex = j;

                }
            }
             //swap the elements
             int temp = array[smallestIndex];
             array[smallestIndex] = array[i];
             array[i] = temp;
            
            
        }
                
        //print the sorted array
        Console.Write("Sorted array : ");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();

    }
}
