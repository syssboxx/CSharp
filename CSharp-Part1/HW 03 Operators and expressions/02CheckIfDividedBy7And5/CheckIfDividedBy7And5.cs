//Write a boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 in the same time.

using System;

class CheckIfDividedBy7And5
{
    static void Main()
    {
        Console.WriteLine("Enter a number : ");
        int number = int.Parse(Console.ReadLine());
        if ((number % 5 == 0) && (number % 7 == 0))
        {
            Console.WriteLine("The number {0} can be divided in 5 and 7 in the same time", number);
        }
        else
        {
            Console.WriteLine("The number {0} can't be divided in 5 and 7 in the same time",number);
        }
    }
}