//Write a program that prints all the numbers from 1 to N.

using System;

class PrintNumbers
{
    static void Main()
    {
        Console.Write("Enter number N : ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine();
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine(i);
        }
    }
}
