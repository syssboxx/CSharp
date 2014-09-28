//Write an expression that checks for given integer if its third digit (right-to-left) is 7. E. g. 1732  true.

using System;

class CheckIfThirdDigit7
{
    static void Main()
    {
        int number;
        int dividedBy100;
        int thirdBit;
        bool thirdBitIs7;
        Console.WriteLine("Enter a number to check : ");
        number = int.Parse(Console.ReadLine());
        dividedBy100 = number / 100;
        thirdBit = dividedBy100 % 10;
        if (thirdBit == 7)
        {
            thirdBitIs7 = true;
         }
        else 
        {
            thirdBitIs7 = false;
         }
        Console.WriteLine("{0}.The third digit is {1}", thirdBitIs7, thirdBit);

    }
}