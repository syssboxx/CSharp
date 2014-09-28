//Write a program that reads an integer number n from the console and prints all the numbers in the interval [1..n], each on a single line.

using System;

class PrintNumbersOnSingleLine
{
    static void Main()
    {
        Console.Write("Enter how many numbers you want to print : ");
        int totalNumber = int.Parse(Console.ReadLine());

        Console.WriteLine("The numbers is the interval [1..{0}] are :",totalNumber);
        for (int i = 1; i <= totalNumber; i++)
        {
            Console.WriteLine(i);
        }
    }
}
