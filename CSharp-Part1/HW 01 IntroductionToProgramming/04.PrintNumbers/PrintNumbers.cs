//Write a program to print the numbers 1, 101 and 1001.

using System;

class PrintNumbers
{
    static void Main()
    {
        /* direct print of the numbers
        Console.WriteLine(1);
        Console.WriteLine(101);
        Console.WriteLine(1001);
        */

        //1,101 and 1001 are the binary representation of 1,5 and 9.They can be printed with a loop 
        for (int i = 1; i < 10; i=i+4)
        {
            string binaryNumber = Convert.ToString(i, 2);
            Console.WriteLine(binaryNumber);
            
        }

    }
}

