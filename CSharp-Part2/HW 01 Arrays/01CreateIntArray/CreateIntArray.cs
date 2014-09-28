//Write a program that allocates array of 20 integers and initializes each element by its index multiplied by 5. 
//Print the obtained array on the console.

using System;

namespace CreateIntArray
{
    class Program
    {
        static void Main()
        {
            int n = 20;
            int[] array = new int[n];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i * 5;
            }

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
