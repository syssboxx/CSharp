//Write a program that reads two arrays from the console and compares them element by element.

using System;

namespace ComapareArrays
{
    class ComapareArrays
    {
        static void Main()
        {
            Console.WriteLine("Enter the lenght of 2 arrays (n1,n2) :");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());

            int[] array1 = new int[n1];
            int[] array2 = new int[n2];

            bool isEqual = false;
 
            //initalize the arrays
            Console.WriteLine("Fill first array:");
            for (int i = 0; i < array1.Length; i++)
            {
                array1[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Fill second array:");
            for (int i = 0; i < array2.Length; i++)
            {
                array2[i] = int.Parse(Console.ReadLine());
            }

            //compare the arrays length
            if (n1 == n2)
            {
                //compare arrays element by element
                for (int i = 0; i < array1.Length; i++)
                {
                    if (array1[i] != array2[i])
                    {
                        isEqual = false;
                        break;
                    }
                }  
            }
            else
            {
                isEqual = false;  
            }
            Console.WriteLine(isEqual ? "The 2 arrays are equals." : "The 2 arrays are not equals.");
            
        }
    }
}
