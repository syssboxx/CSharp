//Write an expression that checks if given integer is odd or even.

using System;

class CheckIfIntegerOdd
{
    static void Main()
    {
        Console.WriteLine("Enter a number to check if it is odd or even : ");
        int number = int.Parse(Console.ReadLine());
        if (number % 2 == 0)
        {
            Console.WriteLine("The number {0} is even",number);
        }
        else
        {
            Console.WriteLine("The number {0} is odd",number);
        }
    }
}