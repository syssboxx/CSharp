//Write a program that reads 3 integer numbers from the console and prints their sum.

using System;

class SumOfIntegers
{
    static void Main()
    {
        int number1;
        int number2;
        int number3;
        int sum = 0;
        int sum1 = 0;

        Console.Write("Enter 3 integer numbers to calculate their sum.\nfirst number = ");
        number1 = int.Parse(Console.ReadLine());
        Console.Write("second number = ");
        number2= int.Parse(Console.ReadLine());
        Console.Write("third number = ");
        number3 = int.Parse(Console.ReadLine());
        sum = number1 + number2 + number3;
        Console.WriteLine("Their sum is {0}",sum);


        for (int i = 1; i <= 3; i++)
        {
            Console.Write("Enter a number = ");
            int number = int.Parse(Console.ReadLine()); ;
            sum1 += i;
        }
        Console.WriteLine("Their sum is {0}",sum1);
    }
}
