//Write a program that gets a number n and after that gets more n numbers and calculates and prints their sum. 

using System;

class SumOfNumbers
{
    static void Main()
    {
        int totalNumbers;
        int number;
        int sum = 0;

        Console.Write("Enter a number : ");
        totalNumbers = int.Parse(Console.ReadLine());
        Console.WriteLine("Now enter {0} numbers and i will calculate their sum.",totalNumbers);
        for (int i = 1; i <=totalNumbers; i++)
        {
            Console.Write("Enter number {0} : ",i);
            number = int.Parse(Console.ReadLine());
            sum += number;
        }
        Console.WriteLine("The sum is {0}",sum);
        

    }
}