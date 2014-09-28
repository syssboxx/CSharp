//Write program that asks for a digit and depending on the input shows the name of that digit (in English) using a switch statement.


using System;

class ShowDigitName
{
    static void Main()
    {
        int digit;
        Console.WriteLine("Enter a digit (0-9) :");
        while ((!int.TryParse(Console.ReadLine(), out digit)))
        {
            Console.WriteLine("Enter a valid digit (0-9) : ");
        }
        switch (digit)
        {
            case 0: Console.WriteLine("zero"); break;
            case 1: Console.WriteLine("one"); break;
            case 2: Console.WriteLine("two"); break;
            case 3: Console.WriteLine("three"); break;
            case 4: Console.WriteLine("four"); break;
            case 5: Console.WriteLine("five"); break;
            case 6: Console.WriteLine("six"); break;
            case 7: Console.WriteLine("seven"); break;
            case 8: Console.WriteLine("eight"); break;
            case 9: Console.WriteLine("nine"); break;
            default: Console.WriteLine("You must enter a number between 0 and 9 !");break;
        }
    }
}

