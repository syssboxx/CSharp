//Write a program that generates and prints to the console 10 random values in the range [100, 200].

using System;

class GenerateRandomValueInRange
{
    static void Main()
    {
        Random generator = new Random();
        Console.WriteLine("Generated random values");
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(generator.Next(100, 201));
        }

    }
}
