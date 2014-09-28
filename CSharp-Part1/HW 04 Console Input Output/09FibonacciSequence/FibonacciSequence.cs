//Write a program to print the first 100 members of the sequence of Fibonacci: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …

using System;

class FibonacciSequence
{
    static void Main()
    {
        //use of ulong to print a valid positive integer numbers (the last 100 members are too big for long)
        ulong members = 100;
        ulong number0 = 0;
        ulong number1 = 1;
        ulong number=0;
        
        //print the first 2 members, then use a loop to calculate and print the other members
        Console.Write("Fibonacci sequence :\n {0}, {1}, ", number0, number1);
        for (ulong i = 0; i < members-2; i++)
        {
            number = number0 + number1;
            number0 = number1;
            number1 = number;
            Console.Write("{0}, ", number);
        }

        
    }
}


