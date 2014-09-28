//You are given a sequence of positive integer values written into a string, separated by spaces. Write a function that reads these values from 
//given string and calculates their sum. 
//Example:
//string = "43 68 9 23 318"  result = 461

using System;

class ReadStringCalculateSum
{
    static void Main()
    {
        Console.WriteLine("Enter some positive numbers separated by space :");
        string input = Console.ReadLine();

        char [] delimiter = new char [] {' '};
        int sum = 0;

        //option RemoveEmptyEntries used to work correctly even if there's more than 1 space between numbers
        string[] elements = input.Split(delimiter,StringSplitOptions.RemoveEmptyEntries);
        int[] number = new int[elements.Length];
        
        for (int i = 0; i < elements.Length; i++)
        {
            number[i] = Int32.Parse(elements[i]);
            sum += number[i];
        }
        Console.WriteLine("The sum is {0}",sum);

    }
}
