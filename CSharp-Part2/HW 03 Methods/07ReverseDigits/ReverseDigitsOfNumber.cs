//Write a method that reverses the digits of given decimal number. 
//Example: 256  652


using System;

class ReverseDigitsOfNumber
{
    static void Main()
    {
        Console.Write("Enter a number to reverse : ");
        string numberStr = Console.ReadLine();
        Console.Write("Reversed number : ");
        ReverseDigits(numberStr);

    }

    static void ReverseDigits(string input)
    {
        char[] reversed = new char[input.Length];
        
        for (int i = 0; i < input.Length; i++)
        {
            reversed[i] = input[input.Length - i - 1];
            Console.Write(reversed[i]);
        }
        Console.WriteLine();
    }
}
