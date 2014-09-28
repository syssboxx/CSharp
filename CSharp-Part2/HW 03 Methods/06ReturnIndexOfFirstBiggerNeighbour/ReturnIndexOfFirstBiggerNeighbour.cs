//Write a method that returns the position of the first element in array that is bigger than its neighbors, 
//or -1, if there’s no such element.


using System;

class ReturnpositionOfFirstBiggerNeighbour
{
    static void Main()
    {
        Console.Write("Enter array size :");
        int size = int.Parse(Console.ReadLine());

        int[] array = new int[size];
        int biggerNeighbourPosition = 0;

        ReadArray(array);

              
        biggerNeighbourPosition = FindFirstBiggerNeighbour(array);
        Console.WriteLine("The first element which is bigger than its neighbours is {0}",biggerNeighbourPosition);
    }

    static void ReadArray(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write("array[{0}]=", i);
            arr[i] = int.Parse(Console.ReadLine());
        }
    }

    static int FindFirstBiggerNeighbour(int[] arr)
    {
    
            for (int position = 1; position < arr.Length-1; position++)
            {
                
                if ((arr[position] > arr[position + 1]) && (arr[position] > arr[position - 1]))
                {
                    return position;
                }
               
            }
            return -1;
        
         }
}
