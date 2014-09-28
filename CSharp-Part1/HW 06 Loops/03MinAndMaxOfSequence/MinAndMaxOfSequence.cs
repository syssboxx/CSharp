//Write a program that reads from the console a sequence of N integer numbers and returns the minimal and maximal of them.

using System;

class MinAndMaxOfSequence
{
    static void Main()
    {
        Console.Write("Enter number n = ");
        int n = int.Parse(Console.ReadLine());
        int[] numbers = new int[n];
        int minimal = 0;
        int maximal;
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write("number {0} :",i+1);
            numbers[i] = int.Parse(Console.ReadLine());
        }
        maximal=numbers[0];
        minimal = numbers[0];
        for (int j = 0; j < numbers.Length; j++)
        {
            if (maximal<numbers[j])
            {
                maximal = numbers[j];
            }
            if (minimal>numbers[j])
            {
                minimal = numbers[j];
            }
        }
        Console.WriteLine("The minimal number is {0}",minimal);
        Console.WriteLine("The maximal number is {0}",maximal);
    }
}
