//Write a program that prints all the numbers from 1 to N, that are not divisible by 3 and 7 at the same time

using System;

class PrintNumbersNotDivisible
{
    static void Main()
    {
        Console.Write("Enter number N : ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine();
        for (int i = 1; i <= n; i++)
        {
           if (i%21==0)
            {
                continue;
            }
            Console.WriteLine(i);
        }
    }
}
