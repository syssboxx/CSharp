//Write a program that can solve these tasks:
//Reverses the digits of a number
//Calculates the average of a sequence of integers
//Solves a linear equation a * x + b = 0
//        Create appropriate methods.
//        Provide a simple text-based menu for the user to choose which task to solve.
//        Validate the input data:
//The decimal number should be non-negative
//The sequence should not be empty
//a should not be equal to 0


using System;


class MultiProgram
{
    static void Main()
    {
        int option = 0;

        do
        {
            Console.WriteLine("Choose a program that can solve :\n 1. Reverses the digits of a number\n 2. Calculates the average of a sequence of integers\n 3. Solves a linear equation a * x + b = 0 ");
            option = int.Parse(Console.ReadLine());
        }
        while ((option != 1) && (option != 2) && (option != 3));
        if (option == 1)
        {
            ReverseProgram();
        }
        else if (option == 2)
        {
            SequenceProgram();
        }
        else
        {
            ReverseProgram();
        }
    }

    static void ReverseProgram()
    {
        decimal number;
        Console.WriteLine("Enter a positive decimal number : ");
        do
        {
            Console.WriteLine("Enter a positive decimal number : ");
            number = decimal.Parse(Console.ReadLine());
        }
        while (number < 0);
        ReverseDigit(number);
    }

    static void ReverseDigit(decimal number)
    {
        string numberToString = number.ToString();
        char[] numberToChar = numberToString.ToCharArray();
        char[] reversedNumber = new char[numberToChar.Length];

        if (number > 0)
        {
            //reverse the digits in the two char arrays
            for (int i = 0; i < numberToChar.Length; i++)
            {
                reversedNumber[numberToChar.Length - 1 - i] = numberToChar[i];
            }
        }
        else
        {
            for (int i = 1; i < numberToChar.Length; i++)
            {
                reversedNumber[0] = numberToChar[0];
                reversedNumber[numberToChar.Length - i] = numberToChar[i];
            }
        }

        foreach (char digit in reversedNumber)
        {
            Console.Write(digit);
        }
        Console.WriteLine();
    }

    static void SequenceProgram()
    {
        string numbers;

        do
        {
            Console.WriteLine("Enter a sequense of integer numbers, separated with space : ");
            numbers = Console.ReadLine();
        }
        while (numbers.Length <= 0);
        Sequence(numbers);
    }

    static void Sequence(string str)
    {
        string[] strArray = str.Split(new Char[] { ' ' });

        int sum = 0;
        foreach (string s in strArray)
        {
            sum = sum + Convert.ToInt32(s);
        }
        Console.WriteLine("The average of the integers is {0}", sum / strArray.Length);
    }

    static void PolynomialsProgram()
    {
        int[] numbers = new int[3];

        Console.WriteLine("Please enter the elements of the polynomial of type ax + b = c");
        do
        {
            Console.WriteLine("Enter a coeficient a : ");
            numbers[1] = int.Parse(Console.ReadLine());
        }
        while (numbers[1] != 0);

        Console.WriteLine("Enter a coeficient b : ");
        numbers[0] = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter a result c : ");
        numbers[2] = int.Parse(Console.ReadLine());

        Console.WriteLine("The value of x is {0}", ((numbers[2] - numbers[0]) / numbers[1]));
    }
}
