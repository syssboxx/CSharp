//Write a program that, for a given two integer numbers N and X, calculates the sumS = 1 + 1!/X + 2!/X^2 + … + N!/X^N

using System;
using System.Numerics;

class SeriesSum
{
    static void Main()
    {
        Console.Write("Enter n: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter x: ");
        int x = int.Parse(Console.ReadLine());
        decimal sum=1;
        decimal factorielN = 1;
        int divider=1;

        Console.Write("The sum S = {0} ",sum);
        for (int i = 1; i <=n; i++)
        {
            factorielN = factorielN * i;
            divider= divider * x;
            decimal number = factorielN /divider;
            sum = sum + number;
            Console.Write("+ {0:F4} ",number);
        }
        
        Console.WriteLine("= {0:F4}", sum);

    }
}
