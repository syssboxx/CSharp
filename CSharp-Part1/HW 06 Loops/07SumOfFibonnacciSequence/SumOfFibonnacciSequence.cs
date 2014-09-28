//Write a program that reads a number N and calculates the sum of the first N members of the sequence of Fibonacci: 
//0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …

using System;

class SumOfFibonnacciSequence
{
    static void Main()
    {
        Console.Write("Enter how many numbers of Fibonacci you want to sum : ");
        int n = int.Parse(Console.ReadLine());
        int element1 = 0;
        int element2 = 1;
        int sum = element1+element2;
        Console.Write("The sum of {0} + {1}",element1,element2);
        
        for (int i = 1; i <= n-2; i++)
        {
            int element = element1 + element2;
            element1 = element2;
            element2 = element;
            Console.Write(" + {0}",element);
            sum = sum + element;
        }
        Console.WriteLine(" = {0}",sum);
    }
}
