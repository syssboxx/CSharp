//Write a boolean expression that returns if the bit at position p (counting from 0) in a given integer number v has value of 1. Example: v=5; p=1 -> false.

using System;

class ReturnifBitIs1
{
    static void Main()
    {
        int number;
        int position;
        int mask;
        bool ifBitValue1=false;

        Console.Write("Enter a number : ");
        number = int.Parse(Console.ReadLine());
        Console.WriteLine("Binar representation :{0}",Convert.ToString(number,2).PadLeft(8,'0'));
        Console.Write("Enter a position (counting from 0) : ");
        position=int.Parse(Console.ReadLine());

        mask=1<<position;
        ifBitValue1=((number & mask) >> position) == 1;
        Console.WriteLine(ifBitValue1);
    }
}
