//Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers. 
//Use variable number of arguments.


using System;


class SetOfIntegers
{
    static void Main()
    {
        Random randomNumber = new Random();

        MinOfNumbers(randomNumber.Next(10), randomNumber.Next(10), randomNumber.Next(10), randomNumber.Next(10), randomNumber.Next(10), randomNumber.Next(10), randomNumber.Next(10), randomNumber.Next(10), randomNumber.Next(10), randomNumber.Next(10), randomNumber.Next(10));

        MaxOfNumbers(randomNumber.Next(10), randomNumber.Next(10), randomNumber.Next(10), randomNumber.Next(10), randomNumber.Next(10), randomNumber.Next(10), randomNumber.Next(10), randomNumber.Next(10), randomNumber.Next(10), randomNumber.Next(10), randomNumber.Next(10));

        AvgOfNumbers(randomNumber.Next(10), randomNumber.Next(10), randomNumber.Next(10), randomNumber.Next(10), randomNumber.Next(10), randomNumber.Next(10), randomNumber.Next(10), randomNumber.Next(10), randomNumber.Next(10), randomNumber.Next(10), randomNumber.Next(10));

        SumOfNumbers(randomNumber.Next(10), randomNumber.Next(10), randomNumber.Next(10), randomNumber.Next(10), randomNumber.Next(10), randomNumber.Next(10), randomNumber.Next(10), randomNumber.Next(10), randomNumber.Next(10), randomNumber.Next(10), randomNumber.Next(10));

        ProductionOfNumbers(randomNumber.Next(10), randomNumber.Next(10), randomNumber.Next(10), randomNumber.Next(10), randomNumber.Next(10), randomNumber.Next(10), randomNumber.Next(10), randomNumber.Next(10), randomNumber.Next(10), randomNumber.Next(10), randomNumber.Next(10));
    }

    static void PrintArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
    }

    static void MinOfNumbers(params int[] array)
    {
        Console.WriteLine("The sequence of integers is:");
        PrintArray(array);

        Array.Sort(array);

        Console.WriteLine("The minimal number is {0}", (array[0]));
    }

    static void MaxOfNumbers(params int[] array)
    {
        Console.WriteLine("The sequence of integers is:");
        PrintArray(array);

        Array.Sort(array);

        Console.WriteLine("The maximal number is {0}", (array[array.Length - 1]));
    }

    static void AvgOfNumbers(params int[] array)
    {
        Console.WriteLine("The sequence of integers is:");
        PrintArray(array);

        int sum = 0;

        for (int i = 0; i < array.Length; i++)
        {
            sum = sum + array[i];
        }

        Console.WriteLine("The average number is {0}", (sum / array.Length));
    }

    static void SumOfNumbers(params int[] array)
    {
        Console.WriteLine("The sequence of integers is:");
        PrintArray(array);

        int sum = 0;

        for (int i = 0; i < array.Length; i++)
        {
            sum = sum + array[i];
        }

        Console.WriteLine("The sum of integers is {0}", sum);
    }

    static void ProductionOfNumbers(params int[] array)
    {
        Console.WriteLine("The sequence of integers is:");
        PrintArray(array);

        long prod = array[0];

        for (int i = 1; i < array.Length; i++)
        {
            prod = prod * array[i];
        }

        Console.WriteLine("The production of integers is {0}", prod);
    }
}
