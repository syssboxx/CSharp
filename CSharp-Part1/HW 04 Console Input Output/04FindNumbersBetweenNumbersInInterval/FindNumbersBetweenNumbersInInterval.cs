//Write a program that reads two positive integer numbers and prints how many numbers p exist between them such that 
//the reminder of the division by 5 is 0 (inclusive). Example: p(17,25) = 2.

using System;

class FindNumbersBetweenNumbersInInterval
{
    static void Main()
    {
        uint startNumber;
        uint endNumber;
        int counter=0;

        Console.WriteLine("Enter the first number : ");
        startNumber = uint.Parse(Console.ReadLine());
        Console.WriteLine("Enter the second number :");
        endNumber = uint.Parse(Console.ReadLine());

        for (uint i = startNumber; i <=endNumber; i++)
        {
            if (i%5==0)
            {
                counter++;
            }
            
        }
        Console.WriteLine("Between {0} and {1} there are {2} numbers which can be divided by 5",startNumber,endNumber,counter);
    }
}
