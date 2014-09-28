//Write a method that returns the last digit of given integer as an English word. 
//Examples: 512  "two", 1024  "four", 12309  "nine".


using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter number :");
        string input = Console.ReadLine();

        int lastDigit = int.Parse(input) % 10;
        string numberToName = "";
        
        numberToName = ConvertDigitToWord(lastDigit);
        Console.WriteLine("--> {0}",numberToName);
    }

    static string ConvertDigitToWord(int digit)
    {
        string name = "";
        switch (digit)
        {
            case 0: name = "zero"; break;
            case 1: name = "one"; break;
            case 2: name = "two"; break;
            case 3: name = "three"; break;
            case 4: name = "four"; break;
            case 5: name = "five"; break;
            case 6: name = "six"; break;
            case 7: name = "seven"; break;
            case 8: name = "eight"; break;
            case 9: name = "nine"; break;
            default: Console.WriteLine("error"); break;
        }

        return name;
    }
}