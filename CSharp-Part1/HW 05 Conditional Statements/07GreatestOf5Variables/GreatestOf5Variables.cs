//Write a program that finds the greatest of given 5 variables. 
// array

using System;

class GreatestOf5Variables
{
    static void Main()
    {
        int number;
        int[] numbers = new int[5];
        int greatest;

        Console.WriteLine("Enter 5 numbers :");
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write("number{0} = ",i+1);
            number = int.Parse(Console.ReadLine());
            numbers[i] = number;
        }
        greatest = numbers[0];
        for (int i = 0; i < numbers.Length; i++)
        {
            if (greatest < numbers[i])

            {
                greatest = numbers[i]; 
            }
        }
        Console.WriteLine("The greatest number is {0}",greatest);
    } 
}

