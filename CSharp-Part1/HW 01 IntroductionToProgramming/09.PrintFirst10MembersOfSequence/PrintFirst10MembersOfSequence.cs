
//Write a program that prints the first 10 members of the sequence: 2, -3, 4, -5, 6, -7, ...

using System;

class PrintFirst10MembersOfSequence
{
    static void Main()
    {
        DateTime startTimer = DateTime.Now;
        int length = 10001;
        int start = 2;

        for (int i = start; i < start+length; i++)
        {
            if (i % 2 != 0)
            {
                Console.Write("-"+i+" ");
            }
            else
                Console.Write(i+" ");
        }
        Console.WriteLine();
        DateTime endTimer = DateTime.Now;
        TimeSpan timer = endTimer - startTimer;
        Console.WriteLine(timer);
    }
}
