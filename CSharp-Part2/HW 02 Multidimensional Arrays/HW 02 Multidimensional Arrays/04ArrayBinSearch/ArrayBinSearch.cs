//Write a program, that reads from the console an array of N integers and an integer K, 
//sorts the array and using the method Array.BinSearch() finds the largest number in the array which is ≤ K. 

// TO TEST
// K=5 , 2 5 7 1 3 
// K=6 , 2 5 7 1 3
// K=5 , 6 7 13 9 52

using System;
class ArrayBinSearch
{
    static void Main()
    {
        Console.Write("Enter number of elements:");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Enter number k=");
        int k = int.Parse(Console.ReadLine());

        int[] array=new int[n];
        int index= 0;
        int biggestIndex = 0;

        //read an array 
        for (int i = 0; i < array.Length; i++)
			{
                Console.Write("Enter element[{0}]=",i);
                array[i] = int.Parse(Console.ReadLine());
			}

        //sort the array
        Array.Sort(array);

        //print the sorted array
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("{0,3}", array[i]);
        }
        Console.WriteLine();

       for (int i = 0; i < array.Length; i++)
        {
            index = Array.BinarySearch(array, k);
            if (index>0)
            {
                Console.WriteLine ("the biggest element is {0} (found on position {1})",array[index],index);
                break;
               
            }
            else if (index<0) //number not found
            {
                if (index == -1) //the first element is>k
                {
                    Console.WriteLine("There's no such element <=k");
                    break;
                }
                else
                {
                    //the searched element is not found
                    //~index is the index of the searched element if it was present, ~index-1 is the previous
                    biggestIndex = ~index-1; 
                    Console.WriteLine("The biggest element <={0} is {1} (found on position {2})",k,array[biggestIndex], biggestIndex);
                    break;
                }
             
            }
            
        }
        
    }
}