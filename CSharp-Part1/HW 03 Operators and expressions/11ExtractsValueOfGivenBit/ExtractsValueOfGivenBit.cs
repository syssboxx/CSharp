//Write an expression that extracts from a given integer i the value of a given bit number b. Example: i=5; b=2 -> value=1.

using System;

class ExtractsValueOfGivenBit
{
    static void Main()
    {
        int number;
        int bit;
        int mask;
        int value;

        Console.Write("Enter an integer number : ");
        number = int.Parse(Console.ReadLine());
        Console.WriteLine("Binar representation :{0}", Convert.ToString(number, 2).PadLeft(8, '0'));
        Console.Write("Enter the bit number (counting from 0) to extract its value : ");
        bit = int.Parse(Console.ReadLine());

        mask = 1 << bit;
        value = (mask & number) >> bit;
        Console.WriteLine(value);
    }
}
